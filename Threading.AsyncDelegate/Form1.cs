using System;
using System.Threading;
using System.Windows.Forms;

namespace Threading.AsyncDelegate
{
    public delegate void ProcessDataListDelegate();
    public partial class Form1 : Form
    {
        private bool abortThread;
        private bool secondAbortThread;
        public Form1()
        {
            InitializeComponent();
            btnEndProcess.Enabled = false;
            btnStopSecondProcess.Enabled = false;
        }

        private void tnStartProcess_Click(object sender, EventArgs e)
        {
            abortThread = false;
            ProcessDataListDelegate processDeletegate = new ProcessDataListDelegate(ProcessDataList);
            processDeletegate.BeginInvoke(null, null);
            btnEndProcess.Enabled = true;
            tnStartProcess.Enabled = false;
        }

        private void ProcessDataList()
        {
            for (int process = 1; process <= 10000; process++)
            {
                if (abortThread) break;
                if (txtProcessList.InvokeRequired)
                    Invoke(new Action(() => UpdateTxtDataList(process.ToString(), txtProcessList)));
                else
                    UpdateTxtDataList(process.ToString(), txtProcessList);
                Thread.Sleep(500);
            }
        }

        private void ProcessSecondDataList()
        {
            for (int process = 1; process <= 10000; process++)
            {
                if (secondAbortThread) break;
                if (txtSeondProcessDataList.InvokeRequired)
                    Invoke(new Action(() => UpdateTxtDataList(process.ToString(), txtSeondProcessDataList)));
                else
                    UpdateTxtDataList(process.ToString(), txtSeondProcessDataList);
                Thread.Sleep(500);
            }
        }

        private void UpdateTxtDataList(string data, TextBox textBox)
        {
            textBox.Text += $"Process {data} is done.{Environment.NewLine}";
        }

        private void btnEndProcess_Click(object sender, EventArgs e)
        {
            btnEndProcess.Enabled = false;
            tnStartProcess.Enabled = true;
            abortThread = true;
            txtProcessList.Clear();
        }

        private void btnStartSecondProcess_Click(object sender, EventArgs e)
        {
            secondAbortThread = false;
            ProcessDataListDelegate processDataListDelegate = new ProcessDataListDelegate(ProcessSecondDataList);
            processDataListDelegate.BeginInvoke(null, null);
            btnStopSecondProcess.Enabled = true;
            btnStartSecondProcess.Enabled = false;
        }

        private void btnStopSecondProcess_Click(object sender, EventArgs e)
        {
            btnStartSecondProcess.Enabled = true;
            btnStopSecondProcess.Enabled = false;
            secondAbortThread = true;
            txtSeondProcessDataList.Clear();
        }
    }
}
