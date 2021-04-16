using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Threading.AsyncDelegate
{
    public partial class ConcurencyThreadForm : Form
    {
        private bool abortSecondThread;
        public ConcurencyThreadForm()
        {
            InitializeComponent();
            btnStopProcess.Enabled = false;
        }

        private void btnStartProcess_Click(object sender, EventArgs e)
        {
            abortSecondThread = false;
            Thread secondThread = new Thread(new ThreadStart(ProcessData));
            secondThread.Start();
            txtProcessList.Text = "All is done." + Environment.NewLine;
        }

        private void ProcessData()
        {
            for (int i = 0; i < 1000; i++)
            {
                Invoke(new Action(() => UpdateTextBox(i, txtProcessList)));
                Thread.Sleep(500);
            }
        }

        private void UpdateTextBox(int processId, TextBox textBox)
        {
            textBox.Text += $"Process {processId} is done.{Environment.NewLine}";
        }
    }
}
