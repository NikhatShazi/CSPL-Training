using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalWatchApp
{
    public partial class DigitalWatch : MetroFramework.Forms.MetroForm
    {
        int hh, mm, ss;
        string tt;

        public DigitalWatch()
        {
            InitializeComponent();
            hh = Convert.ToInt32(DateTime.Now.ToString("hh"));
            mm = DateTime.Now.Minute;
            ss = DateTime.Now.Second;
            tt = DateTime.Now.ToString("tt");

            DisplayTime();
        }

        private void DisplayTime()
        {
            lblHour.Text = hh.ToString("00");
            lblMinute.Text = mm.ToString("00");
            lblSecond.Text = ss.ToString("00");
            lblPeriod.Text = tt;
        }

        private void tmrSeparator_Tick(object sender, EventArgs e)
        {
            lblHMSeparator.Text = (lblHMSeparator.Text == ":") ? "" : ":";
            lblMSSeparator.Text = (lblMSSeparator.Text == ":") ? "" : ":";

        }

        private void DigitalWatch_Load(object sender, EventArgs e)
        {

            double width = Screen.PrimaryScreen.Bounds.Width;
            int x = Convert.ToInt32(width) - this.Width - 10;
            this.SetDesktopLocation(x, 10);

        }

        private void tmrWatch_Tick(object sender, EventArgs e)
        {
            ss++;
            if (ss > 59)
            {
                ss = 0;
                mm++;
                if (mm > 59)
                {
                    mm = 0;
                    hh++;
                    if (hh > 12)
                    {
                        hh = 1;
                    }
                    if (hh > 11)
                    {
                        tt = (tt == "AM") ? "PM" : "AM";
                    }
                }
            }
            DisplayTime();

        }
    }
}
