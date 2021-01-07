using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        double a;
        // double b=0;
        // double c;
        char op;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void b1_Click(object sender, EventArgs e)
        {
            if (eredm.Text=="0")
            {
                eredm.Text = "1";
            }
            else
            {
                eredm.Text = eredm.Text + "1";
            }
        }

        private void b2_Click(object sender, EventArgs e)
        {
            if (eredm.Text == "0")
            {
                eredm.Text = "2";
            }
            else
            {
                eredm.Text = eredm.Text+"2";
            }
        }

        private void b3_Click(object sender, EventArgs e)
        {
            if (eredm.Text == "0")
            {
                eredm.Text = "3";
            }
            else
            {
                eredm.Text = eredm.Text+"3";
            }
        }

        private void b4_Click(object sender, EventArgs e)
        {
            if (eredm.Text == "0")
            {
                eredm.Text = "4";
            }
            else
            {
                eredm.Text = eredm.Text+"4";
            }
        }

        private void b5_Click(object sender, EventArgs e)
        {
            if (eredm.Text == "0")
            {
                eredm.Text = "5";
            }
            else
            {
                eredm.Text = eredm.Text+"5";
            }
        }

        private void b6_Click(object sender, EventArgs e)
        {
            if (eredm.Text == "0")
            {
                eredm.Text = "6";
            }
            else
            {
                eredm.Text = eredm.Text + "6";
            }
        }

        private void b7_Click(object sender, EventArgs e)
        {
            if (eredm.Text == "0")
            {
                eredm.Text = "7";
            }
            else
            {
                eredm.Text = eredm.Text + "7";
            }
        }

        private void b8_Click(object sender, EventArgs e)
        {
            if (eredm.Text == "0")
            {
                eredm.Text = "8";
            }
            else
            {
                eredm.Text = eredm.Text + "8";
            }
        }

        private void b9_Click(object sender, EventArgs e)
        {
            if (eredm.Text == "0")
            {
                eredm.Text = "9";
            }
            else
            {
                eredm.Text = eredm.Text + "9";
            }
        }

        private void bpont_Click(object sender, EventArgs e)
        {
            eredm.Text = eredm.Text + ",";
        }

        private void b0_Click(object sender, EventArgs e)
        {
            eredm.Text = eredm.Text + "0";
        }

        private void btorol_Click(object sender, EventArgs e)
        {
            eredm.Text = "0";
        }

        private void bosszead_Click(object sender, EventArgs e)
        {
            a=double.Parse(eredm.Text);
            eredm.Text = "0";
            op = '+';
        }

        private void bkivon_Click(object sender, EventArgs e)
        {
            a = double.Parse(eredm.Text);
            eredm.Text = "0";
            op = '-';
            /* if (op == '-')
            {
                c = a - b;
                eredm.Text = Convert.ToString(c);
                a = c;
            } */
        }

        private void bszoroz_Click(object sender, EventArgs e)
        {
            a = double.Parse(eredm.Text);
            eredm.Text = "0";
            op = '*';
            /* if (op == '*')
            {
                c = a * b;
                eredm.Text = Convert.ToString(c);
                a = c;
            } */
        }

        private void boszt_Click(object sender, EventArgs e)
        {
            a = double.Parse(eredm.Text);
            eredm.Text = "0";
            op = '/';
            /* try
            {
                if (op == '/')
                {
                    c = a + b;
                    eredm.Text = Convert.ToString(c);
                    a = c;
                }
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Nullával nem osztunk!");
            } */
        }

        private void begyenlo_Click(object sender, EventArgs e)
        {
            double b;
            double c;
            b = double.Parse(eredm.Text);
            switch (op)
            {
                case '+':
                    c = a + b;
                    eredm.Text = Convert.ToString(c);
                    a = c;
                    break;
                case '-':
                    c = a - b;
                    eredm.Text = Convert.ToString(c);
                    a = c;
                    break;
                case '*':
                    c = a * b;
                    eredm.Text = Convert.ToString(c);
                    a = c;
                    break;
                case '/':
                    if (b!=0)
                    {
                        c = a / b;
                        eredm.Text = Convert.ToString(c);
                        a = c;
                    }
                    else
                    {
                        MessageBox.Show("Nullával nem osztunk!");
                    }
                    break;
                default:
                    break;
            }
        }

        private void eredm_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
