using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace egyenes
{
    public partial class Form1 : Form
    {
        float x=500, y=500;
        double m1 = 1, b1 = 0;
        double m12 = -1, b12 = 0;
        double x1, y1;
        Pen toll = new Pen(Color.Red, 1);
        int i;
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            for ( i = 0; i < x; i += 10)
            {
                if (i == 250)
                {
                     toll = new Pen(Color.Blue, 3);
                }
                else
                {
                     toll =new  Pen(Color.Red, 1);
                }
                g.DrawLine(toll, i, 0, i, y);
                g.DrawLine(toll, 0, i, x, i);
            }
            toll = new Pen(Color.Green, 3);
            m1 = Convert.ToInt32(m.Value);
            b1= Convert.ToInt32(b.Value);
            m12 = Convert.ToDouble(m2.Value);
            b12 = Convert.ToDouble(b2.Value);
            g.DrawLine(toll, 0, Convert.ToInt32(250 + 250 * m1 - b1 * 10), 500, Convert.ToInt32(250 - (250 * m1) - b1 * 10));
            toll = new Pen(Color.Aqua, 3);
            g.DrawLine(toll, 0,Convert.ToInt32(250 + 250 * m12 - b12 * 10), 500, Convert.ToInt32( 250 - (250 * m12) - b12 * 10));
            if ((m12 - m1) != 0)
            {
                x1 = (b12 - b1) / (m1 - m12);
                y1 = m1 * x1 + b1;
                label6.Text = "Metszéspont: (" + Convert.ToString(x1) + " , " + Convert.ToString(y1) + " )";
            }
            else
            {
                label6.Text = "Nincs metszéspont";
            }
        }

        private void b_ValueChanged(object sender, EventArgs e)
        {
            Invalidate();
            Update();
        }

        private void m2_ValueChanged(object sender, EventArgs e)
        {
            Invalidate();
            Update();
        }

        private void b2_ValueChanged(object sender, EventArgs e)
        {
            Invalidate();
            Update();
        }

        public Form1()
        {
            InitializeComponent();
          
           
        }

        private void m_ValueChanged(object sender, EventArgs e)
        {
            Invalidate();
            Update();
           
          
           
        }
    }
}
