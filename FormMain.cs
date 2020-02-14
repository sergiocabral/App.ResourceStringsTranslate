using System;
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

            folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer;
            folderBrowserDialog.Description = labelSelectFolder.Text;
            folderBrowserDialog.ShowNewFolderButton = true;
            folderBrowserDialog.SelectedPath =
                textBoxSelectFolder.Text =
                    new FileInfo(Environment.GetCommandLineArgs()[0]).Directory?.FullName;

            _updateControlsTimer = new Timer
            {
                Interval = 500,
                Enabled = false
            };
            _updateControlsTimer.Tick += (sender, args) => UpdateControls(true);

            UpdateControls(true);
        }

        private readonly Timer _updateControlsTimer;

        private void UpdateControls(bool immediate = false)
        {
            if (_updateControlsTimer == null) return;

            _updateControlsTimer.Enabled = false;

            if (!immediate)
            {
                _updateControlsTimer.Enabled = true;
            }
            else
            {
                textBoxSelectFolder.BackColor =
                    Directory.Exists(textBoxSelectFolder.Text)
                        ? SystemColors.Window
                        : Color.DarkSalmon;
            }
        }

        private void buttonSelectFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() != DialogResult.OK) return;
            textBoxSelectFolder.Text = folderBrowserDialog.SelectedPath;
        }

        private void textBoxSelectFolder_TextChanged(object sender, EventArgs e)
        {
            UpdateControls();
        }
    }
}
