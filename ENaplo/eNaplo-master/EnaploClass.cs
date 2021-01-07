using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enaplo
{
    class EnaploClass
    {
        private string nev;
        private int otos;
        private int negyes;
        private int harmas;
        private int kettes;
        private int egyes;
        private int osszPont;

        //konstruktor
        public EnaploClass(string sor)
        {
            string[] d = sor.Split('*');
            nev = d[0];
            otos = Convert.ToInt32(d[1]);
            negyes = Convert.ToInt32(d[2]);
            harmas = Convert.ToInt32(d[3]);
            kettes = Convert.ToInt32(d[4]);
            egyes = Convert.ToInt32(d[5]);
            osszPont = otos * 3 + negyes * 2 + kettes * -1 + egyes * -2;
        }

        //GET és a SET
        public string Nev { get => nev; set => nev = value; }
        public int Otos { get => otos; set => otos = value; }
        public int Negyes { get => negyes; set => negyes = value; }
        public int Harmas { get => harmas; set => harmas = value; }
        public int Kettes { get => kettes; set => kettes = value; }
        public int Egyes { get => egyes; set => egyes = value; }
        public int OsszPont { get => osszPont; set => osszPont = value; }

        //metódus
        public int osszPontSzam()
        {
            return otos * 3 + negyes * 2 + kettes * -1 + egyes * -2;
        }
    }
}
