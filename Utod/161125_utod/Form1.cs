using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _161125_utod
{
    public partial class Form1 : Form
    {
        Graphics g;
        Bitmap bmp;

        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bmp);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            l_x.Text = "X:";
            l_y.Text = "Y:";
            l_r1.Text = "r1:";
            l_r2.Text = "";
            l_cx.Text = "";
            l_cy.Text = "";
        }

        private void btn_torol_Click(object sender, EventArgs e)
        {
            g.Clear(Color.Aquamarine);
            pictureBox1.Image = bmp;
        }

        private void btn_rajzol_Click(object sender, EventArgs e)
        {
            int x = (int)num_x.Value;
            int y = (int)num_x.Value;
            int r1 = (int)num_r.Value;
            int r2 = (int)num_rr.Value;
            int cx = (int)num_cx.Value;
            int cy = (int)num_cy.Value;

            if (radioButton1.Checked)
            {
                Kor kor = new Kor(x, y, r1);
                kor.Rajzol(g);
            }
            else if(radioButton2.Checked)
            {
                Ellipszis ell = new Ellipszis(x, y, r1, r2);
                ell.Rajzol(g);
            }
            else if (radioButton3.Checked)
            {
                Negyzet negyzet = new Negyzet(x, y, r1);
                negyzet.Rajzol(g);
            }
            else if (radioButton4.Checked)
            {
                Teglalap teglalap = new Teglalap(x, y, r1, r2);
                teglalap.Rajzol(g);
            }
            else
            {
                Haromszog haromszog = new Haromszog(x, y, r1, r2, cx, cy);
                haromszog.Rajzol(g);
            }
            
            pictureBox1.Image = bmp;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            num_rr.Enabled = radioButton2.Checked;
            l_x.Text = "X:";
            l_y.Text = "Y:";
            l_r1.Text = "r1:";
            l_r2.Text = "r2";
            l_cx.Text = "";
            l_cy.Text = "";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            num_rr.Enabled = radioButton4.Checked;
            l_x.Text = "X:";
            l_y.Text = "Y:";
            l_r1.Text = "a:";
            l_r2.Text = "b:";
            l_cx.Text = "";
            l_cy.Text = "";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            l_x.Text = "X:";
            l_y.Text = "Y:";
            l_r1.Text = "r1:";
            l_r2.Text = "";
            l_cx.Text = "";
            l_cy.Text = "";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            l_x.Text = "X:";
            l_y.Text = "Y:";
            l_r1.Text = "a:";
            l_r2.Text = "";
            l_cx.Text = "";
            l_cy.Text = "";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            num_rr.Enabled = radioButton5.Checked;
            num_cx.Enabled = radioButton5.Checked;
            num_cy.Enabled = radioButton5.Checked;
            l_x.Text = "ax:";
            l_y.Text = "ay:";
            l_r1.Text = "bx:";
            l_r2.Text = "by:";
            l_cx.Text = "cx:";
            l_cy.Text = "cy:";
        }
    }
    
}
