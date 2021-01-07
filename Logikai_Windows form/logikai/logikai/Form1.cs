using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace logikai
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = !checkBox1.Checked;
            checkBox2.Checked = !checkBox2.Checked;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool l = checkBox1.Checked && checkBox2.Checked;
            MessageBox.Show("A logikai ÉS eredménye: "+l.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool logikai = checkBox1.Checked || checkBox2.Checked;
            MessageBox.Show("A logikai VAGY eredménye: " + logikai.ToString());
        }
    }
}
