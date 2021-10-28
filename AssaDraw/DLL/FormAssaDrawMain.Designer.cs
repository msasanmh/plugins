﻿
namespace AssaDraw
{
    partial class FormAssaDrawMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAssaDrawMain));
            this.pictureBoxCanvas = new System.Windows.Forms.PictureBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.contextMenuStripTreeView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteShapeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setLayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.useShapeForEraseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.useShapeForDrawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletePointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duplicatePointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeLayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteLayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideLayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxSettings = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownX = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownHeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownWidth = new System.Windows.Forms.NumericUpDown();
            this.labelResolution = new System.Windows.Forms.Label();
            this.labelPosition = new System.Windows.Forms.Label();
            this.toolStripAssaDraw = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCopyToClipboard = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonLine = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonBeizer = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCircle = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCloseShape = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonClearCurrent = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonMirrorHor = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonMirrorVert = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonSettings = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPreview = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStripCanvasBackground = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.chooseBackgroundImagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearBackgroundImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.timerTreeViewUpdate = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCanvas)).BeginInit();
            this.contextMenuStripTreeView.SuspendLayout();
            this.groupBoxSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).BeginInit();
            this.toolStripAssaDraw.SuspendLayout();
            this.contextMenuStripCanvasBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxCanvas
            // 
            this.pictureBoxCanvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxCanvas.Location = new System.Drawing.Point(245, 42);
            this.pictureBoxCanvas.Name = "pictureBoxCanvas";
            this.pictureBoxCanvas.Size = new System.Drawing.Size(803, 555);
            this.pictureBoxCanvas.TabIndex = 0;
            this.pictureBoxCanvas.TabStop = false;
            this.pictureBoxCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxCanvas_Paint);
            this.pictureBoxCanvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxCanvas_MouseClick);
            this.pictureBoxCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxCanvas_MouseDown);
            this.pictureBoxCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxCanvas_MouseMove);
            this.pictureBoxCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxCanvas_MouseUp);
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeView1.ContextMenuStrip = this.contextMenuStripTreeView;
            this.treeView1.Location = new System.Drawing.Point(13, 139);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(226, 487);
            this.treeView1.TabIndex = 2;
            this.treeView1.AfterCollapse += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterCollapse);
            this.treeView1.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterExpand);
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // contextMenuStripTreeView
            // 
            this.contextMenuStripTreeView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteShapeToolStripMenuItem,
            this.setLayerToolStripMenuItem,
            this.useShapeForEraseToolStripMenuItem,
            this.useShapeForDrawToolStripMenuItem,
            this.deletePointToolStripMenuItem,
            this.duplicatePointToolStripMenuItem,
            this.setColorToolStripMenuItem,
            this.changeLayerToolStripMenuItem,
            this.deleteLayerToolStripMenuItem,
            this.hideLayerToolStripMenuItem,
            this.showLayerToolStripMenuItem});
            this.contextMenuStripTreeView.Name = "contextMenuStripTreeView";
            this.contextMenuStripTreeView.Size = new System.Drawing.Size(176, 246);
            this.contextMenuStripTreeView.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripTreeView_Opening);
            // 
            // deleteShapeToolStripMenuItem
            // 
            this.deleteShapeToolStripMenuItem.Name = "deleteShapeToolStripMenuItem";
            this.deleteShapeToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.deleteShapeToolStripMenuItem.Text = "Delete shape";
            this.deleteShapeToolStripMenuItem.Click += new System.EventHandler(this.deleteShapeToolStripMenuItem_Click);
            // 
            // setLayerToolStripMenuItem
            // 
            this.setLayerToolStripMenuItem.Name = "setLayerToolStripMenuItem";
            this.setLayerToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.setLayerToolStripMenuItem.Text = "Set layer...";
            this.setLayerToolStripMenuItem.Click += new System.EventHandler(this.setLayerToolStripMenuItem_Click);
            // 
            // useShapeForEraseToolStripMenuItem
            // 
            this.useShapeForEraseToolStripMenuItem.Name = "useShapeForEraseToolStripMenuItem";
            this.useShapeForEraseToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.useShapeForEraseToolStripMenuItem.Text = "Use shape for erase";
            this.useShapeForEraseToolStripMenuItem.Click += new System.EventHandler(this.useShapeForEraseToolStripMenuItem_Click);
            // 
            // useShapeForDrawToolStripMenuItem
            // 
            this.useShapeForDrawToolStripMenuItem.Name = "useShapeForDrawToolStripMenuItem";
            this.useShapeForDrawToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.useShapeForDrawToolStripMenuItem.Text = "Use shape for draw";
            this.useShapeForDrawToolStripMenuItem.Click += new System.EventHandler(this.useShapeForDrawToolStripMenuItem_Click);
            // 
            // deletePointToolStripMenuItem
            // 
            this.deletePointToolStripMenuItem.Name = "deletePointToolStripMenuItem";
            this.deletePointToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.deletePointToolStripMenuItem.Text = "Delete point";
            this.deletePointToolStripMenuItem.Click += new System.EventHandler(this.deletePointToolStripMenuItem_Click);
            // 
            // duplicatePointToolStripMenuItem
            // 
            this.duplicatePointToolStripMenuItem.Name = "duplicatePointToolStripMenuItem";
            this.duplicatePointToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.duplicatePointToolStripMenuItem.Text = "Duplicate point";
            this.duplicatePointToolStripMenuItem.Click += new System.EventHandler(this.duplicatePointToolStripMenuItem_Click);
            // 
            // setColorToolStripMenuItem
            // 
            this.setColorToolStripMenuItem.Name = "setColorToolStripMenuItem";
            this.setColorToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.setColorToolStripMenuItem.Text = "Set color...";
            this.setColorToolStripMenuItem.Click += new System.EventHandler(this.setColorToolStripMenuItem_Click);
            // 
            // changeLayerToolStripMenuItem
            // 
            this.changeLayerToolStripMenuItem.Name = "changeLayerToolStripMenuItem";
            this.changeLayerToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.changeLayerToolStripMenuItem.Text = "Set layer...";
            this.changeLayerToolStripMenuItem.Click += new System.EventHandler(this.changeLayerToolStripMenuItem_Click);
            // 
            // deleteLayerToolStripMenuItem
            // 
            this.deleteLayerToolStripMenuItem.Name = "deleteLayerToolStripMenuItem";
            this.deleteLayerToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.deleteLayerToolStripMenuItem.Text = "Delete layer";
            this.deleteLayerToolStripMenuItem.Click += new System.EventHandler(this.deleteLayerToolStripMenuItem_Click);
            // 
            // hideLayerToolStripMenuItem
            // 
            this.hideLayerToolStripMenuItem.Name = "hideLayerToolStripMenuItem";
            this.hideLayerToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.hideLayerToolStripMenuItem.Text = "Hide layer";
            this.hideLayerToolStripMenuItem.Click += new System.EventHandler(this.hideLayerToolStripMenuItem_Click);
            // 
            // showLayerToolStripMenuItem
            // 
            this.showLayerToolStripMenuItem.Name = "showLayerToolStripMenuItem";
            this.showLayerToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.showLayerToolStripMenuItem.Text = "Show layer";
            this.showLayerToolStripMenuItem.Click += new System.EventHandler(this.showLayerToolStripMenuItem_Click);
            // 
            // groupBoxSettings
            // 
            this.groupBoxSettings.Controls.Add(this.label1);
            this.groupBoxSettings.Controls.Add(this.numericUpDownY);
            this.groupBoxSettings.Controls.Add(this.numericUpDownX);
            this.groupBoxSettings.Controls.Add(this.numericUpDownHeight);
            this.groupBoxSettings.Controls.Add(this.numericUpDownWidth);
            this.groupBoxSettings.Controls.Add(this.labelResolution);
            this.groupBoxSettings.Location = new System.Drawing.Point(13, 42);
            this.groupBoxSettings.Name = "groupBoxSettings";
            this.groupBoxSettings.Size = new System.Drawing.Size(226, 91);
            this.groupBoxSettings.TabIndex = 5;
            this.groupBoxSettings.TabStop = false;
            this.groupBoxSettings.Text = "Settings";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Active point";
            // 
            // numericUpDownY
            // 
            this.numericUpDownY.Location = new System.Drawing.Point(149, 58);
            this.numericUpDownY.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownY.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numericUpDownY.Name = "numericUpDownY";
            this.numericUpDownY.Size = new System.Drawing.Size(60, 20);
            this.numericUpDownY.TabIndex = 7;
            this.numericUpDownY.Value = new decimal(new int[] {
            480,
            0,
            0,
            0});
            this.numericUpDownY.ValueChanged += new System.EventHandler(this.numericUpDownY_ValueChanged);
            // 
            // numericUpDownX
            // 
            this.numericUpDownX.Location = new System.Drawing.Point(76, 58);
            this.numericUpDownX.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownX.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numericUpDownX.Name = "numericUpDownX";
            this.numericUpDownX.Size = new System.Drawing.Size(60, 20);
            this.numericUpDownX.TabIndex = 6;
            this.numericUpDownX.Value = new decimal(new int[] {
            720,
            0,
            0,
            0});
            this.numericUpDownX.ValueChanged += new System.EventHandler(this.numericUpDownX_ValueChanged);
            // 
            // numericUpDownHeight
            // 
            this.numericUpDownHeight.Location = new System.Drawing.Point(149, 29);
            this.numericUpDownHeight.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownHeight.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownHeight.Name = "numericUpDownHeight";
            this.numericUpDownHeight.Size = new System.Drawing.Size(60, 20);
            this.numericUpDownHeight.TabIndex = 2;
            this.numericUpDownHeight.Value = new decimal(new int[] {
            480,
            0,
            0,
            0});
            this.numericUpDownHeight.ValueChanged += new System.EventHandler(this.numericUpDownHeight_ValueChanged);
            // 
            // numericUpDownWidth
            // 
            this.numericUpDownWidth.Location = new System.Drawing.Point(76, 29);
            this.numericUpDownWidth.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownWidth.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownWidth.Name = "numericUpDownWidth";
            this.numericUpDownWidth.Size = new System.Drawing.Size(60, 20);
            this.numericUpDownWidth.TabIndex = 1;
            this.numericUpDownWidth.Value = new decimal(new int[] {
            720,
            0,
            0,
            0});
            this.numericUpDownWidth.ValueChanged += new System.EventHandler(this.numericUpDownWidth_ValueChanged);
            // 
            // labelResolution
            // 
            this.labelResolution.AutoSize = true;
            this.labelResolution.Location = new System.Drawing.Point(7, 29);
            this.labelResolution.Name = "labelResolution";
            this.labelResolution.Size = new System.Drawing.Size(57, 13);
            this.labelResolution.TabIndex = 0;
            this.labelResolution.Text = "Resolution";
            // 
            // labelPosition
            // 
            this.labelPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelPosition.AutoSize = true;
            this.labelPosition.Location = new System.Drawing.Point(242, 603);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(63, 13);
            this.labelPosition.TabIndex = 3;
            this.labelPosition.Text = "Position: x,y";
            // 
            // toolStripAssaDraw
            // 
            this.toolStripAssaDraw.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStripAssaDraw.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonNew,
            this.toolStripButtonOpen,
            this.toolStripButtonSave,
            this.toolStripButtonCopyToClipboard,
            this.toolStripSeparator1,
            this.toolStripButtonLine,
            this.toolStripButtonBeizer,
            this.toolStripButtonCircle,
            this.toolStripButtonCloseShape,
            this.toolStripSeparator2,
            this.toolStripButtonClearCurrent,
            this.toolStripButtonMirrorHor,
            this.toolStripButtonMirrorVert,
            this.toolStripSeparator3,
            this.toolStripButtonSettings,
            this.toolStripButton1,
            this.toolStripButtonPreview});
            this.toolStripAssaDraw.Location = new System.Drawing.Point(0, 0);
            this.toolStripAssaDraw.Name = "toolStripAssaDraw";
            this.toolStripAssaDraw.Size = new System.Drawing.Size(1060, 39);
            this.toolStripAssaDraw.TabIndex = 9;
            this.toolStripAssaDraw.Text = "toolStrip1";
            // 
            // toolStripButtonNew
            // 
            this.toolStripButtonNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonNew.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonNew.Image")));
            this.toolStripButtonNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNew.Name = "toolStripButtonNew";
            this.toolStripButtonNew.Size = new System.Drawing.Size(36, 36);
            this.toolStripButtonNew.Text = "New";
            this.toolStripButtonNew.Click += new System.EventHandler(this.toolStripButtonNew_Click);
            // 
            // toolStripButtonOpen
            // 
            this.toolStripButtonOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonOpen.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonOpen.Image")));
            this.toolStripButtonOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOpen.Name = "toolStripButtonOpen";
            this.toolStripButtonOpen.Size = new System.Drawing.Size(36, 36);
            this.toolStripButtonOpen.Text = "Open file...";
            this.toolStripButtonOpen.Click += new System.EventHandler(this.toolStripButtonOpen_Click);
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSave.Image")));
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(36, 36);
            this.toolStripButtonSave.Text = "Save file";
            this.toolStripButtonSave.Click += new System.EventHandler(this.toolStripButtonSave_Click);
            // 
            // toolStripButtonCopyToClipboard
            // 
            this.toolStripButtonCopyToClipboard.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCopyToClipboard.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCopyToClipboard.Image")));
            this.toolStripButtonCopyToClipboard.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCopyToClipboard.Name = "toolStripButtonCopyToClipboard";
            this.toolStripButtonCopyToClipboard.Size = new System.Drawing.Size(36, 36);
            this.toolStripButtonCopyToClipboard.Text = "Copy to clipboard";
            this.toolStripButtonCopyToClipboard.Click += new System.EventHandler(this.toolStripButtonCopyToClipboard_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripButtonLine
            // 
            this.toolStripButtonLine.Checked = true;
            this.toolStripButtonLine.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripButtonLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonLine.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonLine.Image")));
            this.toolStripButtonLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLine.Name = "toolStripButtonLine";
            this.toolStripButtonLine.Size = new System.Drawing.Size(36, 36);
            this.toolStripButtonLine.Text = "Draw line";
            this.toolStripButtonLine.Click += new System.EventHandler(this.toolStripButtonLine_Click);
            // 
            // toolStripButtonBeizer
            // 
            this.toolStripButtonBeizer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonBeizer.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonBeizer.Image")));
            this.toolStripButtonBeizer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBeizer.Name = "toolStripButtonBeizer";
            this.toolStripButtonBeizer.Size = new System.Drawing.Size(36, 36);
            this.toolStripButtonBeizer.Text = "Draw curve";
            this.toolStripButtonBeizer.Click += new System.EventHandler(this.toolStripButtonBeizer_Click);
            // 
            // toolStripButtonCircle
            // 
            this.toolStripButtonCircle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCircle.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCircle.Image")));
            this.toolStripButtonCircle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCircle.Name = "toolStripButtonCircle";
            this.toolStripButtonCircle.Size = new System.Drawing.Size(36, 36);
            this.toolStripButtonCircle.Text = "Draw circle";
            this.toolStripButtonCircle.Click += new System.EventHandler(this.toolStripButtonCircle_Click);
            // 
            // toolStripButtonCloseShape
            // 
            this.toolStripButtonCloseShape.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCloseShape.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCloseShape.Image")));
            this.toolStripButtonCloseShape.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCloseShape.Name = "toolStripButtonCloseShape";
            this.toolStripButtonCloseShape.Size = new System.Drawing.Size(36, 36);
            this.toolStripButtonCloseShape.Text = "Close shape";
            this.toolStripButtonCloseShape.Click += new System.EventHandler(this.toolStripButtonCloseShape_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripButtonClearCurrent
            // 
            this.toolStripButtonClearCurrent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonClearCurrent.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonClearCurrent.Image")));
            this.toolStripButtonClearCurrent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonClearCurrent.Name = "toolStripButtonClearCurrent";
            this.toolStripButtonClearCurrent.Size = new System.Drawing.Size(36, 36);
            this.toolStripButtonClearCurrent.Text = "Clear shape";
            this.toolStripButtonClearCurrent.Click += new System.EventHandler(this.toolStripButtonClearCurrent_Click);
            // 
            // toolStripButtonMirrorHor
            // 
            this.toolStripButtonMirrorHor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonMirrorHor.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonMirrorHor.Image")));
            this.toolStripButtonMirrorHor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonMirrorHor.Name = "toolStripButtonMirrorHor";
            this.toolStripButtonMirrorHor.Size = new System.Drawing.Size(36, 36);
            this.toolStripButtonMirrorHor.Text = "Mirror vertically";
            this.toolStripButtonMirrorHor.Click += new System.EventHandler(this.toolStripButtonMirrorHor_Click);
            // 
            // toolStripButtonMirrorVert
            // 
            this.toolStripButtonMirrorVert.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonMirrorVert.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonMirrorVert.Image")));
            this.toolStripButtonMirrorVert.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonMirrorVert.Name = "toolStripButtonMirrorVert";
            this.toolStripButtonMirrorVert.Size = new System.Drawing.Size(36, 36);
            this.toolStripButtonMirrorVert.Text = "Mirror horizontally";
            this.toolStripButtonMirrorVert.Click += new System.EventHandler(this.toolStripButtonMirrorVert_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripButtonSettings
            // 
            this.toolStripButtonSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSettings.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSettings.Image")));
            this.toolStripButtonSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSettings.Name = "toolStripButtonSettings";
            this.toolStripButtonSettings.Size = new System.Drawing.Size(36, 36);
            this.toolStripButtonSettings.Text = "Settings";
            this.toolStripButtonSettings.Click += new System.EventHandler(this.toolStripButtonSettings_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton1.Text = "Help";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButtonPreview
            // 
            this.toolStripButtonPreview.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPreview.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPreview.Image")));
            this.toolStripButtonPreview.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPreview.Name = "toolStripButtonPreview";
            this.toolStripButtonPreview.Size = new System.Drawing.Size(36, 36);
            this.toolStripButtonPreview.Text = "Preview";
            this.toolStripButtonPreview.Click += new System.EventHandler(this.toolStripButtonPreview_Click);
            // 
            // contextMenuStripCanvasBackground
            // 
            this.contextMenuStripCanvasBackground.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chooseBackgroundImagesToolStripMenuItem,
            this.clearBackgroundImageToolStripMenuItem});
            this.contextMenuStripCanvasBackground.Name = "contextMenuStripCanvasBackground";
            this.contextMenuStripCanvasBackground.Size = new System.Drawing.Size(232, 48);
            this.contextMenuStripCanvasBackground.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripCanvasBackground_Opening);
            // 
            // chooseBackgroundImagesToolStripMenuItem
            // 
            this.chooseBackgroundImagesToolStripMenuItem.Name = "chooseBackgroundImagesToolStripMenuItem";
            this.chooseBackgroundImagesToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.chooseBackgroundImagesToolStripMenuItem.Text = "Choose background images...";
            this.chooseBackgroundImagesToolStripMenuItem.Click += new System.EventHandler(this.chooseBackgroundImagesToolStripMenuItem_Click);
            // 
            // clearBackgroundImageToolStripMenuItem
            // 
            this.clearBackgroundImageToolStripMenuItem.Name = "clearBackgroundImageToolStripMenuItem";
            this.clearBackgroundImageToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.clearBackgroundImageToolStripMenuItem.Text = "Clear background image";
            this.clearBackgroundImageToolStripMenuItem.Click += new System.EventHandler(this.clearBackgroundImageToolStripMenuItem_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(973, 603);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 12;
            this.buttonCancel.TabStop = false;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOk.Location = new System.Drawing.Point(892, 603);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 11;
            this.buttonOk.TabStop = false;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // timerTreeViewUpdate
            // 
            this.timerTreeViewUpdate.Interval = 1000;
            this.timerTreeViewUpdate.Tick += new System.EventHandler(this.timerTreeViewUpdate_Tick);
            // 
            // FormAssaDrawMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 638);
            this.Controls.Add(this.labelPosition);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.toolStripAssaDraw);
            this.Controls.Add(this.groupBoxSettings);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.pictureBoxCanvas);
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "FormAssaDrawMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ASSA Draw";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAssaDrawMain_FormClosing);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.FormAssaDrawMain_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.FormAssaDrawMain_DragEnter);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormAssaDrawMain_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCanvas)).EndInit();
            this.contextMenuStripTreeView.ResumeLayout(false);
            this.groupBoxSettings.ResumeLayout(false);
            this.groupBoxSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).EndInit();
            this.toolStripAssaDraw.ResumeLayout(false);
            this.toolStripAssaDraw.PerformLayout();
            this.contextMenuStripCanvasBackground.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxCanvas;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.GroupBox groupBoxSettings;
        private System.Windows.Forms.NumericUpDown numericUpDownHeight;
        private System.Windows.Forms.NumericUpDown numericUpDownWidth;
        private System.Windows.Forms.Label labelResolution;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.NumericUpDown numericUpDownY;
        private System.Windows.Forms.NumericUpDown numericUpDownX;
        private System.Windows.Forms.ToolStrip toolStripAssaDraw;
        private System.Windows.Forms.ToolStripButton toolStripButtonOpen;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonLine;
        private System.Windows.Forms.ToolStripButton toolStripButtonBeizer;
        private System.Windows.Forms.ToolStripButton toolStripButtonCloseShape;
        private System.Windows.Forms.ToolStripButton toolStripButtonClearCurrent;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTreeView;
        private System.Windows.Forms.ToolStripMenuItem deleteShapeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletePointToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem duplicatePointToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonMirrorHor;
        private System.Windows.Forms.ToolStripButton toolStripButtonMirrorVert;
        private System.Windows.Forms.ToolStripButton toolStripButtonNew;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripCanvasBackground;
        private System.Windows.Forms.ToolStripMenuItem chooseBackgroundImagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearBackgroundImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButtonSettings;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.ToolStripButton toolStripButtonCopyToClipboard;
        private System.Windows.Forms.ToolStripButton toolStripButtonPreview;
        private System.Windows.Forms.ToolStripMenuItem setLayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeLayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteLayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem useShapeForEraseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem useShapeForDrawToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideLayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonCircle;
        private System.Windows.Forms.Timer timerTreeViewUpdate;
    }
}

