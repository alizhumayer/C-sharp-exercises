using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ExpedicioLINQ
{
    class Expedicio
    {
        int nap;
        int ado;
        string szoveg;

        public int Nap
        {
            get => nap;
            private set => nap = value;
        }

        public int Ado
        {
            get => ado;
            private set => ado = value;
        }

        public string Szoveg
        {
            get => szoveg;
            private set => szoveg = value;
        }

        public Expedicio(string sor1, string sor2)
        {
            string[] adatok = sor1.Split(' ');
            nap = int.Parse(adatok[0]);
            ado = int.Parse(adatok[1]);
            szoveg = sor2;
        }
    }
}
