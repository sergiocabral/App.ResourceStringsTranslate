using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using Timer = System.Windows.Forms.Timer;

namespace ResourceStringsTranslate
{
    public class FormMainEngine
    {
        public static FormMainEngine Instance { get; } = new FormMainEngine();

        private FormMainEngine()
        {
            _queueWorker.DoWork += _queueWorker_DoWork;
        }

        private void Log(string text, bool success = true, Exception ex = null) =>
            Data.Status.Add($"{(success ? "   OK" : "ERROR")} [{DateTime.Now:g}] {text}{(ex == null ? string.Empty : $"{ex.GetType().Name}: {ex.Message}")}");

        public FormMainData Data { get; set; } = new FormMainData();

        private readonly IList<Action> _queueActions = new List<Action>();

        private readonly BackgroundWorker _queueWorker = new BackgroundWorker();

        private void _queueWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (_queueActions.Count > 0)
            {
                _queueActions[0]();
                _queueActions.RemoveAt(0);
                QueueProgressCalculate();
            }
        }

        private void QueueProgressCalculate()
        {
            Data.Progress = (int) (100 * (_queueActions.Count == 0 ? 1 : 1 / (double) (_queueActions.Count + 1)));
        }

        private void Queue(Action action)
        {
            _queueActions.Add(action);
            QueueProgressCalculate();
            if (_queueWorker.IsBusy) return;
            _queueWorker.RunWorkerAsync();
        }

        public void QueueLoadResourceFiles(string path)
        {
            if (Data.ResourceFiles.Count > 0)
            {
                Data.ResourceFiles = new List<FormMainDataResourceFile>();
            }

            Queue(() =>
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
                        .Select(a => new FormMainDataResourceFile(a))
                        .ToList();

                    if (Data.ResourceFiles.Count > 0)
                    {
                        Log($"Resources files loaded from path \"{path}\".");
                    }
                    else
                    {
                        Log($"No resources files found in path \"{path}\".", false);
                    }
                }
                catch (Exception ex)
                {
                    Log($"Error loading resources files from path \"{path}\".", false, ex);
                }
            });
        }

        public void QueueLoadResourceFile(string path)
        {
            Queue(() =>
            {
                try
                {
                    if (string.IsNullOrWhiteSpace(path))
                    {
                        Log("Error loading data of resource file. Path is empty.", false);
                        return;
                    }

                    var fileSelected = new FileInfo(path);
                    var directory = fileSelected.Directory;
                    if (!fileSelected.Exists || directory == null)
                    {
                        Log($"Error loading data of resource file. Path \"{path}\" not exists.", false);
                        return;
                    }

                    var selectedResourceFileGroupRegex = $@"^{Regex.Replace(fileSelected.Name, @"(\.[a-z]{2}(-[a-z]{2}|)|)\.resx", string.Empty, RegexOptions.IgnoreCase)}\.";
                    var selectedResourceFileGroup = directory
                        .GetFiles("*.resx")
                        .Where(file => file.Name != fileSelected.Name &&
                                       Regex.IsMatch(file.Name, selectedResourceFileGroupRegex, RegexOptions.IgnoreCase))
                        .OrderBy(file => file.Name)
                        .ToList();
                    selectedResourceFileGroup.Insert(0, fileSelected);
                    Data.SelectedResourceFileGroup = selectedResourceFileGroup;
                    
                    Log($"Selected group of resource files: {Data.SelectedResourceFileGroup.Aggregate(string.Empty, (acc, file) => $"{acc}, {file.Name}").Substring(2)}");
                }
                catch (Exception ex)
                {
                    Log($"Error loading data of resource file from path \"{path}\".", false, ex);
                }
            });
        }
    }
}
