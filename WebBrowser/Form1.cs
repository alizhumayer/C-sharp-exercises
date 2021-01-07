using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _160322WebBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("www.index.hu");
            comboBox1.Items.Add("www.sg.hu");
            comboBox1.Items.Add("www.google.com");
        }

        private void btn_betolt_Click(object sender, EventArgs e)
        {
           
            if (comboBox1.Text.Contains(".hu"))
            {
                comboBox1.Items.Add(comboBox1.Text);
                webBrowser1.Navigate(comboBox1.Text);
            }
            
        }
    }
}
