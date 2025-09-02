using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DailyTaskBotApp
{
    public partial class DailyTaskBot : Form
    {
        DailyTaskBotEntities context;
        EmployeeDailyReport model;
        int step = 1;

        public DailyTaskBot()
        {
            context = new DailyTaskBotEntities();
            model = new EmployeeDailyReport();
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string description = txtTaskDescription.Text;

                switch (step)
                {
                    case 1:
                        {
                            if (string.IsNullOrEmpty(description))
                            {
                                lblMessage.Text = "Please enter yesterday's task.";
                                return;
                            }
                            string userName = Environment.UserName;
                            model.EmployeeName = userName;
                            model.YesterdaysTask = txtTaskDescription.Text;
                            step = 2;

                            lblMessage.Text = "What are you doing today?";
                        }
                            break;
                    case 2:
                        {
                            if (string.IsNullOrEmpty(description))
                            {
                                lblMessage.Text = "Please enter today's task.";
                                return;
                            }
                            model.TodaysTask = txtTaskDescription.Text;
                            step = 3;

                            lblMessage.Text = "Any obstacle?";

                            btnSubmit.Text = "Submit";
                            break;
                        }
                    case 3:
                        {
                            model.Obstacle = txtTaskDescription.Text;
                            model.CreatedDate = DateTime.Now;

                            context.EmployeeDailyReports.Add(model);
                            context.SaveChanges();

                            step = 1;
                            lblMessage.Text = "What you did yesterday?";
                            btnSubmit.Text = "Next";
                            Application.Exit();
                            break;
                        }
                }
                //lblMessage.Text = string.Empty;
                txtTaskDescription.Text = string.Empty;
            }
            catch (Exception)
            {

            }

        }

        
    }
}
