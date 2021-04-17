using System;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Threading;
using System.Windows.Forms;

namespace Threading.AsyncDelegate
{
    public partial class ConcurencyThreadForm : Form
    {
        AutoResetEvent resetEvent = new AutoResetEvent(false);
        private bool abortSecondThread;
        private object threadLock = new object();
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

        private void btnStartMultiThread_Click(object sender, EventArgs e)
        {
            Thread[] threads = new Thread[10];
            Printer printer = new Printer();
            printer.Form = this;
            for (int i = 0; i < threads.Length; i++)
            {
                threads[i] = new Thread(printer.PrintNumbers);
                threads[i].Name = $"Thread {i + 1}";
                threads[i].Start();
            }
        }

        private void PrintNumbers()
        {
            // using lock to locking current thread while task is done
            //lock (threadLock)
            //{
            //    string threadName = Thread.CurrentThread.Name;
            //    Invoke(new Action(() => txtPrintNumbers.Text += $"{threadName} started ...{Environment.NewLine}"));
            //    var numbers = new int[10];
            //    for (int i = 0; i < numbers.Length; i++)
            //    {
            //        Invoke(new Action(() => txtPrintNumbers.Text += $"Operation {i + 1} Passed.{Environment.NewLine}"));
            //        Thread.Sleep(500);
            //    }
            //}

            // using monitor to locking current thread while thread task is done
            Monitor.Enter(threadLock);
            try
            {
                string threadName = Thread.CurrentThread.Name;
                Invoke(new Action(() => txtPrintNumbers.Text += $"{threadName} started ...{Environment.NewLine}"));
                var numbers = new int[10];
                for (int i = 0; i < numbers.Length; i++)
                {
                    Invoke(new Action(() => txtPrintNumbers.Text += $"Operation {i + 1} Passed.{Environment.NewLine}"));
                    Thread.Sleep(200);
                }

            }
            finally
            {
                Monitor.Exit(threadLock);
            }
        }

        public void UpdateTextBoxPrintNumbers(string text)
        {
            Invoke(new Action(() => txtPrintNumbers.Text += text)); 
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

    [Synchronization]
    public class Printer : ContextBoundObject
    {
        public ConcurencyThreadForm Form;
        
        public void PrintNumbers()
        {
            string threadName = Thread.CurrentThread.Name;
            Form.UpdateTextBoxPrintNumbers($"{threadName} started ...{Environment.NewLine}");
            var numbers = new int[10];
            for (int i = 0; i < numbers.Length; i++)
            {
                Form.UpdateTextBoxPrintNumbers($"Operation {i + 1} Passed.{Environment.NewLine}");
                Thread.Sleep(200);
            }
        }
    }
}
