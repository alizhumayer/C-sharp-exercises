using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace masodfoku_egyenlet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //double a, b, c, d, x1, x2;

            //a = Convert.ToDouble(textBox1.Text);
            //b = Convert.ToDouble(textBox2.Text);
            //c = Convert.ToDouble(textBox3.Text);

            //if (a==0)
            //{
            //    l_hiba.Text = "Ez nem másodfokú egyenlet";
            //}
            //d = (b * b) - 4 * a * c;
            //if (d<0)
            //{
            //    l_hiba.Text = "Az egyenletnek nincs megoldása";
            //}
            //else if(d==0)
            //{
            //    x1 = ((-1 * b) + Math.Sqrt(d)) / 2 * a;
            //    x2 = ((-1 * b) - Math.Sqrt(d)) / 2 * a;
            //    l_x1.Text = Convert.ToString(x1);
            //    l_x2.Text = Convert.ToString(x2);
            //}
            //else
            //{
            //    x1 = ((-1 * b) + Math.Sqrt(d)) / 2 * a;
            //    x2 = ((-1 * b) - Math.Sqrt(d)) / 2 * a;
            //    l_x1.Text = Convert.ToString(x1);
            //    l_x2.Text = Convert.ToString(x2);
            //}


            double a, b, c;
            a = b = c = 0;
            if (Bekeres(ref a, ref b, ref c)) ;
            {
                if (a != 0)
                {
                    if (Math.Pow(b, 2) - 4 * a * c >= 0)
                    {
                        MessageBox.Show("x1 = " + ((-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a)).ToString() +
                           "\n" + "x2 = " + ((-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a)).ToString());
                    }
                    else
                    {
                        MessageBox.Show("Nincs megoldás");
                    }
                }
                else
                {
                    if (b == 0)
                    {
                        if (c == 0)
                        {
                            MessageBox.Show("Azonosság, végtelen sok megoldás");
                        }
                        else
                        {
                            MessageBox.Show("Nincs megoldás!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("x = " + -c / b);
                    }
                }


            }

        }

        public bool Bekeres(ref double a, ref double b, ref double c)
        {
            bool ok = true;
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox2.Text);
                c = Convert.ToDouble(textBox3.Text);

            }
            catch (Exception)
            {
                ok = !ok;
                MessageBox.Show("Kezd előlről!");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
            finally
            {
                //mindenképpen lefut
            }
            return ok;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            double xmax = 0, xmax2 = 0;
            int sor = 0, legnsor = 0;
            double a, b, c, x1, x2;


            if (ofd.ShowDialog().ToString() == "OK")
            {
                StreamReader olvas = File.OpenText(ofd.FileName);
                string[] darabolt;
                while (!olvas.EndOfStream)
                {
                    darabolt = olvas.ReadLine().Split(',');
                    a = Convert.ToDouble(darabolt[0]);
                    b = Convert.ToDouble(darabolt[1]);
                    c = Convert.ToDouble(darabolt[2]);
                    sor++;
                    if (a != 0)
                    {
                        if (Math.Pow(b, 2) - 4 * a * c >= 0)
                        {
                            x1 = ((-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a));
                            x2 = ((-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a));
                            if (x1 < x2)
                            {
                                xmax2 = x2;

                            }
                            else
                            {
                                xmax2 = x1;
                            }
                        }                        
                    }
                    else
                    {
                        if (b != 0)
                        {                            
                            xmax2 =-c / b;
                        }
                    }
                    if (xmax==0)
                    {
                        xmax = xmax2;    
                    }
                    if (xmax2>xmax)
                    {
                        xmax = xmax2;
                        legnsor = sor;
                    }

                }
                MessageBox.Show("Legnagyobb x = " + xmax +"\nA sor száma: " + legnsor);
            }
        }
    }
}
