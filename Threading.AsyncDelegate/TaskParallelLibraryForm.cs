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
    public partial class TaskParallelLibraryForm : Form
    {
        public TaskParallelLibraryForm()
        {
            InitializeComponent();
        }

        private void btnStartTask_Click(object sender, EventArgs e)
        {
            var numbers = Enumerable.Repeat(20, 10000000);
            int sum = 0;
            //foreach (var number in numbers)
            //{
            //    sum += number;
            //}

            Parallel.ForEach(numbers, number =>
            {
                sum += number;
            });

            MessageBox.Show("Average of numbers: " + (sum / numbers.Count()));
        }
    }
}
