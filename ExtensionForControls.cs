using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ResourceStringsTranslate
{
    public static class ExtensionForControls
    {
        private struct DebounceData
        {
            public Timer Timer;
            public Action Action;
        }

        private static IDictionary<Control, DebounceData> _debounce = new Dictionary<Control, DebounceData>();

        public static void Debounce(this Control control, Action action, int wait = 1000)
        {
            if (control == null) return;

            DebounceData data;
            if (!_debounce.ContainsKey(control))
            {
                _debounce[control] = data = new DebounceData
                {
                    Timer = new Timer(),
                    Action = action
                };
                data.Timer.Tick += DebounceTimerTick;
            }
            else
            {
                data = _debounce[control];
                data.Action = action;
            }

            data.Timer.Interval = wait;
            data.Timer.Enabled = false;
            data.Timer.Enabled = true;
        }

        private static void DebounceTimerTick(object sender, EventArgs e)
        {
            var data = _debounce.Single(a => a.Value.Timer == sender);
            data.Value.Timer.Enabled = false;
            data.Value.Action();
        }
    }
}
