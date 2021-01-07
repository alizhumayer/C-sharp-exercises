using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _161125_utod
{
    class Negyzet
    {
        protected int x, y;
        protected int a;

        public Negyzet(int ax,int ay,int aa)
        {
            x = ax;
            y = ay;
            a = aa;
        }
        public void Rajzol(Graphics g)
        {
            Pen p = new Pen(Color.Black, 2);
            g.DrawRectangle(p, x, y, a, a);
        }

    }
}
