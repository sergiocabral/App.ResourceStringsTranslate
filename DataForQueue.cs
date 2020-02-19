using System;

namespace ResourceStringsTranslate
{
    public class DataForQueue
    {
        public Action<DataForQueue> Action { get; set; }

        private int _progressCount = 1;

        public int ProgressCount
        {
            get => _progressCount;
            set
            {
                _progressCount = value;
                ProgressCountChanged?.Invoke();
            }
        }

        public event Action ProgressCountChanged;
    }
}