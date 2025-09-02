using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleWatchApp
{
    public partial class SimpleWatch : MetroFramework.Forms.MetroForm
    {
        public SimpleWatch()
        {
            InitializeComponent();
            lblTime.Text = DateTime.Now.ToString("hh : mm : ss tt");
        }

        private void tmrWatch_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh : mm : ss tt");
        }

        private void SimpleWatch_Load(object sender, EventArgs e)
        {
            double width = Screen.PrimaryScreen.Bounds.Width;
            int x = Convert.ToInt32(width) - this.Width - 10;
            this.SetDesktopLocation(x, 10);
        }
    }
}
