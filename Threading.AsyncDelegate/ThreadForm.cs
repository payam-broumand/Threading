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
    public partial class ThreadForm : Form
    {
        private bool abortSecondThread, abortThiredThread;
        public ThreadForm()
        {
            InitializeComponent();
            btnStartProcess.Enabled = true;
            btnStopProcess.Enabled = true;
        }

        private void btnStartProcess_Click(object sender, EventArgs e)
        {
            abortSecondThread = false;
            txtProcessList.Clear();
            if (!string.IsNullOrEmpty(Thread.CurrentThread.Name))
                Thread.CurrentThread.Name = "Primary Thread";
            Thread secondThread = new Thread(new ThreadStart(ProcessData));
            txtProcessList.Text = $"Program running by {Thread.CurrentThread.Name} with ID {Thread.CurrentThread.ManagedThreadId}";
            secondThread.Name = "Second Thread";
            secondThread.Start();
            txtProcessList.Text += $"{Environment.NewLine}All Done{Environment.NewLine}";
            btnStartProcess.Enabled = false;
            btnStopProcess.Enabled = true;
        }

        private void ProcessData()
        {
            string secondThreadName = Thread.CurrentThread.Name;
            for (int i = 0; i < 100; i++)
            {
                if (abortSecondThread) Thread.CurrentThread.Abort();
                if (txtProcessList.InvokeRequired)
                    this.Invoke(new Action(() => UpdateTextBox(i + 1, txtProcessList, secondThreadName)));
                else
                    UpdateTextBox(i + 1, txtProcessList, secondThreadName);
                Thread.Sleep(500);
            }

            Thread thiredThread = new Thread(new ParameterizedThreadStart(ProcessSumNumbers));
            if(!string.IsNullOrEmpty(thiredThread.Name))
                thiredThread.Name = "Thired Thread";
            thiredThread.Start(new Number(1, 10));
        }

        private void UpdateTextBox(int processNumber, TextBox textBox, string threadName)
        {
            textBox.Text += $"Process {processNumber} Done on {threadName}.{Environment.NewLine}";
        }

        private void btnStopProcess_Click(object sender, EventArgs e)
        {
            abortSecondThread = true;
            btnStartProcess.Enabled = true;
            btnStopProcess.Enabled = false;
        } 

        private void ProcessSumNumbers(object data)
        {
            Number number = (Number)data;
            string thiredThreadName = Thread.CurrentThread.Name;
            for (int i = number.From; i <= number.To; i++)
            {
                if (abortThiredThread) Thread.CurrentThread.Abort();
                if (txtParametrizedProcessList.InvokeRequired)
                    this.Invoke(new Action(() => UpdateTextBox(i + 1, txtParametrizedProcessList, thiredThreadName)));
                else
                    UpdateTextBox(i + 1, txtParametrizedProcessList, thiredThreadName);
                Thread.Sleep(1000);
            }
        }

        private void btnParametrizedThreadStart_Click(object sender, EventArgs e)
        {
            abortThiredThread = false;
            txtParametrizedProcessList.Clear();
            if (!string.IsNullOrEmpty(Thread.CurrentThread.Name))
                Thread.CurrentThread.Name = "Primary Thread";
            txtParametrizedProcessList.Text = $"Running program from {Thread.CurrentThread.Name} with ID {Thread.CurrentThread.ManagedThreadId}";
            Thread thiredThread = new Thread(new ParameterizedThreadStart(ProcessSumNumbers));
            thiredThread.Name = "Thired Thread";
            thiredThread.Start(new Number(1, 10));
            btnParametrizedThreadStart.Enabled = false;
            btnParametrizedThreadStop.Enabled = true;
        }

        private void btnParametrizedThreadStop_Click(object sender, EventArgs e)
        {
            abortThiredThread = true;
            btnParametrizedThreadStart.Enabled = true;
            btnParametrizedThreadStop.Enabled = false;
        }
    }

    public class Number
    {
        public int From { get; set; }

        public int To { get; set; }

        public Number(int op1, int op2)
        {
            this.From = op1;
            this.To = op2;
        }


    }
}
