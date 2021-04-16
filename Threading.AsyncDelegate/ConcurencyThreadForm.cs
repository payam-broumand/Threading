using System;
using System.Threading;
using System.Windows.Forms;

namespace Threading.AsyncDelegate
{
    public partial class ConcurencyThreadForm : Form
    {
        AutoResetEvent resetEvent = new AutoResetEvent(false);
        private bool abortSecondThread;
        public ConcurencyThreadForm()
        {
            InitializeComponent();
            btnStopProcess.Enabled = false;
        }

        private void btnStartProcess_Click(object sender, EventArgs e)
        {
            abortSecondThread = false;
            Thread thread = new Thread(DoWork);
            thread.Name = "Do Work Thread";
            thread.Start();
        }

        private void DoWork()
        {
            string threadName = Thread.CurrentThread.Name;
            Invoke(new Action(() => txtProcessList.Text += $"{threadName} is started {Environment.NewLine}"));
            Thread thread = new Thread(new ParameterizedThreadStart(ProcessData));
            thread.Name = "Process Data Thread";
            thread.Start(new Boundery(1, 10));

            resetEvent.WaitOne();
            Invoke(new Action(() => txtProcessList.Text += "ALL PROCESS IS DONE" + Environment.NewLine));
        }

        private void ProcessData(object data)
        {
            string threadName = Thread.CurrentThread.Name;
            Invoke(new Action(() => txtProcessList.Text += $"{threadName} is running{Environment.NewLine}"));
            if (data is Boundery boundery)
            {
                for (int i = boundery.From; i <= boundery.To; i++)
                {
                    if (abortSecondThread) Thread.CurrentThread.Abort();
                    Invoke(new Action(() => UpdateTextBox(i, txtProcessList)));
                    Thread.Sleep(500);
                }
                resetEvent.Set();
            }
        }

        private void UpdateTextBox(int processId, TextBox textBox)
        {
            textBox.Text += $"Process {processId} is done.{Environment.NewLine}";
        }
    }

    public class Boundery
    {
        public int From { get; set; }
        public int To { get; set; }

        public Boundery(int from, int to)
        {
            this.From = from;
            this.To = to;
        }
    }
}
