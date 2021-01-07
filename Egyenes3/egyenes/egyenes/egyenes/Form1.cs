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
        int meredek = 1, emel = 0;
       
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
            meredek = Convert.ToInt32(m.Value);
            emel= Convert.ToInt32(b.Value);
            g.DrawLine(toll, 0,250+ 250 * meredek-emel*10, 500, 250 - (250 * meredek) - emel * 10);
        }

        private void b_ValueChanged(object sender, EventArgs e)
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
