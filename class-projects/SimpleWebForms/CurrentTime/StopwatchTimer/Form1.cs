using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StopwatchTimer
{
    public partial class fmDigitalClock : Form
    {
        //Timer t = new Timer();
        private int hour, min, sec;

        public fmDigitalClock()
        {
            InitializeComponent();
        }

        private void fmDigitalClock_Load(object sender, EventArgs e)
        {
            /* Adds the event and the event handler for the method that will 
           process the timer event to the timer. */
            //t.Tick += new EventHandler(this.timer_Tick);
           
            timer.Tick += new EventHandler(this.timer_Tick);

            timer.Start();

            // timer interval
            // sets the timer interval to 1 second
            // t.Interval = 1000;

            // start timer when form loads
            //t.Start(); // this will use timer_Tick() method

        }

        // timer eventhandler
        private void timer_Tick(object sender, EventArgs e)
        {
            // get current time
            hour = DateTime.Now.Hour;
            min = DateTime.Now.Minute;
            sec = DateTime.Now.Second;

            if (hour < 12)
            {
                lblPmAm.Text = "AM";
            }
            else
            {
                lblPmAm.Text = "PM";
            }

            // pading leading zero and update label
            if (hour > 12)
            {
                hour -= 12;
            }
            if (hour < 10)
            {
                lblHours.Text = "0" + hour;   
            }
            else
            {
                lblHours.Text = hour.ToString();
            }

            if (min < 10)
            {
                lblMinuites.Text = "0" + min;
            }
            else
            {
                lblMinuites.Text = min.ToString();
            }

            if (sec < 10)
            {
                lblSeconds.Text = "0" + sec;
            }
            else
            {
                lblSeconds.Text = sec.ToString();
            }

                 
        }

        

    }
}
