using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleStopwatch
{
    public partial class Form1 : Form
    {
        private int min, sec, c = 0;
        bool isActive;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            isActive = false;
            min = sec = c = 0;
            timer.Stop();
            DrawTime();

        }

        private void timer_Tick(object sender, EventArgs e)
        {  
            if (isActive)
            {
                c++;
                if (c > 99)
                {
                    sec++;
                    c = 0;
                    if (sec > 59)
                    {
                        min++;
                        sec = 0;
                    }

                }
                DrawTime();
            }
        }

        private void DrawTime()
        {
            lblCs.Text = String.Format("{0:00}", c);
            lblSecond.Text = String.Format("{0:00}", sec);
            lblMin.Text = String.Format("{0:00}", min);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            isActive = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            isActive = true;
            timer.Start();

        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            isActive = false;
            timer.Stop();
        }


    }
}
