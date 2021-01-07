using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _161125_utod
{
    class Kor
    {
        protected int x, y;
        protected int r;
        public Kor(int ax, int ay, int ar)
        {
            x = ax;
            y = ay;
            r = ar;
        }
        public void Rajzol(Graphics g)
        {
            Pen p = new Pen(Color.Black, 2);
            g.DrawEllipse(p, x - r, y - r, 2 * r, 2 * r);
        }
    }
}
