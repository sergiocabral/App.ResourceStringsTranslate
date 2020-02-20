using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ResourceStringsTranslate
{
    public partial class FormMain : Form
    {
        private readonly EngineForFormMain _engine = EngineForFormMain.Instance;

        public FormMain()
        {
            InitializeComponent();

            textBoxSelectFolder.Text =
                folderBrowserDialog.SelectedPath =
#if DEBUG
                    @"C:\Git\Drake\Drake.Resources";
#else
                    new FileInfo(Environment.GetCommandLineArgs()[0]).Directory?.FullName;
#endif

            textBoxDefaultLanguage.Text = _engine.Data.DefaultLanguage;

            radioButtonModeGoogleTranslate.Checked =
                _engine.Data.TranslationService == typeof(DataForTranslationGoogleTranslate);
            textBoxModeGoogleTranslateUrl.Text = _engine.Data.TranslationGoogleTranslate.Url;
            numericUpDownModeGoogleTranslateBetweenRequests.Value =
                _engine.Data.TranslationGoogleTranslate.BetweenRequests;
            numericUpDownModeGoogleTranslateAfterBlock.Value = _engine.Data.TranslationGoogleTranslate.AfterBlock;

            radioButtonModeGoogleApi.Checked = _engine.Data.TranslationService == typeof(DataForTranslationGoogleApi);
            textBoxModeGoogleApiUrl.Text = _engine.Data.TranslationGoogleApi.Url;
            textBoxModeGoogleApiKey.Text = _engine.Data.TranslationGoogleApi.Key;

            radioButtonModeMicrosoftApi.Checked =
                _engine.Data.TranslationService == typeof(DataForTranslationMicrosoftApi);
            textBoxModeMicrosoftApiUrl.Text = _engine.Data.TranslationMicrosoftApi.Url;
            textBoxModeMicrosoftApiKey.Text = _engine.Data.TranslationMicrosoftApi.Key;
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
                _engine.Data.Status.Clear();
                textBoxStatus.Lines = status.ToArray();
                textBoxStatus.SelectionStart = textBoxStatus.Text.Length;
                textBoxStatus.ScrollToCaret();
            }

            if (dataGridViewData.DataSource != _engine.Data.Table.Translations)
            {
                dataGridViewData.DataSource = null;
                dataGridViewData.DataSource = _engine.Data.Table.Translations;
            }

            ;
        }

        private void buttonSelectFolder_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(textBoxSelectFolder.Text)) folderBrowserDialog.SelectedPath = textBoxSelectFolder.Text;

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                textBoxSelectFolder.Text = folderBrowserDialog.SelectedPath;
        }

        private void textBoxDefaultLanguage_TextChanged(object sender, EventArgs e)
        {
            if (textBoxDefaultLanguage.Tag != null) return;

            var language = textBoxDefaultLanguage.Text;

            textBoxDefaultLanguage.Debounce(() =>
            {
                textBoxDefaultLanguage.Tag = new object();

                _engine.Data.DefaultLanguage =
                    !string.IsNullOrWhiteSpace(language)
                        ? language
                        : textBoxDefaultLanguage.Text = DataForFormMain.DefaultLanguageValue;

                textBoxDefaultLanguage.Tag = null;
            });
        }

        private void textBoxSelectFolder_TextChanged(object sender, EventArgs e)
        {
            textBoxSelectFolder.BackColor =
                Directory.Exists(textBoxSelectFolder.Text)
                    ? SystemColors.Window
                    : Color.LightSalmon;

            var directory = textBoxSelectFolder.Text;
            textBoxSelectFolder.Debounce(() =>
            {
                progressBarStatus.Value = 0;
                _engine.QueueLoadResourceFiles(directory);
            });
        }

        private void listViewSelectResource_SelectedIndexChanged(object sender, EventArgs e)
        {
            var filename = listViewSelectResource
                .SelectedItems.Cast<ListViewItem>().SingleOrDefault()?
                .SubItems.Cast<ListViewItem.ListViewSubItem>().Last().Text;

            if (filename == null) return;

            listViewSelectResource.Debounce(() =>
            {
                progressBarStatus.Value = 0;
                _engine.QueueLoadResourceFile(filename);
            }, 100);
        }

        private void controlMode_Changed(object sender, EventArgs e)
        {
            var control = (Control) radioButtonModeGoogleTranslate;
            if (control.Tag != null) return;

            var translationService =
                radioButtonModeGoogleTranslate.Checked ? typeof(DataForTranslationGoogleTranslate) :
                radioButtonModeGoogleApi.Checked ? typeof(DataForTranslationGoogleApi) :
                radioButtonModeMicrosoftApi.Checked ? typeof(DataForTranslationMicrosoftApi) :
                throw new NotImplementedException();

            var translationGoogleTranslateUrl = textBoxModeGoogleTranslateUrl.Text;
            var translationGoogleTranslateBetweenRequests = (int) numericUpDownModeGoogleTranslateBetweenRequests.Value;
            var translationGoogleTranslateAfterBlock = (int) numericUpDownModeGoogleTranslateAfterBlock.Value;

            var translationGoogleApiUrl = textBoxModeGoogleApiUrl.Text;
            var translationGoogleApiKey = textBoxModeGoogleApiKey.Text;

            var translationMicrosoftApiUrl = textBoxModeMicrosoftApiUrl.Text;
            var translationMicrosoftApiKey = textBoxModeMicrosoftApiKey.Text;

            control.Debounce(() =>
            {
                control.Tag = new object();

                _engine.Data.TranslationService = translationService;

                _engine.Data.TranslationGoogleTranslate.Url =
                    !string.IsNullOrWhiteSpace(translationGoogleTranslateUrl)
                        ? translationGoogleTranslateUrl
                        : textBoxModeGoogleTranslateUrl.Text = DataForTranslationGoogleTranslate.UrlValue;

                _engine.Data.TranslationGoogleTranslate.BetweenRequests = translationGoogleTranslateBetweenRequests;

                _engine.Data.TranslationGoogleTranslate.AfterBlock = translationGoogleTranslateAfterBlock;

                _engine.Data.TranslationGoogleApi.Url =
                    !string.IsNullOrWhiteSpace(translationGoogleApiUrl)
                        ? translationGoogleApiUrl
                        : textBoxModeGoogleApiUrl.Text = DataForTranslationGoogleApi.UrlValue;

                _engine.Data.TranslationGoogleApi.Key = translationGoogleApiKey;

                _engine.Data.TranslationMicrosoftApi.Url =
                    !string.IsNullOrWhiteSpace(translationMicrosoftApiUrl)
                        ? translationMicrosoftApiUrl
                        : textBoxModeMicrosoftApiUrl.Text = DataForTranslationMicrosoftApi.UrlValue;

                _engine.Data.TranslationMicrosoftApi.Key = translationMicrosoftApiKey;

                control.Tag = null;
            });
        }

        private void buttonReloadData_Click(object sender, EventArgs e)
        {
            _engine.QueueReloadData();
        }

        private void textBoxStatus_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete) textBoxStatus.Clear();
        }
    }
}