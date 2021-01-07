using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bdc_kektura
{
    class Kektura
    {
        private string kiindulo;
        private string vegpont;
        private double hossz;
        private int emelkedes;
        private int lejtes;
        private string pecset; //eredetileg karakter!

        //konstruktor
        public Kektura(string ki, string veg, double h, int emelk, int lejt, string p)
        {
            this.kiindulo = ki;
            this.vegpont = veg;
            this.hossz = h;
            this.emelkedes = emelk;
            this.lejtes = lejt;
            this.pecset = p;
        }

        public double getHossz
        {
            get { return hossz; }
        }

        public string getKiindulo
        {
            get { return kiindulo; }
        }

        public string getVegpont
        {
            get { return vegpont; }
        }

        public int getEmelkedes
        {
            get { return emelkedes; }
        }

        public int getLejtes
        {
            get { return lejtes; }
        }

        public string getPecset
        {
            get { return pecset; }
        }


        public bool hianyosNev()
        {
            bool pHely = false;
            if (!vegpont.Contains("pecsetelohely") && pecset == "i")
            {
                pHely = true;
            }
            return pHely;
        }

    }
}
