using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace elso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "OK";
            Form1.ActiveForm.Text = "Első programom";
            label1.Text = "Neved: ";
            
            button1.BackColor = Color.Cornsilk;

            int a = int.Parse(textBox2.Text);

            if (radioButton1.Checked) { 
                double kerulet = 4 * a;
                label3.Text = "A négyzet kerülete: " + kerulet.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int bmi = int.Parse(textBox2.Text);
            switch (bmi)
            {
                case 17: label3.Text = "sovány"; break;
                case 22: label3.Text = "normális testsúly"; break;
                case 26: label3.Text = "enyhe túlsúly"; break;
                default: label3.Text = "egyik sem a fentiek közül"; break;
            }
        }
    }
}
