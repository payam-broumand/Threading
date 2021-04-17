using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Threading.AsyncDelegate
{
    public partial class TaskParallelLibraryForm : Form
    {
        CancellationTokenSource source = new CancellationTokenSource();
        public TaskParallelLibraryForm()
        {
            InitializeComponent();
            btnStopTask.Enabled = false;
        }

        private void btnStartTask_Click(object sender, EventArgs e)
        {
            source = new CancellationTokenSource();

            // create new stans of task to run action in another thread
            //Task task = new Task(CalculateAverage);
            //task.Start();

            // using task with factory method
            Task.Factory.StartNew(CalculateAverage);

            btnStopTask.Enabled = true;
            btnStartTask.Enabled = false;
        }

        private void CalculateAverage()
        {
            var numbers = Enumerable.Repeat(20, 100000000).ToArray();
            int sum = 0;
            ParallelOptions options = new ParallelOptions();
            options.CancellationToken = source.Token;
            try
            {
                //Parallel.For(0, numbers.Length, options, number =>
                //    {
                //        options.CancellationToken.ThrowIfCancellationRequested();
                //        sum += number;
                //        Invoke(new Action(() => txtTaskNumbers.Text += $"{sum}{Environment.NewLine}"));
                //        Thread.Sleep(500);
                //    });

                Parallel.ForEach(numbers, options, number =>
                {
                    options.CancellationToken.ThrowIfCancellationRequested();
                    sum += number;
                    Invoke(new Action(() => txtTaskNumbers.Text += $"{sum}{Environment.NewLine}"));
                    Thread.Sleep(500);
                });
                MessageBox.Show("Average of numbers: " + (sum / numbers.Count()));
            }
            catch (OperationCanceledException ex)
            {
                MessageBox.Show("Operation was canceled !!");
            }

        }

        private int CalculateSumOfNumbers()
        {
            var numbers = Enumerable.Repeat(20, 120000000);
            int sum = 0;
            Parallel.ForEach(numbers, number =>
            {
                sum += number;
            });

            int average = sum / numbers.Count();
            return average;
        }

        private void btnResuturnTask_Click(object sender, EventArgs e)
        {
            Task<int> task = new Task<int>(CalculateSumOfNumbers);
            task.Start();
            var average = task.Result;
            MessageBox.Show($"Average of numbers : {task.Result}");
        }

        private void btnStopTask_Click(object sender, EventArgs e)
        {
            source.Cancel();
            btnStopTask.Enabled = false;
            btnStartTask.Enabled = true;
        }
    }
}
