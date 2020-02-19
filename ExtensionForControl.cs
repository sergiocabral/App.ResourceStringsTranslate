using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ResourceStringsTranslate
{
    public static class ExtensionForControl
    {
        private static readonly IDictionary<Control, DebounceControl> DebounceData =
            new Dictionary<Control, DebounceControl>();

        public static void Debounce(this Control control, Action action, int wait = 1000)
        {
            if (control == null) return;

            DebounceControl debounceControl;
            if (!DebounceData.ContainsKey(control))
            {
                DebounceData[control] = debounceControl = new DebounceControl
                {
                    Timer = new Timer(),
                    Action = action
                };
                debounceControl.Timer.Tick += DebounceTimerTick;
            }
            else
            {
                debounceControl = DebounceData[control];
                debounceControl.Action = action;
            }

            debounceControl.Timer.Interval = wait;
            debounceControl.Timer.Enabled = false;
            debounceControl.Timer.Enabled = true;
        }

        private static void DebounceTimerTick(object sender, EventArgs e)
        {
            var data = DebounceData.Single(a => a.Value.Timer == sender);
            data.Value.Timer.Enabled = false;
            data.Value.Action();
        }

        private class DebounceControl
        {
            public Action Action;
            public Timer Timer;
        }
    }
}