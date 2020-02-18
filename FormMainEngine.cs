using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Threading;

namespace ResourceStringsTranslate
{
    public class FormMainEngine
    {
        public static FormMainEngine Instance { get; } = new FormMainEngine();

        private FormMainEngine()
        {
            _queueWorker.DoWork += _queueWorker_DoWork;
        }

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

        public void QueueLoadResouceFiles(string path)
        {
            if (Data.ResourceFiles.Count > 0)
            {
                Data.ResourceFiles = new List<FormMainDataResourceFile>();
            }

            Queue(() =>
            {
                try
                {
                    Thread.Sleep(1000);
                    var directory = new DirectoryInfo(path);
                    if (!directory.Exists) return;
                    Data.ResourceFiles = directory
                        .GetFiles("*.resx")
                        .OrderBy(a => a.Name)
                        .Select(a => new FormMainDataResourceFile(a))
                        .ToList();
                }
                catch (Exception ex)
                {
                    Data.Status.Add($"Error when loading resources files from path \"{path}\". Error: {ex.GetType().Name}, {ex.Message}");
                }
            });
        }
    }
}
