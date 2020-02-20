using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ResourceStringsTranslate
{
    public partial class FormMain : Form
    {
        private readonly EngineForFormMain _engine = EngineForFormMain.Instance;

        private readonly IList<IDictionary<string, string>> _waitForTranslate = new List<IDictionary<string, string>>();

        private bool _continuousTranslation;

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
                _engine.Data.TranslationService == _engine.Data.TranslationGoogleTranslate;
            textBoxModeGoogleTranslateUrl.Text = _engine.Data.TranslationGoogleTranslate.Url;
            numericUpDownModeGoogleTranslateBetweenRequests.Value =
                _engine.Data.TranslationGoogleTranslate.BetweenRequests;

            radioButtonModeGoogleApi.Checked = _engine.Data.TranslationService == _engine.Data.TranslationGoogleApi;
            textBoxModeGoogleApiUrl.Text = _engine.Data.TranslationGoogleApi.Url;
            textBoxModeGoogleApiKey.Text = _engine.Data.TranslationGoogleApi.Key;

            radioButtonModeMicrosoftApi.Checked =
                _engine.Data.TranslationService == _engine.Data.TranslationMicrosoftApi;
            textBoxModeMicrosoftApiUrl.Text = _engine.Data.TranslationMicrosoftApi.Url;
            textBoxModeMicrosoftApiKey.Text = _engine.Data.TranslationMicrosoftApi.Key;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Enabled = false;

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
                dataGridViewData.Columns.Clear();
                dataGridViewData.Rows.Clear();
                dataGridViewData.DataSource = _engine.Data.Table.Translations;

                textBoxManageLanguage.Enabled =
                    buttonManageLanguageAdd.Enabled =
                        buttonManageLanguageRemove.Enabled =
                            dataGridViewData.ColumnCount > 0;

                if (!textBoxManageLanguage.Enabled) textBoxManageLanguage.Clear();
            }

            if (_engine.Data.CheckNewFiles) textBoxSelectFolder.Text += " ";

            while (!_engine.Data.TranslatingRunning &&
                   _waitForTranslate.Count > 0)
            {
                var translated = _waitForTranslate[0];
                _waitForTranslate.RemoveAt(0);
                if (translated.ContainsKey(EngineForFormMain.FlagForTranslated))
                    UpdateDataGrid(translated);
                else
                    _continuousTranslation = false;
            }

            if (!_engine.Data.TranslatingRunning &&
                _continuousTranslation)
            {
                if (buttonTranslateNext.Tag == null)
                {
                    buttonTranslateNext.Tag = new object();
                }
                else
                {
                    buttonTranslateNext.Tag = null;
                    buttonTranslateNext.PerformClick();
                }
            }

            if (_continuousTranslation && buttonTranslateAll.BackColor != Color.SteelBlue)
                buttonTranslateAll.BackColor = Color.SteelBlue;
            else if (!_continuousTranslation && buttonTranslateAll.BackColor == Color.SteelBlue)
                buttonTranslateAll.BackColor = buttonTranslateNext.BackColor;

            DataGridReadOnly(_engine.Data.TranslatingRunning);

            timer.Enabled = true;
        }

        private void UpdateDataGrid(IDictionary<string, string> translated)
        {
            var row = dataGridViewData.Rows
                .Cast<DataGridViewRow>()
                .First(row =>
                    row.Cells[TableForTranslations.ColumnKeyName].Value.ToString()
                        .Equals(translated[TableForTranslations.ColumnKeyName]));

            foreach (var column in translated)
            {
                if (column.Key == TableForTranslations.ColumnKeyName ||
                    column.Key == EngineForFormMain.FlagForTranslated) continue;
                row.Cells[column.Key].Value = column.Value;
            }
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

            var directory = textBoxSelectFolder.Text.Trim();
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
                radioButtonModeGoogleTranslate.Checked ? _engine.Data.TranslationGoogleTranslate :
                radioButtonModeGoogleApi.Checked ? _engine.Data.TranslationGoogleApi :
                radioButtonModeMicrosoftApi.Checked ? (ITranslation) _engine.Data.TranslationMicrosoftApi :
                throw new NotImplementedException();

            var translationGoogleTranslateUrl = textBoxModeGoogleTranslateUrl.Text;
            var translationGoogleTranslateBetweenRequests = (int) numericUpDownModeGoogleTranslateBetweenRequests.Value;

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
                        : textBoxModeGoogleTranslateUrl.Text = EngineForTranslationGoogleTranslate.UrlValue;

                _engine.Data.TranslationGoogleTranslate.BetweenRequests = translationGoogleTranslateBetweenRequests;

                _engine.Data.TranslationGoogleApi.Url =
                    !string.IsNullOrWhiteSpace(translationGoogleApiUrl)
                        ? translationGoogleApiUrl
                        : textBoxModeGoogleApiUrl.Text = EngineForTranslationGoogleApi.UrlValue;

                _engine.Data.TranslationGoogleApi.Key = translationGoogleApiKey;

                _engine.Data.TranslationMicrosoftApi.Url =
                    !string.IsNullOrWhiteSpace(translationMicrosoftApiUrl)
                        ? translationMicrosoftApiUrl
                        : textBoxModeMicrosoftApiUrl.Text = EngineForTranslationMicrosoftApi.UrlValue;

                _engine.Data.TranslationMicrosoftApi.Key = translationMicrosoftApiKey;

                control.Tag = null;
            });
        }

        private void buttonReloadData_Click(object sender, EventArgs e)
        {
            _engine.QueueLoadData();
        }

        private void textBoxStatus_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete) textBoxStatus.Clear();
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            _engine.QueueSaveData(dataGridViewData.ToDataTable());
        }

        private void buttonManageLanguage_Click(object sender, EventArgs e)
        {
            if (dataGridViewData.RowCount == 0) return;

            var columnName = textBoxManageLanguage.Text.Trim();
            if (string.IsNullOrWhiteSpace(columnName)) return;

            var add = sender == buttonManageLanguageAdd;
            var column = dataGridViewData.Columns[columnName];


            if (column != null && column.Index == 0) return;

            if (add && column == null)
                dataGridViewData.Columns.Add(columnName, columnName);
            else if (!add && column != null)
                dataGridViewData.Columns.Remove(column);
            else
                return;

            textBoxManageLanguage.Clear();
        }

        private void textBoxManageLanguage_TextChanged(object sender, EventArgs e)
        {
            if (textBoxManageLanguage.Text == textBoxManageLanguage.Text.ToLower() &&
                !Regex.IsMatch(textBoxManageLanguage.Text, @"[^a-z]", RegexOptions.IgnoreCase)) return;

            var selectionStart = textBoxManageLanguage.SelectionStart;

            textBoxManageLanguage.Text = Regex.Replace(textBoxManageLanguage.Text, @"[^a-z]", string.Empty,
                RegexOptions.IgnoreCase).ToLower();

            textBoxManageLanguage.SelectionStart = selectionStart;
            textBoxManageLanguage.SelectionLength = 0;
        }

        private void buttonTranslateNext_Click(object sender, EventArgs e)
        {
            if (dataGridViewData.RowCount == 0 || _engine.Data.TranslatingRunning) return;

            var row = dataGridViewData.Rows
                .Cast<DataGridViewRow>()
                .OrderBy(row => row.Index)
                .FirstOrDefault(a =>
                    a.Cells
                        .Cast<DataGridViewCell>()
                        .Any(b => string.IsNullOrWhiteSpace($"{b.Value}")));

            if (row == null)
            {
                _continuousTranslation = false;
                return;
            }

            var firstColumn = dataGridViewData.Columns.GetFirstColumn(DataGridViewElementStates.Displayed);
            if (firstColumn.Index == 0)
                firstColumn = dataGridViewData.Columns.GetNextColumn(firstColumn, DataGridViewElementStates.Displayed,
                    DataGridViewElementStates.None);

            var data = new Dictionary<string, string>();
            data.Add(dataGridViewData.Columns[0].Name, $"{row.Cells[0].Value}");
            data.Add(dataGridViewData.Columns[firstColumn.Index].Name, $"{row.Cells[firstColumn.Index].Value}");
            for (var i = 1; i < row.Cells.Count; i++)
            {
                if (i == firstColumn.Index) continue;
                data.Add(dataGridViewData.Columns[i].Name, $"{row.Cells[i].Value}");
            }

            _waitForTranslate.Add(data);
            _engine.QueueTranslate(data, textBoxDefaultLanguage.Text);

            DataGridReadOnly(true);
        }

        private void DataGridReadOnly(bool mode)
        {
            if ((!mode || dataGridViewData.ReadOnly) && (mode || !dataGridViewData.ReadOnly)) return;

            dataGridViewData.ReadOnly = mode;
            dataGridViewData.AllowUserToOrderColumns = !mode;
            foreach (DataGridViewColumn column in dataGridViewData.Columns)
                column.SortMode = mode
                    ? DataGridViewColumnSortMode.NotSortable
                    : DataGridViewColumnSortMode.Automatic;
        }

        private void buttonTranslateAll_Click(object sender, EventArgs e)
        {
            if (dataGridViewData.RowCount == 0) return;
            _continuousTranslation = true;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            _continuousTranslation = false;
        }
    }
}