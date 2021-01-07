using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _161125_utod
{
    class Teglalap : Negyzet
    {
        protected int b;

        public Teglalap(int ax,int ay,int aa,int ab) : base (ax,ay,aa)
        {
            b = ab;
        }
        public new void Rajzol(Graphics g)
        {
            Pen p = new Pen(Color.Black, 2);
            g.DrawRectangle(p, x, y, a, b);

        }

    }
}
