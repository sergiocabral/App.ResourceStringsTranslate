using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ResourceStringsTranslate
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            textBoxSelectFolder.Text = 
                folderBrowserDialog.SelectedPath = 
                    new FileInfo(Environment.GetCommandLineArgs()[0]).Directory?.FullName;
        }

        private void buttonSelectFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxSelectFolder.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void textBoxSelectFolder_TextChanged(object sender, EventArgs e)
        {
            textBoxSelectFolder.BackColor =
                Directory.Exists(textBoxSelectFolder.Text)
                    ? SystemColors.Window
                    : Color.LightSalmon;
        }
    }
}
