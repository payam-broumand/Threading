using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Threading.AsyncDelegate
{
    public delegate void ProcessDataListDelegate();
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tnStartProcess_Click(object sender, EventArgs e)
        {
            ProcessDataListDelegate processDeletegate = new ProcessDataListDelegate(ProcessDataList);
            processDeletegate.BeginInvoke(null, null);
        }

        private void ProcessDataList()
        {
            for (int process = 1; process <= 10000; process++)
            {
                if(txtProcessList.InvokeRequired)
                    Invoke(new Action(() => UpdateTxtDataList(process.ToString())));
                else
                    UpdateTxtDataList(process.ToString());
            }
        }

        private void UpdateTxtDataList(string data)
        {
            txtProcessList.Text += $"Process {data} is done.{Environment.NewLine}";
        }
    }
}
