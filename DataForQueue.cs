using System;

namespace ResourceStringsTranslate
{
    public class DataForQueue
    {
        private int _progressCount = 1;
        public Action<DataForQueue> Action { get; set; }

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