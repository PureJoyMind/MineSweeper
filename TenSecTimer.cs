using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeper
{
    public partial class TenSecTimer : Form
    {
        private int interval;
        public TenSecTimer()
        {
            InitializeComponent();
            timer1.Interval = 100;
            var time = "00.0";
            textBox1.Text = time;
            timer1.Start();
            interval = 10;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var current = double.Parse(textBox1.Text) * 10 + 1;
            current /= 10;
            var Fixed = current.ToString();
            if (!Fixed.Contains("."))
            {
                Fixed += ".0";
            }

            for (int i = 0; i < 4 - Fixed.IndexOf("."); i++)
            {
                Fixed = "0" + Fixed;
            }
            textBox1.Text = Fixed;

            if (Math.Round(current * 10) % (interval * 10) == 0)
            {
                notifyIcon1.Visible = true;
                notifyIcon1.BalloonTipText = current + @" seconds has passed";
                notifyIcon1.ShowBalloonTip(500);
            }
        }
    }
}
