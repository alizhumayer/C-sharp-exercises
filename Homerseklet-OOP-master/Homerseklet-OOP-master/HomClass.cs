using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homerseklet
{
    class HomClass
    {
        private string nev;
        private int kHom;
        private int maxHom;
        private int minHom;

        //konstruktor
        public HomClass(string sor)
        {
            string[] d = sor.Split(';');
            nev = d[0];
            kHom = Convert.ToInt32(d[1]);
            maxHom = Convert.ToInt32(d[2]);
            minHom = kHom - (maxHom - kHom);
        }

        public string Nev { get => nev; set => nev = value; }
        public int KHom { get => kHom; set => kHom = value; }
        public int MaxHom { get => maxHom; set => maxHom = value; }
        public int MinHom { get => minHom; set => minHom = value; }
    }
}
