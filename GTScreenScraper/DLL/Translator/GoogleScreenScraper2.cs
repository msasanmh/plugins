﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using Microsoft.Toolkit.Forms.UI.Controls;
using WebViewTranslate.Logic;

namespace WebViewTranslate.Translator
{
    /// <summary>
    /// Google translate screen scraper
    /// </summary>
    public class GoogleScreenScraper2
    {
        private readonly WebView _webView;
        private string _translateResult;
        private string _lastTranslateResult;
        private bool _loaded;
        private StringBuilder _log;
        private readonly string _googleUrl;
        private Formatting[] _formattings;

        public GoogleScreenScraper2(WebView webView, string googleUrl, string source, string target)
        {
            if (webView == null)
                return;

            _googleUrl = googleUrl.TrimEnd('/');
            _webView = webView;
            _webView.NavigationCompleted += _webView_NavigationCompleted;
            _webView.DOMContentLoaded += _webView_DOMContentLoaded;
            _webView.Navigate(new Uri(_googleUrl + "/?sl=" + source + "&tl=" + target));
        }

        private void _webView_DOMContentLoaded(object sender, Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT.WebViewControlDOMContentLoadedEventArgs e)
        {
            _loaded = true;
            _log?.AppendLine("_webView_DOMContentLoaded called");
        }

        private void _webView_NavigationCompleted(object sender, Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT.WebViewControlNavigationCompletedEventArgs e)
        {
            // _log?.AppendLine("_webView_NavigationCompleted called" + Environment.NewLine);            
        }

        public static List<TranslationPair> GetTranslationPairs()
        {
            return new List<TranslationPair>
            {
                new TranslationPair("AFRIKAANS", "af"),
                new TranslationPair("ALBANIAN", "sq"),
                new TranslationPair("AMHARIC", "am"),
                new TranslationPair("ARABIC", "ar"),
                new TranslationPair("ARMENIAN", "hy"),
                new TranslationPair("AZERBAIJANI", "az"),
                new TranslationPair("BASQUE", "eu"),
                new TranslationPair("BELARUSIAN", "be"),
                new TranslationPair("BENGALI", "bn"),
                new TranslationPair("BOSNIAN", "bs"),
                new TranslationPair("BULGARIAN", "bg"),
                new TranslationPair("BURMESE", "my"),
                new TranslationPair("CATALAN", "ca"),
                new TranslationPair("CEBUANO", "ceb"),
                new TranslationPair("CHICHEWA", "ny"),
                new TranslationPair("CHINESE", "zh"),
                new TranslationPair("CHINESE_SIMPLIFIED", "zh-CN"),
                new TranslationPair("CHINESE_TRADITIONAL", "zh-TW"),
                new TranslationPair("CORSICAN", "co"),
                new TranslationPair("CROATIAN", "hr"),
                new TranslationPair("CZECH", "cs"),
                new TranslationPair("DANISH", "da"),
                new TranslationPair("DUTCH", "nl"),
                new TranslationPair("ENGLISH", "en"),
                new TranslationPair("ESPERANTO", "eo"),
                new TranslationPair("ESTONIAN", "et"),
                new TranslationPair("FILIPINO", "tl"),
                new TranslationPair("FINNISH", "fi"),
                new TranslationPair("FRENCH", "fr"),
                new TranslationPair("FRISIAN", "fy"),
                new TranslationPair("GALICIAN", "gl"),
                new TranslationPair("GEORGIAN", "ka"),
                new TranslationPair("GERMAN", "de"),
                new TranslationPair("GREEK", "el"),
                new TranslationPair("GUJARATI", "gu"),
                new TranslationPair("HAITIAN CREOLE", "ht"),
                new TranslationPair("HAUSA", "ha"),
                new TranslationPair("HAWAIIAN", "haw"),
                new TranslationPair("HEBREW", "iw"),
                new TranslationPair("HINDI", "hi"),
                new TranslationPair("HMOUNG", "hmn"),
                new TranslationPair("HUNGARIAN", "hu"),
                new TranslationPair("ICELANDIC", "is"),
                new TranslationPair("IGBO", "ig"),
                new TranslationPair("INDONESIAN", "id"),
                new TranslationPair("IRISH", "ga"),
                new TranslationPair("ITALIAN", "it"),
                new TranslationPair("JAPANESE", "ja"),
                new TranslationPair("JAVANESE", "jw"),
                new TranslationPair("KANNADA", "kn"),
                new TranslationPair("KAZAKH", "kk"),
                new TranslationPair("KHMER", "km"),
                new TranslationPair("KOREAN", "ko"),
                new TranslationPair("KURDISH", "ku"),
                new TranslationPair("KYRGYZ", "ky"),
                new TranslationPair("LAO", "lo"),
                new TranslationPair("LATIN", "la"),
                new TranslationPair("LATVIAN", "lv"),
                new TranslationPair("LITHUANIAN", "lt"),
                new TranslationPair("LUXEMBOURGISH", "lb"),
                new TranslationPair("MACEDONIAN", "mk"),
                new TranslationPair("MALAY", "ms"),
                new TranslationPair("MALAGASY", "mg"),
                new TranslationPair("MALAYALAM", "ml"),
                new TranslationPair("MALTESE", "mt"),
                new TranslationPair("MAORI", "mi"),
                new TranslationPair("MARATHI", "mr"),
                new TranslationPair("MONGOLIAN", "mn"),
                new TranslationPair("MYANMAR", "my"),
                new TranslationPair("NEPALI", "ne"),
                new TranslationPair("NORWEGIAN", "no"),
                new TranslationPair("PASHTO", "ps"),
                new TranslationPair("PERSIAN", "fa"),
                new TranslationPair("POLISH", "pl"),
                new TranslationPair("PORTUGUESE", "pt"),
                new TranslationPair("PUNJABI", "pa"),
                new TranslationPair("ROMANIAN", "ro"),
                new TranslationPair("ROMANJI", "romanji"),
                new TranslationPair("RUSSIAN", "ru"),
                new TranslationPair("SAMOAN", "sm"),
                new TranslationPair("SCOTS GAELIC", "gd"),
                new TranslationPair("SERBIAN", "sr"),
                new TranslationPair("SESOTHO", "st"),
                new TranslationPair("SHONA", "sn"),
                new TranslationPair("SINDHI", "sd"),
                new TranslationPair("SINHALA", "si"),
                new TranslationPair("SLOVAK", "sk"),
                new TranslationPair("SLOVENIAN", "sl"),
                new TranslationPair("SOMALI", "so"),
                new TranslationPair("SPANISH", "es"),
                new TranslationPair("SUNDANESE", "su"),
                new TranslationPair("SWAHILI", "sw"),
                new TranslationPair("SWEDISH", "sv"),
                new TranslationPair("TAJIK", "tg"),
                new TranslationPair("TAMIL", "ta"),
                new TranslationPair("TELUGU", "te"),
                new TranslationPair("THAI", "th"),
                new TranslationPair("TURKISH", "tr"),
                new TranslationPair("UKRAINIAN", "uk"),
                new TranslationPair("URDU", "ur"),
                new TranslationPair("UZBEK", "uz"),
                new TranslationPair("VIETNAMESE", "vi"),
                new TranslationPair("WELSH", "cy"),
                new TranslationPair("XHOSA", "xh"),
                new TranslationPair("YIDDISH", "yi"),
                new TranslationPair("YORUBA", "yo"),
                new TranslationPair("ZULU", "zu"),
            };
        }

        public string GetName()
        {
            return "Google Screen-Scraper translate";
        }

        public string GetUrl()
        {
            return _googleUrl;
        }

        public void Translate(string sourceLanguage, string targetLanguage, List<Paragraph> paragraphs, StringBuilder log)
        {
            for (int i = 0; i < 10; i++)
            {
                if (!_loaded)
                {
                    System.Windows.Forms.Application.DoEvents();
                    System.Threading.Thread.Sleep(10);
                }
            }

            _translateResult = null;
            _log = log;
            var input = new StringBuilder();
            _formattings = new Formatting[paragraphs.Count];
            for (var index = 0; index < paragraphs.Count; index++)
            {
                var p = paragraphs[index];
                var f = new Formatting();
                _formattings[index] = f;
                if (input.Length > 0)
                    input.Append(Environment.NewLine + Environment.NewLine);
                var text = f.SetTagsAndReturnTrimmed(TranslationHelper.PreTranslate(p.Text, sourceLanguage), sourceLanguage);
                while (text.Contains(Environment.NewLine + Environment.NewLine))
                    text = text.Replace(Environment.NewLine + Environment.NewLine, Environment.NewLine);
                text = text.Replace(Environment.NewLine, "\n");
                input.Append(text);
            }
            // https://translate.google.com/?hl=en&eotf=1&sl=en&tl=da&q=How%20are%20you
            // or perhaps https://translate.google.com/#view=home&op=translate&sl=da&tl=en&text=Surkål
            //string uri = $"{baseUrl}/?hl=en&eotf=1&sl={sourceLanguage}&tl={targetLanguage}&q={input.ToString()}";
            //log.AppendLine("GET Request: " + uri + Environment.NewLine);
            //_loaded = false;
            //_webView.Source = null;
            //_translateResult = null;
            //_webView.Navigate(new Uri(uri));

            _loaded = false;
            _webView.Navigate(new Uri(_googleUrl + "/#view=home&op=translate&sl=" + sourceLanguage + "&tl=" + targetLanguage + "&text=" + Uri.EscapeDataString(input.ToString())));

            //var encodedText = HttpUtility.JavaScriptStringEncode(input.ToString().Trim());
            //string functionString = $"document.getElementById('source').innerText = '{encodedText}';";
            //_webView.InvokeScript("eval", functionString);
            for (int i = 0; i < 100; i++)
            {
                System.Windows.Forms.Application.DoEvents();
                System.Threading.Thread.Sleep(10);
                if (_loaded)
                    break;
            }
        }

        public List<string> GetTranslationResult(string targetLanguage, List<Paragraph> paragraphs)
        {
            for (int i = 0; i < 100; i++)
            {
                if (!_loaded)
                {
                    System.Threading.Thread.Sleep(10);
                    System.Windows.Forms.Application.DoEvents();
                }
            }

            try
            {
                _translateResult = _webView.InvokeScript("eval", "document.getElementsByClassName('tlid-translation translation')[0].innerText");
                if (_translateResult == _lastTranslateResult)
                {
                    _lastTranslateResult = null;
                    return null;
                }

                if (string.IsNullOrEmpty(_translateResult))
                    return null;

                _lastTranslateResult = _translateResult;
                var list = MakeList(_translateResult, targetLanguage, _formattings);

                if (list.Count > paragraphs.Count)
                {
                    return list.Where(p => !string.IsNullOrEmpty(p)).ToList();
                }

                if (list.Count < paragraphs.Count)
                {
                    var splitList = SplitMergedLines(list, paragraphs);
                    if (splitList.Count == paragraphs.Count)
                        return splitList;
                }

                return list;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        private List<string> MakeList(string res, string targetLanguage, Formatting[] formattings)
        {
            res = Regex.Unescape(res);
            var lines = new List<string>();

            var sb = new StringBuilder();
            foreach (var l in res.SplitToLines())
            {
                if (string.IsNullOrEmpty(l))
                {
                    if (sb.Length > 0)
                        lines.Add(sb.ToString().Trim());
                    sb.Clear();
                }
                else
                {
                    sb.AppendLine(l);
                }
            }
            if (sb.Length > 0)
                lines.Add(sb.ToString().Trim());

            var resultList = new List<string>();
            for (var index = 0; index < lines.Count; index++)
            {
                var line = lines[index].Trim();
                var s = WebUtility.HtmlDecode(line);
                s = s.Replace("<I>", "<i>");
                s = s.Replace("<I >", "<i>");
                s = s.Replace("< I >", "<i>");
                s = s.Replace("< i >", "<i>");
                s = s.Replace("</I>", "</i>");
                s = s.Replace("</I >", "</i>");
                s = s.Replace("</ I>", "</i>");
                s = s.Replace("</ i>", "</i>");
                s = s.Replace("< / i>", "</i>");
                s = string.Join(Environment.NewLine, s.SplitToLines());
                s = TranslationHelper.PostTranslate(s, targetLanguage);
                s = s.Replace(Environment.NewLine + Environment.NewLine, Environment.NewLine);
                s = s.Replace(Environment.NewLine + " ", Environment.NewLine);
                s = s.Replace(Environment.NewLine + " ", Environment.NewLine);
                s = s.Replace(" " + Environment.NewLine, Environment.NewLine);
                s = s.Replace(" " + Environment.NewLine, Environment.NewLine).Trim();
                if (formattings.Length > index)
                    s = formattings[index].ReAddFormatting(s);
                resultList.Add(s.Replace("  ", " "));
            }
            return resultList;
        }

        private static List<string> SplitMergedLines(List<string> input, List<Paragraph> paragraphs)
        {
            var hits = 0;
            var results = new List<string>();
            for (var index = 0; index < input.Count; index++)
            {
                var line = input[index];
                var text = paragraphs[index].Text;
                var badPoints = 0;
                if (text.StartsWith("[") && !line.StartsWith("["))
                    badPoints++;
                if (text.StartsWith("-") && !line.StartsWith("-"))
                    badPoints++;
                if (text.Length > 0 && char.IsUpper(text[0]) && line.Length > 0 && !char.IsUpper(line[0]))
                    badPoints++;
                if (text.EndsWith(".") && !line.EndsWith("."))
                    badPoints++;
                if (text.EndsWith("!") && !line.EndsWith("!"))
                    badPoints++;
                if (text.EndsWith("?") && !line.EndsWith("?"))
                    badPoints++;
                if (text.EndsWith(",") && !line.EndsWith(","))
                    badPoints++;
                if (text.EndsWith(":") && !line.EndsWith(":"))
                    badPoints++;
                var added = false;
                if (badPoints > 0 && hits + input.Count < paragraphs.Count)
                {
                    var percent = line.Length * 100.0 / text.Length;
                    if (percent > 150)
                    {
                        var temp = Utilities.AutoBreakLine(line).SplitToLines();
                        if (temp.Length == 2)
                        {
                            hits++;
                            results.Add(temp[0]);
                            results.Add(temp[1]);
                            added = true;
                        }
                    }
                }
                if (!added)
                {
                    results.Add(line);
                }
            }

            if (results.Count == paragraphs.Count)
                return results;

            return input;
        }
    }
}
