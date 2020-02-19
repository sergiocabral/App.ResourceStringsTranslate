using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ResourceStringsTranslate
{
    public static class ExtensionForControls
    {
        private class DebounceData
        {
            public Timer Timer;
            public Action<object> Action;
            public object Data;
        }

        private static readonly IDictionary<Control, DebounceData> _debounce = new Dictionary<Control, DebounceData>();

        public static void Debounce(this Control control, Action<object> action, object data = null, int wait = 1000)
        {
            if (control == null) return;

            DebounceData debounceData;
            if (!_debounce.ContainsKey(control))
            {
                _debounce[control] = debounceData = new DebounceData
                {
                    Timer = new Timer(),
                    Action = action,
                    Data = data
                };
                debounceData.Timer.Tick += DebounceTimerTick;
            }
            else
            {
                debounceData = _debounce[control];
                debounceData.Action = action;
                debounceData.Data = data;
            }

            debounceData.Timer.Interval = wait;
            debounceData.Timer.Enabled = false;
            debounceData.Timer.Enabled = true;
        }

        private static void DebounceTimerTick(object sender, EventArgs e)
        {
            var data = _debounce.Single(a => a.Value.Timer == sender);
            data.Value.Timer.Enabled = false;
            data.Value.Action(data.Value.Data);
        }
    }
}
