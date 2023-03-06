using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wizulane_Laby_1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            InitTimer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            startTime = DateTime.Now;
            timer1.Start();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
        System.Windows.Forms.Timer timer1;
        DateTime startTime;
        public void InitTimer()
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(Timer1_Tick);
            timer1.Interval = 100; // in miliseconds
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan duration = DateTime.Now - startTime;
            DateTime time = DateTime.MinValue.Add(duration);
            TimerLabel.Text = duration.ToString(@"dd\.hh\:mm\:ss\:ff");
        }

    }
}
