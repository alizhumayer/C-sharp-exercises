using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace intervallum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int alsohatar = int.Parse(textBox1.Text);
            int felsohatar = int.Parse(textBox2.Text);

            int szam = int.Parse(textBox3.Text);

            try
            {                
              if (alsohatar < felsohatar)
              {
                if (alsohatar <= szam && felsohatar >= szam)
                {
                    label4.Text = "A megadott szám benne van az intervallumban.";
                    MessageBox.Show("Benne van az intervallumban.");
                }
                else label4.Text = "A megadott szám nincs benne az intervallumban.";
              }
              else label4.Text = "Nem jó intervallumot adtál meg.";
            }
            catch (Exception)
            {
                MessageBox.Show("Nem számot adtál meg.");
                throw;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int honap = int.Parse(textBox4.Text);

            switch (honap)
            {
                case 1: label6.Text = "Január"; break;
                case 2: label6.Text = "Február"; break;
                case 3: label6.Text = "Március"; break;

                case 4: label6.Text = "Április"; break;
                case 5: label6.Text = "Május"; break;
                case 6: label6.Text = "Június"; break;

                case 7: label6.Text = "Július"; break;
                case 8: label6.Text = "Augusztus"; break;
                case 9: label6.Text = "Szeptember"; break;

                case 10: label6.Text = "Október"; break;
                case 11: label6.Text = "November"; break;
                case 12: label6.Text = "December"; break;

                default: label6.Text = "Nem megfelelő számot adtál meg.";
                    break;
            }
        }
    }
}
