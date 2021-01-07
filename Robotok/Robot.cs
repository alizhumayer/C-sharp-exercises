using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Robotos
{
    class Robot
    {
        char[] sor;
        int x;
        int y;
        Graphics graphics;
        static Random r = new Random();
        int ut = r.Next(5, 10);
        int ido = r.Next(100, 1000); //0,1-1 sec
        public string Status
        {
            get;
            private set;
        }
        public Robot(char[] sor, Graphics graphics)
        {
            this.sor = sor;
            this.graphics = graphics;
            x = r.Next(10, 100);
            y = r.Next(10, 100);
            Status = "Fut";
        }
        public void Mozog()
        {
            foreach (char c in sor)
            {
                Rajzol(c);
                Thread.Sleep(ido);
            }
            Status = "Kesz";

            void Rajzol(char c)
            {
                int ex = x;
                int ey = y;
                switch (c)
                {
                    case 'E':
                        y -= ut;
                        break;
                    case 'D':
                        y += ut;
                        break;
                    case 'N':
                        x -= ut;
                        break;
                    case 'K':
                        x += ut;
                        break;
                    default:
                        throw new Exception("Rossz iránymeghatározás");
                }
                graphics.DrawLine(new Pen(Color.Blue), ex, ey, x, y);
            }
        }
    }
}
