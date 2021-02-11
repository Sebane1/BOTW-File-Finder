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
            this.searchBar = new System.Windows.Forms.TextBox();
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
            this.fileMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchBar
            // 
            this.searchBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchBar.ForeColor = System.Drawing.SystemColors.Window;
            this.searchBar.Location = new System.Drawing.Point(53, 6);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(279, 20);
            this.searchBar.TabIndex = 0;
            this.searchBar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            this.itemView.Size = new System.Drawing.Size(208, 200);
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
            this.objectNameView.Size = new System.Drawing.Size(209, 200);
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
            this.fileNameView.Size = new System.Drawing.Size(190, 200);
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
            this.fileMenu.Size = new System.Drawing.Size(181, 48);
            this.fileMenu.Opening += new System.ComponentModel.CancelEventHandler(this.fileMenu_Opening);
            // 
            // openWithToolStripMenuItem
            // 
            this.openWithToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addOptionToolStripMenuItem});
            this.openWithToolStripMenuItem.Name = "openWithToolStripMenuItem";
            this.openWithToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BackColor = System.Drawing.Color.Black;
            this.splitContainer1.Location = new System.Drawing.Point(7, 60);
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
            this.splitContainer1.Size = new System.Drawing.Size(615, 200);
            this.splitContainer1.SplitterDistance = 208;
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
            this.splitContainer2.Size = new System.Drawing.Size(403, 200);
            this.splitContainer2.SplitterDistance = 209;
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
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(630, 265);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fullPathText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.copyBox);
            this.Controls.Add(this.searchBarLLabel);
            this.Controls.Add(this.searchBar);
            this.Controls.Add(this.splitContainer1);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchBar;
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
    }
}

