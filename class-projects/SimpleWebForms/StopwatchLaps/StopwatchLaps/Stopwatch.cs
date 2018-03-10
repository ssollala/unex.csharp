using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StopwatchLaps
{
    public partial class frmAdvancedStopwatch : Form
    {
        private Stopwatch stopwatch = new Stopwatch();

        public frmAdvancedStopwatch()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            var elapsed = new TimeSpan();
            elapsed = stopwatch.Elapsed;

            lblClock.Text = String.Format("{0:00}:{1:00}:{2:00}:{3:00}",
                Math.Floor(elapsed.TotalHours),
                Math.Floor(elapsed.TotalMinutes),
                Math.Floor(elapsed.TotalSeconds),
                (Math.Floor(elapsed.TotalMilliseconds * 0.01)));

        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            if(btnStart.Text == "Start")
            {
                timer.Start();
                stopwatch.Start();
                btnStart.Text = "Stop";
                btnReset.Enabled = false;
            }
            else
            {
                timer.Stop();
                stopwatch.Stop();
                btnStart.Text = "Start";
                btnReset.Enabled = true;
            }
        }

        private void btnLap_Click(object sender, EventArgs e)
        {
            var count = listBox1.Items.Count + 1;       // number of the lap added
            listBox1.Items.Add(count+ ".  " + lblClock.Text);


        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            stopwatch.Reset();
            lblClock.Text = "00:00:00:00";
            listBox1.Items.Clear();
           
        }
    }
}
