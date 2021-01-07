using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kor_negyzet_k_t
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
                              
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "A négyzet oldalhossza:";
            label2.Text = "A négyzet kerülete: ";
            label3.Text = "A négyzet területe: ";


        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "A kör sugara:";
            label2.Text = "A kör kerülete: ";
            label3.Text = "A kör területe: ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" )
            {

                double adat = double.Parse(textBox1.Text);
                if (adat >= 0)
                {
                    double kerulet = 0, terulet = 0;
                    string me = " cm";
                    string to_list = " ";

                    if (radioButton1.Checked)
                    {
                        kerulet = Math.Round(4 * adat,2);
                        terulet = Math.Round(adat * adat,2);
                        
                        label2.Text = "A négyzet kerülete: " + kerulet.ToString() + me;
                        label3.Text = "A négyzet területe: " + terulet.ToString() + me + "2";
                        to_list = "A: " + adat.ToString() + me + 
                            "  K: " + kerulet.ToString() + me +
                            "  T: " + terulet.ToString() + me + "2";

                        listBox1.Items.Add(to_list);


                    }
                    else if(radioButton2.Checked)
                    {
                        kerulet = Math.Round(2 * adat * Math.PI, 2);
                        terulet = Math.Round(adat * adat * Math.PI,2);
                        

                        label2.Text = "A kör kerülete: " + kerulet.ToString() + me;
                        label3.Text = "A kör területe: " + terulet.ToString() + me + "2";

                        to_list = "r: " + adat.ToString() + me +
                            "  K: " + kerulet.ToString() + me +
                            "  T: " + terulet.ToString() + me + "2";

                        listBox1.Items.Add(to_list);
                    }
                    else
                    {
                        label4.Text = "Válassz síkidomot";
                    }
                }
                else
                {
                    label4.Text = "A szám nem lehet negítav";
                }
               

            }
            else
            {
                label4.Text = "Írj be valamit";
            }
        }
    }
}
