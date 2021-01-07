using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benzinkut
{
    class Sor<T> 
    {
        const int MAX = 100;
        T[] se;
        private int eleje, vege, hossz;

        public Sor()
        {
            se = new T[MAX];
            //létrehozáskor a Sor üres      
            eleje = 0;
            vege = 0;
            hossz = 0;
        }
        public bool UresE()
        {
            return hossz == 0;
        }
        public bool TeleE()
        {
            return hossz == MAX;
        }
        public void Sorba(T e)
        {
            if (!TeleE())
            {
                se[vege] = e;
                hossz++;
                vege = ((vege + 1) % MAX);
            }
        }
        public T Sorbol()
        {
            if (!UresE())
            {
                T e = se[eleje];
                hossz--;
                eleje = ((eleje + 1) % MAX);
                return e;
            }
            else
            {
                return default(T);
            }
        }
        public override string ToString()
        {
            if (UresE())
            {
                return "Üres";
            }
            else
            {
                string s = "";
                int i = eleje;
                while (i != vege)
                {
                    s += se[i].ToString() + ", ";
                    i = (i + 1) % MAX;
                }
                return s;
            }
        }
        public int Hossz
        {
            get
            {
                return hossz;
            }
        }
        public T Elso()
        {
            if (!UresE())
            {
                return se[eleje];
            }
            else
            {
                return default(T);
            }
        }
        public T this[int i]
        {
            get
            {
                if (!UresE())
                {
                    return se[(eleje + i) % hossz];
                }
                else
                {
                    return default(T);
                }
            }     
        }
    }
}
