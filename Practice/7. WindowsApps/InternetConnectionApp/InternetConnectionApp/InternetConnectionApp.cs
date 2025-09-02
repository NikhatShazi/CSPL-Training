using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternetConnectionApp
{
    public partial class InternetConnectionApp : MetroFramework.Forms.MetroForm
    {
        bool flag = false;
        public InternetConnectionApp()
        {
            InitializeComponent();

        }

        private void InternetConnectionApp_Load(object sender, EventArgs e)
        {
            double width = Screen.PrimaryScreen.Bounds.Width;
            int x = Convert.ToInt32(width) - this.Width - 10;
            this.SetDesktopLocation(x, 130);

            if (IsConnectionAvailable())
            {
                pcrConnection.Image = Image.FromFile("../../Images/green-tick.jpg");
            }
            else
            {
                pcrConnection.Image = Image.FromFile("../../Images/red-cross.jpg");
            }

        }
        private bool IsConnectionAvailable()
        {
            try
            {
                Ping myPing = new Ping();
                String host = "google.com";
                byte[] buffer = new byte[32];
                int timeout = 1000;
                PingOptions pingOptions = new PingOptions();
                PingReply reply = myPing.Send(host, timeout, buffer, pingOptions);
                return (reply.Status == IPStatus.Success);
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void tmrConnection_Tick(object sender, EventArgs e)
        {
            if (IsConnectionAvailable())
            {
                pcrConnection.Image = Image.FromFile("../../Images/green-tick.jpg");
                flag = true;
            }
            else
            {
                pcrConnection.Image = Image.FromFile("../../Images/red-cross.jpg");
                if (flag)
                {
                    flag = false;
                    //MessageBox.Show("Dissconected...", "Internet Connection...", MessageBoxButtons.OK, MessageBoxIcon.Stop,MessageBoxDefaultButton.Button1,MessageBoxOptions.DefaultDesktopOnly);
                }
            }

        }
    }
}
