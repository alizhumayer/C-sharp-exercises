using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _161125_utod
{
    class Ellipszis : Kor
    {
        protected int R;
        public Ellipszis(int ax, int ay, int ar, int aR) : base(ax, ay, ar)
        {
            R = aR;
        }
        public new void Rajzol(Graphics g)
        {
            Pen p = new Pen(Color.Black, 2);
            g.DrawEllipse(p, x - r, y - R, 2 * r, 2 * R);
        }


    }
}
