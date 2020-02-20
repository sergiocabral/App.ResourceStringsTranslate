using System;
using System.Collections.Generic;
using System.Data;
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

        public static DataTable ToDataTable(this DataGridView dataGridView)
        {
            try
            {
                if (dataGridView.ColumnCount == 0) return null;
                
                var dataTable = new DataTable();

                foreach (DataGridViewColumn column in dataGridView.Columns)
                {
                    dataTable.Columns.Add(
                        column.Name, 
                        column.ValueType == null 
                            ? typeof(string) 
                            : column.ValueType);
                    dataTable.Columns[column.Name].Caption = column.HeaderText;
                }

                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    var newRow = dataTable.NewRow();
                    foreach (DataColumn column in dataTable.Columns)
                    {
                        newRow[column.ColumnName] = row.Cells[column.ColumnName].Value;
                    }

                    dataTable.Rows.Add(newRow);
                }

                return dataTable;
            }
            catch
            {
                return null;
            }
        }
    }
}