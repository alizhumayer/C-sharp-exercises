using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tortek_osztaly
{
    class Tortek
    {
        int nevezo, szamlalo,legnOszto,legkTobbszoros;


        public Tortek()
        {
            szamlalo = 0;
            nevezo = 1;
            
        }
        public int getNevezo
        {
            get
            {
                return nevezo;
            }
        }
        public int getSzamlalo
        {
            get
            {
                return szamlalo;
            }
        }

        public Tortek (int szam,int nev)
        {
            szamlalo = szam;
            nevezo = nev;
            this.legnko();
            szamlalo = szamlalo / legnOszto;
            nevezo = nevezo / legnOszto;

        }

        public int legnko()
        {
            int a = szamlalo;
            int b = nevezo;
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a %= b;
                else
                    b %= a;
            }

            if (a == 0)
            {
                legnOszto = b;
            }
            else
            {
                legnOszto = a;
            }
            return legnOszto;
        }

        public int legk_tobbsz(Tortek a, Tortek b)
        {
            int i = 2;
            bool jo = false;
            if (a.nevezo>b.nevezo)
            {
                
                do
                {
                    if (a.nevezo % (b.nevezo * i)==0)
                    {
                        legkTobbszoros = b.nevezo * i;
                        jo = true;
                    }
                    else
                    {
                        i++;
                    } 
                    
                } while (!jo);
            }
            else if (b.nevezo > a.nevezo)
            {
                do
                {
                    if (b.nevezo % (a.nevezo * i) == 0)
                    {
                        legkTobbszoros = a.nevezo * i;
                        jo = true;
                    }
                    else
                    {
                        i++;
                    }

                } while (!jo);
            }
            else
            {
                legkTobbszoros = szamlalo;
            }
            return legkTobbszoros;
        }
       public double tizedes()
        {
            return (double)szamlalo / nevezo;
        }
        public string osszead(int sz1,int sz2, int kn)
        {
            string osszeg = (sz1 + sz2) + "/" + (kn);
            return osszeg;

        }
        public string kivon(int sz1, int sz2, int kn)
        {
            string osszeg = (sz1 - sz2) + "/" + (kn);
            return osszeg;
        }
        public string oszt(Tortek a, Tortek b)
        {
            Tortek temp = new Tortek((a.szamlalo * b.nevezo), (a.nevezo * b.szamlalo));       
            string osszeg =temp.getSzamlalo + "/" + temp.getNevezo;
            return osszeg;
        }
        public string szoroz(Tortek a, Tortek b)
        {
            Tortek temp = new Tortek((a.szamlalo * b.szamlalo), (a.nevezo * b.nevezo));
            string osszeg = temp.getSzamlalo + "/" + temp.getNevezo;
            return osszeg;
        }
    }
}
