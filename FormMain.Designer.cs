namespace ResourceStringsTranslate
{
    partial class FormMain
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
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.panelSelectFolder = new System.Windows.Forms.Panel();
            this.textBoxSelectFolder = new System.Windows.Forms.TextBox();
            this.buttonSelectFolder = new System.Windows.Forms.Button();
            this.labelSelectFolder = new System.Windows.Forms.Label();
            this.panelSelectFolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSelectFolder
            // 
            this.panelSelectFolder.Controls.Add(this.labelSelectFolder);
            this.panelSelectFolder.Controls.Add(this.buttonSelectFolder);
            this.panelSelectFolder.Controls.Add(this.textBoxSelectFolder);
            this.panelSelectFolder.Location = new System.Drawing.Point(12, 12);
            this.panelSelectFolder.Name = "panelSelectFolder";
            this.panelSelectFolder.Size = new System.Drawing.Size(368, 42);
            this.panelSelectFolder.TabIndex = 0;
            // 
            // textBoxSelectFolder
            // 
            this.textBoxSelectFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSelectFolder.Location = new System.Drawing.Point(6, 16);
            this.textBoxSelectFolder.Name = "textBoxSelectFolder";
            this.textBoxSelectFolder.Size = new System.Drawing.Size(330, 20);
            this.textBoxSelectFolder.TabIndex = 0;
            this.textBoxSelectFolder.TextChanged += new System.EventHandler(this.textBoxSelectFolder_TextChanged);
            // 
            // buttonSelectFolder
            // 
            this.buttonSelectFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelectFolder.Location = new System.Drawing.Point(342, 16);
            this.buttonSelectFolder.Name = "buttonSelectFolder";
            this.buttonSelectFolder.Size = new System.Drawing.Size(26, 20);
            this.buttonSelectFolder.TabIndex = 1;
            this.buttonSelectFolder.Text = "...";
            this.buttonSelectFolder.UseVisualStyleBackColor = true;
            this.buttonSelectFolder.Click += new System.EventHandler(this.buttonSelectFolder_Click);
            // 
            // labelSelectFolder
            // 
            this.labelSelectFolder.AutoSize = true;
            this.labelSelectFolder.Location = new System.Drawing.Point(3, 0);
            this.labelSelectFolder.Name = "labelSelectFolder";
            this.labelSelectFolder.Size = new System.Drawing.Size(69, 13);
            this.labelSelectFolder.TabIndex = 2;
            this.labelSelectFolder.Text = "Select folder:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelSelectFolder);
            this.Name = "FormMain";
            this.Text = "Resource Strings Translate";
            this.panelSelectFolder.ResumeLayout(false);
            this.panelSelectFolder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Panel panelSelectFolder;
        private System.Windows.Forms.Label labelSelectFolder;
        private System.Windows.Forms.Button buttonSelectFolder;
        private System.Windows.Forms.TextBox textBoxSelectFolder;
    }
}

