using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace ResourceStringsTranslate
{
    public class EngineForFormMain
    {
        private readonly IList<DataForQueue> _queueActions = new List<DataForQueue>();

        private readonly BackgroundWorker _queueWorker = new BackgroundWorker();

        private bool _queueReloadDataStop;

        private EngineForFormMain()
        {
            _queueWorker.DoWork += _queueWorker_DoWork;
        }

        public static EngineForFormMain Instance { get; } = new EngineForFormMain();

        public DataForFormMain Data { get; set; } = new DataForFormMain();

        private void Log(string text, bool success = true, Exception ex = null)
        {
            text =
                $"{(success ? "   OK" : "ERROR")} [{DateTime.Now:g}] {text}{(ex == null ? string.Empty : $"{ex.GetType().Name}: {ex.Message}")}";
            if (text.Contains(Environment.NewLine))
            {
                var tab = text.IndexOf("]") + 2;
                text = text.Replace(Environment.NewLine, Environment.NewLine + new string(' ', tab));
            }

            Data.Status.Add(text);
        }

        private void _queueWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (_queueActions.Count > 0)
            {
                _queueActions[0].Action(_queueActions[0]);
                _queueActions.RemoveAt(0);
                QueueProgressCalculate();
            }
        }

        private void QueueProgressCalculate()
        {
            Data.Progress = (int) (100 * (1 / (double) (_queueActions.Sum(a => a.ProgressCount) + 1)));
        }

        private void Queue(Action<DataForQueue> action)
        {
            var data = new DataForQueue {Action = action};
            data.ProgressCountChanged += QueueProgressCalculate;
            _queueActions.Add(data);
            QueueProgressCalculate();
            if (_queueWorker.IsBusy) return;
            _queueWorker.RunWorkerAsync();
        }

        public void QueueLoadResourceFiles(string path)
        {
            if (Data.ResourceFiles.Count > 0) Data.ResourceFiles = new List<DataForResourceFile>();

            Queue(data =>
            {
                try
                {
                    if (string.IsNullOrWhiteSpace(path))
                    {
                        Log("Error loading resources files. Path is empty.", false);
                        return;
                    }

                    var directory = new DirectoryInfo(path);
                    if (!directory.Exists)
                    {
                        Log($"Error loading resources files. Path \"{path}\" not exists.", false);
                        return;
                    }

                    Data.ResourceFiles = directory
                        .GetFiles("*.resx")
                        .OrderBy(a => a.Name)
                        .Select(a => new DataForResourceFile(a))
                        .ToList();

                    if (Data.ResourceFiles.Count > 0)
                    {
                        Data.SelectedResourceFilesDirectory = Data.ResourceFiles[0].FileXml.Directory;
                        Log($"Resources files loaded from path \"{path}\".");
                    }
                    else
                    {
                        Data.SelectedResourceFilesDirectory = null;
                        Log($"No resources files found in path \"{path}\".", false);
                    }
                }
                catch (Exception ex)
                {
                    Log($"Error loading resources files from path \"{path}\".", false, ex);
                }
            });
        }

        public void QueueLoadResourceFile(string path, bool automaticQueueLoadData = true)
        {
            _queueReloadDataStop = true;
            Queue(data =>
            {
                try
                {
                    if (string.IsNullOrWhiteSpace(path))
                    {
                        Log("Error loading data of resource file. Path is empty.", false);
                        return;
                    }

                    var fileSelected = new DataForResourceFile(new FileInfo(path));
                    if (!fileSelected.FileXml.Exists || fileSelected.FileXml.Directory == null)
                    {
                        Log($"Error loading data of resource file. Path \"{path}\" not exists.", false);
                        return;
                    }

                    var selectedResourceFilePrefix = Regex.Replace(fileSelected.Name,
                        @"(\.[a-z]{2}(-[a-z]{2}|)|)\.resx", string.Empty, RegexOptions.IgnoreCase);
                    var selectedResourceFileGroupRegex =
                        $@"^{selectedResourceFilePrefix}\.";
                    var selectedResourceFileGroup = fileSelected.FileXml.Directory
                        .GetFiles("*.resx")
                        .Where(file => file.Name != fileSelected.Name &&
                                       Regex.IsMatch(file.Name, selectedResourceFileGroupRegex,
                                           RegexOptions.IgnoreCase))
                        .OrderBy(file => file.Name)
                        .Select(file => new DataForResourceFile(file))
                        .ToList();
                    selectedResourceFileGroup.Insert(0, fileSelected);

                    Data.SelectedResourceFilePrefix = selectedResourceFilePrefix;
                    Data.SelectedResourceFileGroup = selectedResourceFileGroup;

                    Log(
                        $"Selected group of resource files: {Data.SelectedResourceFileGroup.Aggregate(string.Empty, (acc, file) => $"{acc}, {file.Name}").Substring(2)}");
                }
                catch (Exception ex)
                {
                    Log($"Error loading data of resource file from path \"{path}\".", false, ex);
                    return;
                }

                if (automaticQueueLoadData) QueueLoadData();
            });
        }

        public void QueueLoadData()
        {
            _queueReloadDataStop = false;
            Queue(data =>
            {
                try
                {
                    if (Data.SelectedResourceFileGroup.Count == 0)
                    {
                        Log("No resources selected.", false);
                        return;
                    }

                    Log("Loading data of resource files.");

                    Data.Table.Clear();

                    data.ProgressCount += Data.SelectedResourceFileGroup.Count;
                    foreach (var resourceFile in Data.SelectedResourceFileGroup.TakeWhile(a => !_queueReloadDataStop))
                    {
                        Data.Table.AddLanguage(resourceFile.Language);

                        try
                        {
                            var resourceFileData = resourceFile.LoadData(out var errors);

                            Log(
                                $"Reading XML from \"{resourceFile.Name}\". Total translation keys: {resourceFileData.Count}.");
                            if (!string.IsNullOrWhiteSpace(errors)) Log(errors, false);

                            foreach (var text in resourceFileData)
                            {
                                if (_queueReloadDataStop) break;

                                Data.Table.InsertTranslate(resourceFile.Language, text.Key, text.Value);
                            }
                        }
                        catch (Exception ex)
                        {
                            Log($"Error reading XML from \"{resourceFile.Name}\".", false, ex);
                        }

                        data.ProgressCount--;
                    }

                    if (!_queueReloadDataStop)
                    {
                        Log("All resource files loaded.");
                    }
                    else
                    {
                        Data.Table.Clear();

                        Log("Canceled loading data of resource files.", false);
                    }
                }
                catch (Exception ex)
                {
                    Log("Error on loading data from resource files.", false, ex);
                }
            });
        }

        public void QueueSaveData(DataTable dataTable)
        {
            Queue(data =>
            {
                try
                {
                    var selectedResourceFileGroup = Data.SelectedResourceFileGroup;
                    var directory = Data.SelectedResourceFilesDirectory;
                    var selectedResourceFilePrefix = Data.SelectedResourceFilePrefix;

                    if (dataTable == null || 
                        selectedResourceFileGroup.Count == 0 ||
                        directory == null ||
                        string.IsNullOrWhiteSpace(selectedResourceFilePrefix))
                    {
                        Log("No data to save.", false);
                        return;
                    }

                    if (dataTable.Columns.Count == 1)
                    {
                        Log("No language to save.", false);
                        return;
                    }

                    Log("Saving data to resource files.");

                    var defaultResourceFile =
                        selectedResourceFileGroup.FirstOrDefault(a => a.IsDefaultLanguage) ??
                        selectedResourceFileGroup.First();

                        Data.Progress += dataTable.Columns.Count;
                    for (var i = 1; i < dataTable.Columns.Count; i++)
                    {
                        var translations = new Dictionary<string, string>();
                        foreach (DataRow row in dataTable.Rows)
                        {
                            var (key, text) = (row[0] as string, row[i] as string);
                            if (string.IsNullOrWhiteSpace(key) || string.IsNullOrWhiteSpace(text)) continue;
                            translations.Add(key, text);
                        }

                        var language = dataTable.Columns[i].ColumnName;
                        var resourceFile =
                            selectedResourceFileGroup.FirstOrDefault(a => a.Language == language) ??
                            new DataForResourceFile(new FileInfo(Path.Combine(directory.FullName,
                                selectedResourceFilePrefix +
                                (language != DataForResourceFile.LanguageDefaultName
                                    ? "." + language.Replace("_", "-")
                                    : string.Empty) +
                                ".resx")));

                        if (!resourceFile.FileXml.Exists)
                        {
                            defaultResourceFile.FileXml.CopyTo(resourceFile.FileXml.FullName);
                            resourceFile.FileXml.Refresh();
                        }

                        if (!defaultResourceFile.FileCSharp.Exists)
                        {
                            defaultResourceFile.FileCSharp.CopyTo(resourceFile.FileCSharp.FullName);
                            resourceFile.FileCSharp.Refresh();
                        }

                        resourceFile.SaveData(translations);

                        Data.Progress--;
                    }

                    Log("All data was saved to resource files.");
                }
                catch (Exception ex)
                {
                    Log("Error on saving data to resource files.", false, ex);
                }
            });
        }
    }
}