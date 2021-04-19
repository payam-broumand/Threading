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
    public partial class TimerForm : Form
    {
        private static System.Threading.Timer timer;
        public TimerForm()
        {
            InitializeComponent();
            lblTimer.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnStartTimer_Click(object sender, EventArgs e)
        {
            System.Threading.TimerCallback callback = new System.Threading.TimerCallback(CallBackDelegate);
            timer = new System.Threading.Timer(callback, null, 0, 1000);
        }

        private void CallBackDelegate(object target)
        {
            Invoke(new Action(() => lblTimer.Text = DateTime.Now.ToString("HH:mm:ss")));
        }

        private void btnStopTimer_Click(object sender, EventArgs e)
        {
            timer.Dispose();
            lblTimer.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
