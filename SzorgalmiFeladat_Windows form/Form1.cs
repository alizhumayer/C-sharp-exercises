using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gyakorlas2
{
    public partial class Form1 : Form
    {
        Graphics g;Pen p; Rectangle kor; int induloX; int induloY;double ertek1; double ertek2;int kepMagassag;int kepSzelesseg;
        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
            p = new Pen(Color.Black);
            induloX = 450;
            induloY = 150;
            kepMagassag= Screen.PrimaryScreen.Bounds.Height;
            kepSzelesseg= Screen.PrimaryScreen.Bounds.Width;
            
            kor = new Rectangle(induloX, induloY, 20, 20);
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            label1.Text = "Első  érték:";
            textBox2.Enabled = true;
            try
            {
                this.ertek1 = Convert.ToDouble(textBox1.Text);
                if (String.IsNullOrEmpty(textBox2.Text))
                {
                    korSzamitas(1);
                }
                else if(textBox1.Text==textBox2.Text)
                    {
                    g.DrawRectangle(p, induloX, induloY, Convert.ToInt32(ertek1), Convert.ToInt32(ertek2));
                    label4.Text = "A kocka kerülete= " + kockaKeruletSzamolo() + "m";
                    label5.Text = "A kocka területe= " + kockaTeruletSzamolo() + "m2";
                    label3.Text = "";
                }
                else if (textBox1.Text != textBox2.Text)
                {
                    g.DrawRectangle(p, induloX, induloY, Convert.ToInt32(ertek1), Convert.ToInt32(ertek2));
                    label4.Text = "A téglalap kerülete= " + teglalapKeruletSzamolo() + "m";
                    label5.Text = "A téglalap területe= " + teglalapTeruletSzamolo() + "m2";
                    label4.Text = Convert.ToString(Console.WindowWidth);
                    label3.Text = "";
                }

            }
            catch
            {
                if (!String.IsNullOrEmpty(textBox1.Text))
                {
                    label1.Text += "(Hibás adat!)";
                    textBox2.Enabled = false;
                }
                else
                    korSzamitas(2);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            label2.Text = "Második érték:";
            textBox1.Enabled = true;
            try
            {
                g.Clear(Color.White);
                this.ertek2 = Convert.ToDouble(textBox2.Text);
                if (String.IsNullOrEmpty(textBox1.Text))
                {
                    korSzamitas(2);
                }
                else
                {
                    if (textBox1.Text != textBox2.Text)
                    {

                        g.DrawRectangle(p, induloX, induloY, Convert.ToInt32(ertek1), Convert.ToInt32(ertek2));
                        label4.Text = "A téglalap kerülete= " + teglalapKeruletSzamolo() + "m";
                        label5.Text = "A téglalap területe= " + teglalapTeruletSzamolo() + "m2";
                        label3.Text = "";
                    }
                    else
                    {
                        g.DrawRectangle(p, induloX, induloY, Convert.ToInt32(ertek1), Convert.ToInt32(ertek2));
                        label4.Text = "A kocka kerülete= " + kockaKeruletSzamolo() + "m";
                        label5.Text = "A kocka területe= " + kockaTeruletSzamolo() + "m2";
                        label3.Text = "";
                    }
                }
            }
            catch
            {
                if (!String.IsNullOrEmpty(textBox2.Text)) { 
                label2.Text += "(Hibás adat!)";
                textBox1.Enabled = false;
            }
                else
                    korSzamitas(1);
            }
        }
        private double teglalapKeruletSzamolo()
        {
            double kerulet = 2 * ertek1 + 2 * ertek2;
            return kerulet;
        }

        private double teglalapTeruletSzamolo()
        {
            double terulet = ertek1 * ertek2;
            return terulet;
        }

        private double kockaKeruletSzamolo()
        {
            double terulet = 4*ertek1;
            return terulet;
        }

        private double kockaTeruletSzamolo()
        {
            double terulet = ertek1 * ertek1;
            return terulet;
        }

        private void korSzamitas(int melyik)
        {
            int korhoz;
            double sugar;
            if (melyik == 1)
            {
                korhoz = Convert.ToInt32(Math.Round(ertek1));
                sugar = ertek1 / 2;
            }
            else
            {
                korhoz = Convert.ToInt32(Math.Round(ertek2));
                sugar = ertek2 / 2;
            }
            kor.Height = korhoz;
            kor.Width = korhoz;
            g.DrawEllipse(p, kor);
            g.DrawLine(p, induloX + korhoz / 2, induloY + korhoz / 2, induloX + korhoz, induloY + korhoz / 2);
            label3.Text = "A kör sugara: " + Convert.ToString(sugar);
            label4.Text = "A kör kerülete= " + Convert.ToString(Math.Round(2 * sugar * Math.PI));
            label5.Text = "A kör területe= " + Convert.ToString(Math.Round(sugar * sugar * Math.PI));
        }
    }
}
