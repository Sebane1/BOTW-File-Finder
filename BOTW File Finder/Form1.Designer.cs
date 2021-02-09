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
            this.searchBar = new System.Windows.Forms.TextBox();
            this.searchBarLLabel = new System.Windows.Forms.Label();
            this.itemView = new System.Windows.Forms.ListBox();
            this.objectNameView = new System.Windows.Forms.ListBox();
            this.fileNameView = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // searchBar
            // 
            this.searchBar.Location = new System.Drawing.Point(53, 6);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(453, 20);
            this.searchBar.TabIndex = 0;
            this.searchBar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // searchBarLLabel
            // 
            this.searchBarLLabel.AutoSize = true;
            this.searchBarLLabel.Location = new System.Drawing.Point(12, 9);
            this.searchBarLLabel.Name = "searchBarLLabel";
            this.searchBarLLabel.Size = new System.Drawing.Size(41, 13);
            this.searchBarLLabel.TabIndex = 1;
            this.searchBarLLabel.Text = "Search";
            this.searchBarLLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // itemView
            // 
            this.itemView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.itemView.FormattingEnabled = true;
            this.itemView.Location = new System.Drawing.Point(15, 32);
            this.itemView.Name = "itemView";
            this.itemView.Size = new System.Drawing.Size(157, 173);
            this.itemView.TabIndex = 2;
            this.itemView.SelectedValueChanged += new System.EventHandler(this.itemView_SelectedValueChanged);
            // 
            // objectNameView
            // 
            this.objectNameView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.objectNameView.FormattingEnabled = true;
            this.objectNameView.Location = new System.Drawing.Point(178, 32);
            this.objectNameView.Name = "objectNameView";
            this.objectNameView.Size = new System.Drawing.Size(161, 173);
            this.objectNameView.TabIndex = 3;
            this.objectNameView.SelectedValueChanged += new System.EventHandler(this.objectNameView_SelectedValueChanged);
            // 
            // fileNameView
            // 
            this.fileNameView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.fileNameView.FormattingEnabled = true;
            this.fileNameView.Location = new System.Drawing.Point(345, 32);
            this.fileNameView.Name = "fileNameView";
            this.fileNameView.Size = new System.Drawing.Size(161, 173);
            this.fileNameView.TabIndex = 4;
            this.fileNameView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.fileNameView_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(515, 216);
            this.Controls.Add(this.fileNameView);
            this.Controls.Add(this.objectNameView);
            this.Controls.Add(this.itemView);
            this.Controls.Add(this.searchBarLLabel);
            this.Controls.Add(this.searchBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "BoTW File Finder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchBar;
        private System.Windows.Forms.Label searchBarLLabel;
        private System.Windows.Forms.ListBox itemView;
        private System.Windows.Forms.ListBox objectNameView;
        private System.Windows.Forms.ListBox fileNameView;
    }
}

