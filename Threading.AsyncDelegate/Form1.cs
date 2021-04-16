using System;
using System.Threading;
using System.Windows.Forms;

namespace Threading.AsyncDelegate
{
    public delegate void ProcessDataListDelegate();
    public partial class Form1 : Form
    {
        private bool abortThread;
        public Form1()
        {
            InitializeComponent();
            btnEndProcess.Enabled = false;
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
                if(abortThread) break;
                if(txtProcessList.InvokeRequired)
                    Invoke(new Action(() => UpdateTxtDataList(process.ToString())));
                else
                    UpdateTxtDataList(process.ToString());
                Thread.Sleep(500);
            }
        }

        private void UpdateTxtDataList(string data)
        {
            txtProcessList.Text += $"Process {data} is done.{Environment.NewLine}";
        }

        private void btnEndProcess_Click(object sender, EventArgs e)
        {
            btnEndProcess.Enabled = false;
            tnStartProcess.Enabled = true;
            abortThread = true;
            txtProcessList.Clear();
        }
    }
}
