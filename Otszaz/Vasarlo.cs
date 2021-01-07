using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace OtszazLINQ
{
    class Vasarlo
    {
        int sorszam;
        string nev;
        int db;
        int ar;

        public int Sorszam
        {
            get => sorszam;
            private set => sorszam = value;
        }

        public string Nev
        {
            get => nev;
            private set => nev = value;
        }

        public int Db
        {
            get => db;
            set => db = value;
        }

        public int Ar
        {
            get
            {
                if (db == 1)
                    return 500;
                if (db == 2)
                    return 950;
                return 950 + (db - 2) * 400;
            }
        }

        public Vasarlo(string sorok)
        {
            string[] adatok = sorok.Split(' ');
            sorszam = int.Parse(adatok[0]);
            nev = adatok[1];
            db = int.Parse(adatok[2]);
        }
    }
}