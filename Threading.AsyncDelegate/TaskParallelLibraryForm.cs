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
    public partial class TaskParallelLibraryForm : Form
    {
        public TaskParallelLibraryForm()
        {
            InitializeComponent();
        }

        private void btnStartTask_Click(object sender, EventArgs e)
        {
            // create new stans of task to run action in another thread
            //Task task = new Task(CalculateAverage);
            //task.Start();

            // using task with factory method
            Task.Factory.StartNew(CalculateAverage);
        }

        private void CalculateAverage()
        {
            var numbers = Enumerable.Repeat(20, 100000000);
            int sum = 0;
            Parallel.ForEach(numbers, number =>
            {
                sum += number;
                Invoke(new Action(() => txtTaskNumbers.Text += $"{sum}{Environment.NewLine}"));
                Thread.Sleep(50);
            });

            MessageBox.Show("Average of numbers: " + (sum / numbers.Count()));
        }
    }
}
