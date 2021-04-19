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
    public partial class AsyncForm : Form
    {
        public AsyncForm()
        {
            InitializeComponent();
            lblMessage.ForeColor = Color.Red;
            lblMessage.Text = "Press Start Process";
        }

        private void btnStartProcess_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "Waiting ...";

            // call task method without await keyword
            Task.Run(() =>
            {
                Task<string> task = ProcessListAsync();
                task.Wait();
                Invoke(new Action(() =>
                {
                    lblMessage.ForeColor = Color.ForestGreen;
                    lblMessage.Text = task.Result;
                }));
            });
        }

        private Task<string> ProcessListAsync()
        {

            // task.factory.startnew
            return Task.Factory.StartNew(() =>
            {
                int[] jobs = new int[4];
                for (int index = 0; index < jobs.Length; index++)
                {
                    Invoke(new Action(() => listProcess.Items.Add($"Process number {index + 1} has completed")));
                    System.Threading.Thread.Sleep(1000);
                }
                return "Process List Completed !!";
            });
        }
    }
}
