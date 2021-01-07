using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sorszam = listBox1.SelectedIndex;
            listBox1.Items.RemoveAt(sorszam);        
            //ki KELL választani a törlendő elemet
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            //minden elemet töröl
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
            //ha nem választunk ki elemet, nem történik semmi
        }
    }
}
