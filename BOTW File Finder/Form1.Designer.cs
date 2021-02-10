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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.searchBar = new System.Windows.Forms.TextBox();
            this.searchBarLLabel = new System.Windows.Forms.Label();
            this.itemView = new System.Windows.Forms.ListBox();
            this.objectNameView = new System.Windows.Forms.ListBox();
            this.fileNameView = new System.Windows.Forms.ListBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
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
            this.searchBar.Size = new System.Drawing.Size(454, 20);
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
            this.itemView.Size = new System.Drawing.Size(150, 180);
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
            this.objectNameView.Size = new System.Drawing.Size(166, 180);
            this.objectNameView.TabIndex = 3;
            this.objectNameView.SelectedIndexChanged += new System.EventHandler(this.objectNameView_SelectedIndexChanged);
            this.objectNameView.SelectedValueChanged += new System.EventHandler(this.objectNameView_SelectedValueChanged);
            // 
            // fileNameView
            // 
            this.fileNameView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fileNameView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileNameView.ForeColor = System.Drawing.SystemColors.Window;
            this.fileNameView.FormattingEnabled = true;
            this.fileNameView.Location = new System.Drawing.Point(0, 0);
            this.fileNameView.Name = "fileNameView";
            this.fileNameView.Size = new System.Drawing.Size(176, 180);
            this.fileNameView.TabIndex = 4;
            this.fileNameView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.fileNameView_MouseDoubleClick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BackColor = System.Drawing.Color.Black;
            this.splitContainer1.Location = new System.Drawing.Point(7, 32);
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
            this.splitContainer1.Size = new System.Drawing.Size(500, 180);
            this.splitContainer1.SplitterDistance = 150;
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
            this.splitContainer2.Size = new System.Drawing.Size(346, 180);
            this.splitContainer2.SplitterDistance = 166;
            this.splitContainer2.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(515, 216);
            this.Controls.Add(this.searchBarLLabel);
            this.Controls.Add(this.searchBar);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "BoTW File Finder";
            this.Load += new System.EventHandler(this.Form1_Load);
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
    }
}

