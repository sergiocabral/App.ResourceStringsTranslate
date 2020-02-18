using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace ResourceStringsTranslate
{
    public partial class FormMain : Form
    {
        private FormMainEngine _engine = FormMainEngine.Instance;

        public FormMain()
        {
            InitializeComponent();

            textBoxSelectFolder.Text =
                folderBrowserDialog.SelectedPath =
                    new FileInfo(Environment.GetCommandLineArgs()[0]).Directory?.FullName;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            progressBarStatus.Value = _engine.Data.Progress;

            if (listViewSelectResource.Tag != _engine.Data.ResourceFiles)
            {
                listViewSelectResource.Tag = _engine.Data.ResourceFiles;
                listViewSelectResource.Items.Clear();
                listViewSelectResource.Items.AddRange(
                    _engine.Data.ResourceFiles
                        .Select(a => new ListViewItem(a.Details))
                        .ToArray());
            }

            if (_engine.Data.Status.Count > 0)
            {
                var status = textBoxStatus.Lines.ToList();
                status.AddRange(_engine.Data.Status);
                status.Add(Environment.NewLine);
                _engine.Data.Status.Clear();
                textBoxStatus.Lines = status.ToArray();
                textBoxStatus.SelectionStart = textBoxStatus.Text.Length;
                textBoxStatus.ScrollToCaret();
            }
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

            (sender as Control).Debounce(() =>
            {
                progressBarStatus.Value = 0;
                _engine.QueueLoadResourceFiles(textBoxSelectFolder.Text);
            });
        }
    }
}