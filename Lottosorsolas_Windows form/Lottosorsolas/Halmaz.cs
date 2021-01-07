using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lottosorsolas
{
    //különálló állományok esetén a namespace-nek meg kell eggyeznie, kül. a program külön kezeli
    class Halmaz
    {
        private int n;
        private const int max = 200;
        private int[] elemek;

        public Halmaz()
            {
                n = 0;
                elemek = new int[max];
            }
        public int Elemszam
        {
            get
            {
                return n;
            }
        }
        private int talalt;


        public bool eleme_e(int elem)
        {
            int i = -1; //ha 0-t írunk, akk. a ciklus végében kell növelni az i értékét
            bool l = false; //l = logikai
            while (i<n-1 && !l)
            {
                i++;
                if (elemek[i]==elem)
                {
                    l = true;
                }               
            }
            talalt = i;
            return l;
           
        }

        public void Halmazba(int elem)
        {
            if (!eleme_e(elem) && n<max)
            {
                elemek[n++] = elem; //előbb tárolja at elemet, majd növeli egyel az n értékét (2 sorba [n] majd n++)
            }
        } 

        public void halmazbol(int elem)
        {
            if (eleme_e(elem))
            {
                elemek[talalt] = elemek[n - 1]; //az utolsó elemet rakjuk a kivenni akart helyére
                n--;                            //csökkentjük 1-el az elemek számát
            }
        }
        public string Kiir()
        {
            string s = "{";
            for (int i = 0; i < n; i++)
            {
                s += elemek[i].ToString();
                s += (i < n - 1 ? "; " : ""); //ha igaz, akk. az első feltétel(;) hajtódik végre
            }
            s += "}";
            return s;
        }

    }
}
