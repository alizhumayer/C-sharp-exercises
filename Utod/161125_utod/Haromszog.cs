using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _161125_utod
{
    class Haromszog
    {
        protected int ax, ay, bx, by, cx, cy;
        public Haromszog(int aax,int aay,int abx,int aby,int acx,int acy)
        {
            ax = aax;
            ay = aay;
            bx = abx;
            by = aby;
            cx = acx;
            cy = acy;            
        }
        public void Rajzol(Graphics g)
        {
            Pen p = new Pen(Color.Black, 2);
            //Point a = new Point(ax, ay);
            //Point b = new Point(bx, by);
            //Point c = new Point(cx, cy);
            Point[] pontok = new Point[3];
            pontok[0].X = ax;
            pontok[0].Y = ay;
            pontok[1].X = bx;
            pontok[1].Y = by;
            pontok[2].X = cx;
            pontok[2].Y = cy;
            g.DrawPolygon(p, pontok);
        }

    }
}
