using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Calculator : MetroFramework.Forms.MetroForm
    {
        decimal displayValue = 0, operant1 = 0, operant2 = 0, result = 0, temp = 0;       
        char optr = '#';
        bool flag = false;
        public Calculator()
        {
            InitializeComponent();
            txtDisplay.Text = "0";
        }
           
        private void btnOne_Click(object sender, EventArgs e)
        {
            displayValue = Convert.ToDecimal(txtDisplay.Text);
            if (displayValue == 0)
            {
                txtDisplay.Text = btnOne.Text;
            }
            else
            {
                txtDisplay.Text += btnOne.Text;
            }

        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            displayValue = Convert.ToDecimal(txtDisplay.Text);
            if (displayValue == 0)
            {
                txtDisplay.Text = btnTwo.Text;
            }
            else
            {
                txtDisplay.Text += btnTwo.Text;
            }

        }   

        private void btnThree_Click(object sender, EventArgs e)
        {
            displayValue = Convert.ToDecimal(txtDisplay.Text);
            if (displayValue == 0)
            {
                txtDisplay.Text = btnThree.Text;
            }
            else
            {
                txtDisplay.Text += btnThree.Text;
            }

        }

        private void btnFour_Click(object sender, EventArgs e)
        {

            displayValue = Convert.ToDecimal(txtDisplay.Text);
            if (displayValue == 0)
            {
                txtDisplay.Text = btnFour.Text;
            }
            else
            {
                txtDisplay.Text += btnFour.Text;
            }

        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            displayValue = Convert.ToDecimal(txtDisplay.Text);
            if (displayValue == 0)
            {
                txtDisplay.Text = btnFive.Text;
            }
            else
            {
                txtDisplay.Text += btnFive.Text;
            }

        }
        
        private void btnSix_Click(object sender, EventArgs e)
        {
            displayValue = Convert.ToDecimal(txtDisplay.Text);
            if (displayValue == 0)
            {
                txtDisplay.Text = btnSix.Text;
            }
            else
            {
                txtDisplay.Text += btnSix.Text;
            }

        }
       
        private void btnSeven_Click(object sender, EventArgs e)
        {
            displayValue = Convert.ToDecimal(txtDisplay.Text);
            if (displayValue == 0)
            {
                txtDisplay.Text = btnSeven.Text;
            }
            else
            {
                txtDisplay.Text += btnSeven.Text;
            }

        }
        
        private void btnEight_Click(object sender, EventArgs e)
        {
            displayValue = Convert.ToDecimal(txtDisplay.Text);
            if (displayValue == 0)
            {
                txtDisplay.Text = btnEight.Text;
            }
            else
            {
                txtDisplay.Text += btnEight.Text;
            }

        }
        
        private void btnNine_Click(object sender, EventArgs e)
        {
            displayValue = Convert.ToDecimal(txtDisplay.Text);
            if (displayValue == 0)
            {
                txtDisplay.Text = btnNine.Text;
            }
            else
            {
                txtDisplay.Text += btnNine.Text;
            }

        }
        
        private void btnZero_Click(object sender, EventArgs e)
        {
            displayValue = Convert.ToDecimal(txtDisplay.Text);
            if (displayValue == 0)
            {
                txtDisplay.Text = btnZero.Text;
            }
            else
            {
                txtDisplay.Text += btnZero.Text;
            }

        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (!txtDisplay.Text.Contains("."))
            {
                txtDisplay.Text += btnDot.Text;
            }

        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            operant2 = Convert.ToDecimal(txtDisplay.Text);
            switch (optr)
            {
                case '+':
                    {
                        if (!flag)
                        {
                            result = operant1 + operant2;
                            operant1 = result;
                            temp = operant2;
                            flag = true;
                        }
                        else
                        {
                            result = operant1 + temp;
                            operant1 = result;
                        }
                        txtDisplay.Text = Convert.ToString(result);
                        break;
                    }
                case '-':
                    {
                        if (!flag)
                        {
                            result = operant1 - operant2;
                            operant1 = result;
                            temp = operant2;
                            flag = true;
                        }
                        else
                        {
                            result = operant1 - temp;
                            operant1 = result;
                        }

                        txtDisplay.Text = Convert.ToString(result);
                        break;
                    }
                case '*':
                    {
                        if (!flag)
                        {
                            result = operant1 * operant2;
                            operant1 = result;
                            temp = operant2;
                            flag = true;
                        }
                        else
                        {
                            result = operant1 * temp;
                            operant1 = result;
                        }
                        txtDisplay.Text = Convert.ToString(result);
                        break;
                    }
                case '/':
                    {
                        if (!flag)
                        {
                            result = operant1 / operant2;
                            operant1 = result;
                            temp = operant2;
                            flag = true;
                        }
                        else
                        {
                            result = operant1 / temp;
                            operant1 = result;
                        }
                        txtDisplay.Text = Convert.ToString(result);
                        break;
                    }
                default:
                    break;
            }
            //displayValue = 0;
            //operant1 = 0;
            //operant2 = 0;
            //optr = '#';

        }
              
        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (optr != '+')
            {
                operant1 = Convert.ToDecimal(txtDisplay.Text);
            }
            else
            {
                operant1 += Convert.ToDecimal(txtDisplay.Text);
            }
            optr = '+';
            txtDisplay.Text = "0";

        }      
        private void btnSubstract_Click(object sender, EventArgs e)
        {
            if (optr != '-')
            {
                operant1 = Convert.ToDecimal(txtDisplay.Text);
            }
            else
            {
                operant1 -= Convert.ToDecimal(txtDisplay.Text);
            }
            optr = '-';
            txtDisplay.Text = "0";

        }        
        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (optr != '*')
            {
                operant1 = Convert.ToDecimal(txtDisplay.Text);
            }
            else
            {
                operant1 *= Convert.ToDecimal(txtDisplay.Text);
            }
            optr = '*';
            txtDisplay.Text = "0";

        }       
        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (optr != '/')
            {
                operant1 = Convert.ToDecimal(txtDisplay.Text);
            }
            else
            {
                operant1 /= Convert.ToDecimal(txtDisplay.Text);
            }
            optr = '/';
            txtDisplay.Text = "0";

        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            displayValue = Convert.ToDecimal(txtDisplay.Text);
            if (displayValue == 0)
            {
                txtDisplay.Text = "0";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
                txtDisplay.Text = txtDisplay.Text == "" ? "0" : txtDisplay.Text;
            }

        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            displayValue = 0;
            operant1 = 0;
            operant2 = 0;
            optr = '#';
            flag = false;

        }
        private void btnInverse_Click(object sender, EventArgs e)
        {

            result = 1 / Convert.ToDecimal(txtDisplay.Text);
            txtDisplay.Text = Convert.ToString(result);

        }
        private void btnPercent_Click(object sender, EventArgs e)
        {
            operant2 = Convert.ToDecimal(txtDisplay.Text);
            switch (optr)
            {
                case '+':
                    {
                        result = operant1 + (operant1 * operant2 / 100);
                        txtDisplay.Text = Convert.ToString(result);
                        break;
                    }
                case '-':
                    {
                        result = operant1 - (operant1 * operant2 / 100);
                        txtDisplay.Text = Convert.ToString(result);
                        break;
                    }
                case '*':
                    {
                        result = operant1 * operant2 / 100;
                        txtDisplay.Text = Convert.ToString(result);
                        break;
                    }
                case '/':
                    {
                        result = operant2 / operant1 * 100;
                        txtDisplay.Text = Convert.ToString(result);
                        break;
                    }
                default:
                    break;
            }
            displayValue = 0;
            operant1 = 0;
            operant2 = 0;
            optr = '#';

        }




    }
}
