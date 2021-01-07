using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace szamologep
{
    public partial class Form1 : Form
    {
        bool muvelet = true;
        bool vesszo = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += ((Button)sender).Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += ((Button)sender).Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += ((Button)sender).Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += ((Button)sender).Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += ((Button)sender).Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += ((Button)sender).Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += ((Button)sender).Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += ((Button)sender).Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += ((Button)sender).Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += ((Button)sender).Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (muvelet)
            {
                textBox1.Text += ((Button)sender).Text;
                muvelet = false;
                vesszo = true;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (muvelet)
            {
                textBox1.Text += ((Button)sender).Text;
                muvelet = false;
                vesszo = true;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (muvelet)
            {
                textBox1.Text += ((Button)sender).Text;
                muvelet = false;
                vesszo = true;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (muvelet)
            {
                textBox1.Text += ((Button)sender).Text;
                muvelet = false;
                vesszo = true;
                
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            muvelet = true;
            button11.Visible = true;
            button12.Visible = true;
            button13.Visible = true;
            button14.Visible = true;
            button15.Visible = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            muvelet = true;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
            int operandus = textBox1.Text.IndexOfAny(new char[] { '+', '-', '/', '*' });
            double x = double.Parse(textBox1.Text.Substring(0, operandus));
            double y = double.Parse(textBox1.Text.Substring(operandus+1));
            double eredmeny = 0;
            switch (textBox1.Text[operandus])
            {
                case '+':
                    eredmeny = x + y;
                    break;
                case '-':
                    eredmeny = x - y;
                    break;
                case '*':
                    eredmeny = x * y;
                    break;
                case '/':
                    if (y != 0)
                    {
                        eredmeny = x / y;
                    }
                    else
                        textBox1.Text = "0-val nem lehet osztani";
                    break;
            }
            textBox1.Text += " = " + eredmeny;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (vesszo)
            {
                textBox1.Text += ((Button)sender).Text;
                vesszo = false;
            }
        }
    }
}
