﻿using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Nikse.SubtitleEdit.PluginLogic
{
    internal partial class PluginForm : Form
    {
        private enum HIStyle { UpperCase, LowerCase, FirstUppercase, UpperLowerCase }
        internal string FixedSubtitle { get; private set; }

        private HIStyle _hiStyle = HIStyle.UpperCase;
        private bool _allowFixes = false;
        private bool _deleteLine = false;
        private bool _moodsMatched;
        private bool _namesMatched;
        private int _totalChanged;
        private Form _parentForm;
        private Subtitle _subtitle;

        public PluginForm(Form parentForm, Subtitle subtitle, string name, string description)
        {
            InitializeComponent();
            this._parentForm = parentForm;
            this._subtitle = subtitle;
            label1.Text = "Description: " + description;
            FindHearingImpairedText();

            //this.KeyDown += (s, e) =>
            //{
            //    if (e.KeyCode == Keys.Escape)
            //        this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            //};
        }

        private void PluginForm_Load(object sender, EventArgs e)
        {
            //SizeLastColumn();
            comboBox1.SelectedIndex = 0;
            this.Resize += (s, arg) =>
            {
                listViewFixes.Columns[listViewFixes.Columns.Count - 1].Width = -2;
            };
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btn_Run_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            _allowFixes = true;
            FindHearingImpairedText();
            if (_deleteLine)
            {
                foreach (ListViewItem item in this.listViewFixes.Items)
                {
                    if (item.BackColor != Color.Red)
                        continue;
                    _subtitle.RemoveLine(((Paragraph)item.Tag).Number);
                }
            }

            FixedSubtitle = _subtitle.ToText(new SubRip());
            //Cursor = Cursors.Default;
            DialogResult = DialogResult.OK;
        }

        private void checkBoxNarrator_CheckedChanged(object sender, EventArgs e)
        {
            if (_subtitle.Paragraphs.Count <= 0)
                return;
            listViewFixes.Items.Clear();
            FindHearingImpairedText();
        }

        private void CheckTypeStyle(object sender, EventArgs e)
        {
            var menuItem = sender as ToolStripMenuItem;
            if (listViewFixes.Items.Count <= 0 || menuItem == null)
                return;
            if (menuItem.Text == "Check all")
            {
                for (int i = 0; i < listViewFixes.Items.Count; i++)
                    listViewFixes.Items[i].Checked = true;
            }
            else if (menuItem.Text == "Uncheck all")
            {
                for (int i = 0; i < listViewFixes.Items.Count; i++)
                    listViewFixes.Items[i].Checked = false;
            }
            else if (menuItem.Text == "Invert check")
            {
                for (int i = 0; i < listViewFixes.Items.Count; i++)
                    listViewFixes.Items[i].Checked = !listViewFixes.Items[i].Checked;
            }
            else if (menuItem.Text == "Copy")
            {
                string text = (listViewFixes.FocusedItem.Tag as Paragraph).ToString();
                Clipboard.SetText(text);
            }
            else
            {
                if (listViewFixes.FocusedItem.BackColor != Color.Red)
                {
                    this.listViewFixes.FocusedItem.UseItemStyleForSubItems = true;
                    this.listViewFixes.FocusedItem.BackColor = Color.Red;
                    _deleteLine = true;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex < 0 || listViewFixes.Items.Count < 0)
                return;
            if ((int)_hiStyle != comboBox1.SelectedIndex)
            {
                _hiStyle = (HIStyle)comboBox1.SelectedIndex;
                listViewFixes.Items.Clear();
                FindHearingImpairedText();
            }
        }

        private void FindHearingImpairedText()
        {
            Func<Paragraph, bool> AllowFix = (p) =>
            {
                if (!_allowFixes)
                    return false;
                string ln = p.Number.ToString();
                foreach (ListViewItem item in listViewFixes.Items)
                {
                    if (item.SubItems[1].Text == ln)
                        return item.Checked;
                }
                return false;
            };

            _totalChanged = 0;
            listViewFixes.BeginUpdate();
            foreach (Paragraph p in _subtitle.Paragraphs)
            {
                if (Regex.IsMatch(p.Text, @"[\[\(\{]|:\B"))
                {
                    string oldText = p.Text;
                    string text = p.Text;

                    // (Moods and feelings)
                    if (Regex.IsMatch(p.Text, @"[\(\[\{]", RegexOptions.Compiled))
                    {
                        //Remove Extra Spaces
                        if (checkBoxRemoveSpaces.Checked)
                            text = Regex.Replace(text, "(?<=[\\(\\[\\{]) +| +(?=[\\)\\]\\}])", String.Empty, RegexOptions.Compiled);
                        text = FindMoods(text, p);
                    }

                    // Narrator:
                    if (checkBoxNames.Checked && Regex.IsMatch(text, @":\B"))
                        text = NarratorToUpper(text);

                    if (text != oldText)
                    {
                        text = Regex.Replace(text, "\\s+" + Environment.NewLine, Environment.NewLine);
                        text = Regex.Replace(text, Environment.NewLine + "\\s+", Environment.NewLine);

                        if (AllowFix(p))
                        {
                            p.Text = text;
                        }
                        else
                        {
                            if (!_allowFixes)
                            {
                                oldText = Utilities.RemoveHtmlTags(oldText);
                                text = Utilities.RemoveHtmlTags(text);
                                AddFixToListView(p, oldText, text);
                                _totalChanged++;
                            }
                        }
                    }
                    _namesMatched = false;
                    _moodsMatched = false;
                }
            }

            if (!_allowFixes)
            {
                groupBox1.ForeColor = _totalChanged <= 0 ? Color.Red : Color.Green;
                groupBox1.Text = "Total Found: " + _totalChanged;
                this.listViewFixes.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                this.listViewFixes.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                Application.DoEvents();
            }
            listViewFixes.EndUpdate();
        }

        private void AddFixToListView(Paragraph p, string before, string after)
        {
            var item = new ListViewItem() { Checked = true, UseItemStyleForSubItems = true, Tag = p };
            var subItem = new ListViewItem.ListViewSubItem(item, p.Number.ToString());
            item.SubItems.Add(subItem);

            if (_moodsMatched && _namesMatched)
                subItem = new ListViewItem.ListViewSubItem(item, "Name & Mood");
            else if (_moodsMatched && !_namesMatched)
                subItem = new ListViewItem.ListViewSubItem(item, "Mood");
            else if (_namesMatched && !_moodsMatched)
                subItem = new ListViewItem.ListViewSubItem(item, "Name");

            item.SubItems.Add(subItem);
            subItem = new ListViewItem.ListViewSubItem(item, before.Replace(Environment.NewLine,
                Configuration.ListViewLineSeparatorString));
            item.SubItems.Add(subItem);
            subItem = new ListViewItem.ListViewSubItem(item, after.Replace(Environment.NewLine,
                Configuration.ListViewLineSeparatorString));
            item.SubItems.Add(subItem);

            if (after.Replace(Environment.NewLine, string.Empty).Length != after.Length)
            {
                int idx = after.IndexOf(Environment.NewLine);
                if (idx > 2)
                {
                    string firstLine = after.Substring(0, idx).Trim();
                    string secondLine = after.Substring(idx).Trim();
                    int idx1 = firstLine.IndexOf(":");
                    int idx2 = secondLine.IndexOf(":");
                    if (idx1 > 0xE || idx2 > 0xE)
                    {
                        item.BackColor = Color.Pink;
                    }
                }
            }
            else
            {
                if (after.IndexOf(":") > 0xE)
                    item.BackColor = Color.Pink;
            }

            listViewFixes.Items.Add(item);
        }

        private string FindMoods(string text, Paragraph p)
        {
            Action<Char> FindBrackets = delegate(char openBracket)
            {
                int index = text.IndexOf(openBracket);
                if (index > -1)
                {
                    //char? closeBracket = null;
                    char closeBracket = '\0';
                    if (openBracket == '(')
                        closeBracket = ')';
                    else if (openBracket == '[')
                        closeBracket = ')';
                    else if (openBracket == '{')
                        closeBracket = '}';

                    int endIdx = text.IndexOf(closeBracket, index + 1);
                    if (endIdx < 0)
                        PrintErrorMessage(p);

                    while (index > -1 && endIdx > index)
                    {
                        string mood = text.Substring(index, (endIdx - index) + 1);
                        mood = ConvertMoodsFeelings(mood);
                        if (_moodsMatched)
                        {
                            text = text.Remove(index, (endIdx - index) + 1).Insert(index, mood);
                            index = text.IndexOf(openBracket, endIdx + 1);
                            if (index > -1)
                                endIdx = text.IndexOf(closeBracket, index + 1);
                        }
                        else
                        {
                            index = -1;
                        }
                    }
                }
            };
            FindBrackets('(');
            /*
            if (text.Contains("("))
                text = FindBrackets('(');
            else if (text.Contains("["))
                text = FindBrackets('[');
            else
                text = FindBrackets('{');
            */
            text = text.Replace("  ", " ");
            text = text.Replace(Environment.NewLine + " ", Environment.NewLine);
            text = text.Replace(" " + Environment.NewLine, Environment.NewLine);
            return text;
        }

        private void PrintErrorMessage(Paragraph p)
        {
            MessageBox.Show(string.Format("Error while reading Line#: {0}", p.Number.ToString()),
                "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private string ConvertMoodsFeelings(string text)
        {
            if (!Regex.IsMatch(text, @"[\(\[\{]"))
                return text;
            string before = text;

            switch (_hiStyle)
            {
                case HIStyle.UpperLowerCase:
                    string helper = string.Empty;
                    bool isUpperTime = true;
                    foreach (char myChar in text)
                    {
                        helper += isUpperTime ? char.ToUpper(myChar) : char.ToLower(myChar);
                        isUpperTime = !isUpperTime;
                    }
                    text = helper;
                    break;

                case HIStyle.FirstUppercase:
                    text = Regex.Replace(text.ToLower(), @"\b\w", x => x.Value.ToUpper());
                    break;

                case HIStyle.UpperCase:
                    text = text.ToUpper();
                    break;

                case HIStyle.LowerCase:
                    text = text.ToLower();
                    break;
            }

            if (text != before)
                _moodsMatched = true;
            return text;
        }

        private string NarratorToUpper(string text)
        {
            string before = text;
            var t = Utilities.RemoveHtmlTags(text);
            int index = t.IndexOf(":");

            // like: "Ivandro Says:"
            if (index == t.Length - 1)
                return text;

            if (text.Replace(Environment.NewLine, string.Empty).Length != text.Length)
            {
                var lines = text.Replace(Environment.NewLine, "|").Split('|');
                for (int i = 0; i < lines.Length; i++)
                {
                    string cleanText = Utilities.RemoveHtmlTags(lines[i]).Trim();
                    index = cleanText.IndexOf(":");

                    if ((index + 1 < cleanText.Length - 1) && char.IsDigit(cleanText[index + 1]))
                        continue;

                    // Ivandro ismael:
                    // hello world!
                    if (i > 0 && index == cleanText.Length - 1)
                        continue;

                    if (index > 0)
                    {
                        index = lines[i].IndexOf(":");
                        if (index > 0)
                        {
                            string temp = lines[i];
                            string pre = temp.Substring(0, index);

                            // (Adele: ...)
                            if (pre.Contains("(") || pre.Contains("[") || pre.Contains("{"))
                                continue;

                            if (Utilities.RemoveHtmlTags(pre).Trim().Length > 0)
                            {
                                string firstChr = Regex.Match(pre, "(?<!<)\\w", RegexOptions.Compiled).Value;
                                int idx = pre.IndexOf(firstChr);
                                string narrator = pre.Substring(idx, index - idx);
                                if (narrator.ToUpper() == narrator)
                                    continue;

                                // You don't want to change http to uppercase :)!
                                if (narrator.Trim() != null && narrator.Trim().Length > 4 && narrator.EndsWith("https") || narrator.Trim().EndsWith("http"))
                                    continue;

                                narrator = narrator.ToUpper();
                                pre = pre.Remove(idx, (index - idx)).Insert(idx, narrator);
                                temp = temp.Remove(0, index).Insert(0, pre);
                                if (temp != lines[i])
                                {
                                    if (narrator.Contains("<"))
                                        temp = FixUpperTagInNarrator(temp);
                                    lines[i] = temp;
                                }
                            }
                        }
                    }
                }
                text = string.Join(Environment.NewLine, lines);
            }
            else
            {
                index = text.IndexOf(":");
                if (index > 0)
                {
                    string pre = text.Substring(0, index);
                    if (pre.Contains("(") || pre.Contains("[") || pre.Contains("{"))
                        return text;

                    if (Utilities.RemoveHtmlTags(pre).Trim().Length > 0)
                    {
                        string firstChr = Regex.Match(pre, "(?<!<)\\w", RegexOptions.Compiled).Value;
                        int idx = pre.IndexOf(firstChr);
                        if (idx > -1)
                        {
                            string narrator = pre.Substring(idx, index - idx);
                            if (narrator.ToUpper() == narrator)
                                return text;

                            // You don't want to change http to uppercase :)!
                            if (narrator.ToLower().Trim().EndsWith("https") || narrator.ToLower().Trim().EndsWith("http"))
                                return text;

                            narrator = narrator.ToUpper();
                            if (narrator.Contains("<"))
                                narrator = FixUpperTagInNarrator(narrator);
                            pre = pre.Remove(idx, index - idx).Insert(idx, narrator);
                            if (pre.Contains("<"))
                                pre = FixUpperTagInNarrator(pre);
                            text = text.Remove(0, index).Insert(0, pre);
                        }
                    }
                }
            }

            if (before != text)
                _namesMatched = true;
            return text;
        }

        private string FixUpperTagInNarrator(string narrator)
        {
            // Fix Upper tag
            int tagIndex = narrator.IndexOf("<");
            while (tagIndex > -1)
            {
                int closeIndex = narrator.IndexOf(">", tagIndex + 1);
                if (closeIndex > -1 && closeIndex > tagIndex)
                {
                    string temp = narrator.Substring(tagIndex, (closeIndex - tagIndex)).ToLower();
                    narrator = narrator.Remove(tagIndex, (closeIndex - tagIndex)).Insert(tagIndex, temp);
                }
                tagIndex = narrator.IndexOf("<", closeIndex);
            }
            return narrator;
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            _allowFixes = true;
            FindHearingImpairedText();
            if (_deleteLine)
            {
                foreach (ListViewItem item in this.listViewFixes.Items)
                {
                    if (item.BackColor != Color.Red)
                        continue;
                    _subtitle.RemoveLine(((Paragraph)item.Tag).Number);
                }
            }

            this.listViewFixes.Items.Clear();
            FixedSubtitle = _subtitle.ToText(new SubRip());
            _allowFixes = !_allowFixes;
            FindHearingImpairedText();
            Cursor = Cursors.Default;
        }

        private void checkBoxRemoveSpaces_CheckedChanged(object sender, EventArgs e)
        {
            if ((listViewFixes.Items.Count < 1) || (_subtitle == null) || (_subtitle.Paragraphs) == null)
                return;

            _allowFixes = false;
            listViewFixes.Items.Clear();
            FindHearingImpairedText();
        }
    }
}