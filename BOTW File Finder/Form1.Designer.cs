﻿using BrightIdeasSoftware;

namespace BOTW_File_Finder {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.searchBarLLabel = new System.Windows.Forms.Label();
            this.itemView = new System.Windows.Forms.ListBox();
            this.objectNameView = new System.Windows.Forms.ListBox();
            this.fileNameView = new System.Windows.Forms.ListBox();
            this.fileMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openWithToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addOptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.copyBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fullPathText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.searchBar = new System.Windows.Forms.ComboBox();
            this.dropdownTimer = new System.Windows.Forms.Timer(this.components);
            this.tabControl = new System.Windows.Forms.TabControl();
            this.basicPage = new System.Windows.Forms.TabPage();
            this.advancedPage = new System.Windows.Forms.TabPage();
            this.advancedView = new BrightIdeasSoftware.FastObjectListView();
            this.nameColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.advancedListPopulationTimer = new System.Windows.Forms.Timer(this.components);
            this.fileMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.basicPage.SuspendLayout();
            this.advancedPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.advancedView)).BeginInit();
            this.SuspendLayout();
            // 
            // searchBarLLabel
            // 
            this.searchBarLLabel.AutoSize = true;
            this.searchBarLLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.searchBarLLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.searchBarLLabel.Location = new System.Drawing.Point(6, 9);
            this.searchBarLLabel.Name = "searchBarLLabel";
            this.searchBarLLabel.Size = new System.Drawing.Size(41, 13);
            this.searchBarLLabel.TabIndex = 1;
            this.searchBarLLabel.Text = "Search";
            this.searchBarLLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // itemView
            // 
            this.itemView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.itemView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemView.ForeColor = System.Drawing.SystemColors.Window;
            this.itemView.FormattingEnabled = true;
            this.itemView.Location = new System.Drawing.Point(0, 0);
            this.itemView.Name = "itemView";
            this.itemView.Size = new System.Drawing.Size(209, 178);
            this.itemView.TabIndex = 2;
            this.itemView.SelectedValueChanged += new System.EventHandler(this.itemView_SelectedValueChanged);
            // 
            // objectNameView
            // 
            this.objectNameView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.objectNameView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.objectNameView.ForeColor = System.Drawing.SystemColors.Window;
            this.objectNameView.FormattingEnabled = true;
            this.objectNameView.Location = new System.Drawing.Point(0, 0);
            this.objectNameView.Name = "objectNameView";
            this.objectNameView.Size = new System.Drawing.Size(210, 178);
            this.objectNameView.TabIndex = 3;
            this.objectNameView.SelectedIndexChanged += new System.EventHandler(this.objectNameView_SelectedIndexChanged);
            this.objectNameView.SelectedValueChanged += new System.EventHandler(this.objectNameView_SelectedValueChanged);
            // 
            // fileNameView
            // 
            this.fileNameView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fileNameView.ContextMenuStrip = this.fileMenu;
            this.fileNameView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileNameView.ForeColor = System.Drawing.SystemColors.Window;
            this.fileNameView.FormattingEnabled = true;
            this.fileNameView.Location = new System.Drawing.Point(0, 0);
            this.fileNameView.Name = "fileNameView";
            this.fileNameView.Size = new System.Drawing.Size(192, 178);
            this.fileNameView.TabIndex = 4;
            this.fileNameView.SelectedValueChanged += new System.EventHandler(this.fileNameView_SelectedValueChanged);
            this.fileNameView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.fileNameView_MouseDoubleClick);
            this.fileNameView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.fileNameView_MouseDown);
            this.fileNameView.MouseMove += new System.Windows.Forms.MouseEventHandler(this.fileNameView_MouseMove);
            this.fileNameView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.fileNameView_MouseUp);
            // 
            // fileMenu
            // 
            this.fileMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openWithToolStripMenuItem});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(130, 26);
            this.fileMenu.Opening += new System.ComponentModel.CancelEventHandler(this.fileMenu_Opening);
            // 
            // openWithToolStripMenuItem
            // 
            this.openWithToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addOptionToolStripMenuItem});
            this.openWithToolStripMenuItem.Name = "openWithToolStripMenuItem";
            this.openWithToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.openWithToolStripMenuItem.Text = "Open with&";
            this.openWithToolStripMenuItem.DropDownOpened += new System.EventHandler(this.openWithToolStripMenuItem_DropDownOpened);
            // 
            // addOptionToolStripMenuItem
            // 
            this.addOptionToolStripMenuItem.Name = "addOptionToolStripMenuItem";
            this.addOptionToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.addOptionToolStripMenuItem.Text = "Add Option";
            this.addOptionToolStripMenuItem.Click += new System.EventHandler(this.addOptionToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Black;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.itemView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Black;
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(619, 178);
            this.splitContainer1.SplitterDistance = 209;
            this.splitContainer1.TabIndex = 5;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.objectNameView);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.fileNameView);
            this.splitContainer2.Size = new System.Drawing.Size(406, 178);
            this.splitContainer2.SplitterDistance = 210;
            this.splitContainer2.TabIndex = 5;
            // 
            // copyBox
            // 
            this.copyBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.copyBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.copyBox.ForeColor = System.Drawing.Color.Gold;
            this.copyBox.Location = new System.Drawing.Point(396, 6);
            this.copyBox.Name = "copyBox";
            this.copyBox.Size = new System.Drawing.Size(226, 20);
            this.copyBox.TabIndex = 6;
            this.copyBox.TextChanged += new System.EventHandler(this.copyBox_TextChanged);
            this.copyBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.copyBox_KeyDown);
            this.copyBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.copyBox_KeyPress);
            this.copyBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.copyBox_KeyUp);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(339, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Selection";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // fullPathText
            // 
            this.fullPathText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fullPathText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fullPathText.ForeColor = System.Drawing.Color.Gold;
            this.fullPathText.Location = new System.Drawing.Point(53, 32);
            this.fullPathText.Name = "fullPathText";
            this.fullPathText.Size = new System.Drawing.Size(569, 20);
            this.fullPathText.TabIndex = 8;
            this.fullPathText.TextChanged += new System.EventHandler(this.fullPathText_TextChanged);
            this.fullPathText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.fullPathText_MouseDown);
            this.fullPathText.MouseMove += new System.Windows.Forms.MouseEventHandler(this.fullPathText_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(18, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Path";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // searchBar
            // 
            this.searchBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchBar.ForeColor = System.Drawing.SystemColors.Window;
            this.searchBar.FormattingEnabled = true;
            this.searchBar.Location = new System.Drawing.Point(54, 6);
            this.searchBar.MaxDropDownItems = 20;
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(279, 21);
            this.searchBar.TabIndex = 10;
            this.searchBar.SelectedIndexChanged += new System.EventHandler(this.searchBar_SelectedIndexChanged);
            this.searchBar.SelectionChangeCommitted += new System.EventHandler(this.searchBar_SelectionChangeCommitted);
            this.searchBar.DropDownClosed += new System.EventHandler(this.searchBar_DropDownClosed);
            this.searchBar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.searchBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchBar_KeyDown);
            this.searchBar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.searchBar_MouseClick);
            // 
            // dropdownTimer
            // 
            this.dropdownTimer.Interval = 1000;
            this.dropdownTimer.Tick += new System.EventHandler(this.dropdownTimer_Tick);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.basicPage);
            this.tabControl.Controls.Add(this.advancedPage);
            this.tabControl.Location = new System.Drawing.Point(0, 58);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(633, 210);
            this.tabControl.TabIndex = 11;
            this.tabControl.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl_DrawItem);
            this.tabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl_Selected);
            // 
            // basicPage
            // 
            this.basicPage.BackColor = System.Drawing.Color.Black;
            this.basicPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("basicPage.BackgroundImage")));
            this.basicPage.Controls.Add(this.splitContainer1);
            this.basicPage.Location = new System.Drawing.Point(4, 22);
            this.basicPage.Name = "basicPage";
            this.basicPage.Padding = new System.Windows.Forms.Padding(3);
            this.basicPage.Size = new System.Drawing.Size(625, 184);
            this.basicPage.TabIndex = 0;
            this.basicPage.Text = "Basic";
            // 
            // advancedPage
            // 
            this.advancedPage.BackColor = System.Drawing.Color.Black;
            this.advancedPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("advancedPage.BackgroundImage")));
            this.advancedPage.Controls.Add(this.advancedView);
            this.advancedPage.Location = new System.Drawing.Point(4, 22);
            this.advancedPage.Name = "advancedPage";
            this.advancedPage.Padding = new System.Windows.Forms.Padding(3);
            this.advancedPage.Size = new System.Drawing.Size(625, 184);
            this.advancedPage.TabIndex = 1;
            this.advancedPage.Text = "Advanced";
            // 
            // advancedView
            // 
            this.advancedView.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.advancedView.AllColumns.Add(this.nameColumn);
            this.advancedView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.advancedView.CellEditUseWholeCell = false;
            this.advancedView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumn});
            this.advancedView.ContextMenuStrip = this.fileMenu;
            this.advancedView.Cursor = System.Windows.Forms.Cursors.Default;
            this.advancedView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.advancedView.ForeColor = System.Drawing.SystemColors.Window;
            this.advancedView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.advancedView.HideSelection = false;
            this.advancedView.Location = new System.Drawing.Point(3, 3);
            this.advancedView.MultiSelect = false;
            this.advancedView.Name = "advancedView";
            this.advancedView.ShowGroups = false;
            this.advancedView.Size = new System.Drawing.Size(619, 178);
            this.advancedView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.advancedView.TabIndex = 0;
            this.advancedView.UseCompatibleStateImageBehavior = false;
            this.advancedView.View = System.Windows.Forms.View.List;
            this.advancedView.VirtualMode = true;
            this.advancedView.SelectionChanged += new System.EventHandler(this.advancedView_SelectionChanged);
            this.advancedView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.advancedView_ItemSelectionChanged);
            this.advancedView.SelectedIndexChanged += new System.EventHandler(this.advancedView_SelectedIndexChanged);
            this.advancedView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.fullPathText_MouseDown);
            this.advancedView.MouseMove += new System.Windows.Forms.MouseEventHandler(this.fullPathText_MouseMove);
            // 
            // nameColumn
            // 
            this.nameColumn.AspectName = "Name";
            this.nameColumn.IsEditable = false;
            this.nameColumn.Text = "Name";
            this.nameColumn.Width = 300;
            this.nameColumn.WordWrap = true;
            // 
            // advancedListPopulationTimer
            // 
            this.advancedListPopulationTimer.Interval = 200;
            this.advancedListPopulationTimer.Tick += new System.EventHandler(this.advancedListPopulationTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(630, 265);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.searchBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fullPathText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.copyBox);
            this.Controls.Add(this.searchBarLLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "BoTW File Finder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.fileMenu.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.basicPage.ResumeLayout(false);
            this.advancedPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.advancedView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label searchBarLLabel;
        private System.Windows.Forms.ListBox itemView;
        private System.Windows.Forms.ListBox objectNameView;
        private System.Windows.Forms.ListBox fileNameView;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox copyBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fullPathText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip fileMenu;
        private System.Windows.Forms.ToolStripMenuItem openWithToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addOptionToolStripMenuItem;
        private System.Windows.Forms.ComboBox searchBar;
        private System.Windows.Forms.Timer dropdownTimer;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage basicPage;
        private System.Windows.Forms.TabPage advancedPage;
        private FastObjectListView advancedView;
        private OLVColumn nameColumn;
        private System.Windows.Forms.Timer advancedListPopulationTimer;
    }
}

