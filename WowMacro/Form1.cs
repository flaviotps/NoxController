using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows;
using System.Windows.Forms;

namespace WowMacro
{    
    public partial class Form1 : Form
    {


        private List<MacroController> macroControllerList = new List<MacroController>();
        private string processName = "Nox";
        private WowWindow wowWindow;


        public Form1()
        {         
            InitializeComponent();
            init();
            loadWowWindows();
            Text = "Nox Controller";
        }

        private void init()
        {
            cbProcesses.Text = "Select a process";
        }

        private void loadWowWindows()
        {
            cbProcesses.Items.Clear();
            var processes = System.Diagnostics.Process.GetProcessesByName(processName);
            if (processes != null)
            {               
                foreach (Process process in processes)
                {
                    var found = false;
                    foreach (MacroController macroController in macroControllerList)
                    {
                        if (macroController.getWowWindow().process.Id == process.Id)
                        {
                            found = true;
                        }
                    }

                    if (!found)
                    {
                        cbProcesses.Items.Add(new WowWindow(process, process.MainWindowTitle));
                    }
                }
            }
            else
            {
                MessageBox.Show("Couldn't find the wow process");
            }
        }



        private void buttonStartWow_Click(object sender, EventArgs e)
        {
            if (wowWindow == null)
            {
                MessageBox.Show("Please, Selected a wow Process");
            }
            else
            {               
                           
                var macroController = new MacroController(wowWindow);
                macroController.startMacro();
                dataGridProcess.Rows.Add(wowWindow.process.Id,wowWindow.name, "N/A", true);
                macroControllerList.Add(macroController);
                cbProcesses.SelectedItem = null;
                cbProcesses.Text = "Select a process";

            }
        }

        private void cbProcesses_SelectedIndexChanged(object sender, EventArgs e)
        {
            wowWindow = (WowWindow)cbProcesses.SelectedItem;
        }

        private void cbProcesses_Click(object sender, EventArgs e)
        {           
            loadWowWindows();
        }

        private void cbProcesses_Enter(object sender, EventArgs e)
        {
            loadWowWindows();
        }

        private void dataGridProcess_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            int index = e.Row.Index;
            macroControllerList[index].stop();
            macroControllerList.RemoveAt(index);
        }

        private void dataGridProcess_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            senderGrid.EndEdit();
            int index = e.RowIndex;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn &&
                index >= 0)
            {
                var cbxCell = (DataGridViewCheckBoxCell)senderGrid.Rows[index].Cells["Status"];

                if ((bool)cbxCell.Value)
                {                
                    macroControllerList[index].restart();
                }
                else
                {                  
                    macroControllerList[index].stop();
                }
            }
        }
    }
}
