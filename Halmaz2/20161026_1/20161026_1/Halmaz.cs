using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace halmaz_oszt
{
    class Halmaz<T> where T :IComparable<T>
    {
        private int n;
        private int max = 200;
        private T[] elemek;
        public Halmaz()
        {
            n = 0;
            elemek = new T[max];

        }
        public Halmaz(int szamok)
        {
            n = 0;
            max = szamok;
            elemek = new T[max];
        }
        public int Elemszám
        {
            get
            {
                return n;
            }
        }

        private int talalt;

        public bool eleme_e(T elem)
        {
            
            bool logikai = false;
            int i = 0;
            int e = 0, u = n - 1;
            while (!logikai && e<=u)
            {
                i = (e + u) / 2;
                int x = elemek[i].CompareTo(elem);
                if (x==0)
                {
                    logikai = true;
                    talalt = i;
                }
                else
                {
                    if (x<0)
                    {
                        e = i + 1;
                    }
                    else
                    {
                        u = i - 1;
                    }
                }
            }

            
            return logikai;
            
            
            
        }

        public void halmazba(T elem)
        {
            if (!eleme_e(elem) && n<max)
            {
                elemek[n++] = elem;
                //Array.Sort(elemek);
                //rendezés
                for (int i = 0; i < n-1; i++)
                {
                    int mini = i;
                    for (int j = i+1; j < n; j++)
                    {
                        if (elemek[mini].CompareTo(elemek[j])>0)
                        {
                            mini = j;
                        }
                    }
                    T s = elemek[mini];
                    elemek[mini] = elemek[i];
                    elemek[i] = s;
                }
            }
        }

        public void halmazból(T elem)
        {
            if (eleme_e(elem))
            {
                elemek[talalt] = elemek[n - 1];
                n--;
                for (int i = 0; i < n - 1; i++)
                {
                    int mini = i;
                    for (int j = i + 1; j < n; j++)
                    {
                        if (elemek[mini].CompareTo(elemek[j]) > 0)
                        {
                            mini = j;
                        }
                    }
                    T s = elemek[mini];
                    elemek[mini] = elemek[i];
                    elemek[i] = s;
                }
            }
        }

        public string Kiir()
        {
            string s = "{";
            for (int i = 0; i < n; i++)
            {
                s += elemek[i].ToString();
                s += (i < n - 1 ? "; " : "");
            }
            s += "}";
            return s;
        }

    }
}
