using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace szinkevero
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void meretScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            negyzet.Width = meretScrollBar.Value;
            negyzet.Height = meretScrollBar.Value;
            negyzetoldal.Text = meretScrollBar.Value.ToString();
        }

        private void pirosScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            negyzet.BackColor = Color.FromArgb(pirosScrollBar.Value, zoldScrollBar.Value, kekScrollBar.Value);
            piros.Text = Convert.ToString(pirosScrollBar.Value);
        }

        private void zoldScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            negyzet.BackColor = Color.FromArgb(pirosScrollBar.Value, zoldScrollBar.Value, kekScrollBar.Value);
            zold.Text = Convert.ToString(zoldScrollBar.Value);
        }

        private void kekScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            negyzet.BackColor = Color.FromArgb(pirosScrollBar.Value, zoldScrollBar.Value, kekScrollBar.Value);
            kek.Text = Convert.ToString(kekScrollBar.Value);
        }
    }
}
