using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace szakasz
{
    public partial class Form1 : Form
    {
        float x = 500, y = 500;
        float x1 = -4, y1 = 5, x2 = 6, y2 = -1,x3,y3;
        string felezopont="";

        private void a1_ValueChanged(object sender, EventArgs e)
        {
            Invalidate();
            Update();
        }

        private void a2_ValueChanged(object sender, EventArgs e)
        {
            Invalidate();
            Update();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            Invalidate();
            Update();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Invalidate();
            Update();
        }

        Pen toll = new Pen(Color.Red, 1);
        int i;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            for (i = 0; i < x; i += 10)
            {
                if(i==250)
                {
                    toll = new Pen(Color.Blue, 3);
                }
                else
                {
                    toll = new Pen(Color.Red, 1);
                }
                g.DrawLine(toll, i, 0, i, y);
                g.DrawLine(toll, 0, i, x, i);

            }
            x1 = Convert.ToInt32(a1.Value);
            y1 = Convert.ToInt32(a2.Value);
            x2 = Convert.ToInt32(b1.Value);
            y2 = Convert.ToInt32(b2.Value);
            x3 = (x1 + x2) / 2;
            y3 = (y1 + y2) / 2;
            toll = new Pen(Color.Green, 3);
            g.DrawLine(toll, 250+x1*10, 250-y1*10, 250 + x2 * 10, 250 - y2 * 10);
            toll = new Pen(Color.IndianRed,3);
            g.DrawEllipse(toll, 250 + x1 * 10 -5, 250 - y1 * 10-5 , 10, 10);
            g.DrawEllipse(toll, 250 + x2 * 10 - 5, 250 - y2 * 10 - 5, 10, 10);
            g.DrawEllipse(toll, 250 + x3 * 10 - 5, 250 - y3 * 10 - 5, 10, 10);
            SolidBrush ecset = new SolidBrush(Color.Black);
            felezopont = "";
            felezopont += "F( " + Convert.ToString(x3) + " , " + Convert.ToString(y3)+" )";
            g.DrawString("A",new Font ("Times New Roman", 16),ecset, 250 + x1 * 10 - 25, 250 - y1 * 10 - 15);
            g.DrawString("B", new Font("Times New Roman", 16), ecset, 250 + x2 * 10 - 25, 250 - y2 * 10 - 15);
            g.DrawString(felezopont, new Font("Times New Roman", 16), ecset, 250 + x3 * 10 - 25, 250 - y3 * 10 - 15);
        }
    }
}
