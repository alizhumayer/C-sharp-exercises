using System;
using System.Collections.Generic;
using System.Text;

namespace harom_halmaz
{
    class Halmaz<T> where T:IComparable<T>
    {
        private int n;
        private int talalt;
        private const int MAX = 200;
        private T[] elemek;
        public Halmaz()
        {
            n = 0;
            elemek = new T[MAX];
        }
        public Halmaz(T elem) : this()
        { 
            elemek[n++] = elem; 
        } 
        public int Elemszam
        {
            get
            {
                return n;
            }
        }
        public bool ElemeE(T elem)
        {
            bool l = false;
            int e = 0;
            int u = n - 1;
            int i = 0; 
            while (!l && e <= u) 
            { 
                i = (e + u) / 2;
                int x = elemek[i].CompareTo(elem);
                if (x < 0) { e = i + 1; } 
                else if (x > 0) { u = i - 1; }
                else { l = true; } 
            }
            talalt = i;
            return l;
        }
        public static Halmaz<T> operator +(Halmaz<T> a, Halmaz<T> b) 
        { 
            Halmaz<T> c = new Halmaz<T>();
            int i = 0;
            int j = 0;
            while (i < a.n && j < b.n) 
            { 
                int x = a.elemek[i].CompareTo(b.elemek[j]);
                if (x < 0) { c.elemek[c.n] = a.elemek[i++]; }
                else if (x > 0) { c.elemek[c.n] = b.elemek[j++]; }
                else { c.elemek[c.n] = a.elemek[i++]; j++; }
                c.n++; 
            } 
            while (i < a.n) 
            { 
                c.elemek[c.n++] = a.elemek[i++]; 
            } 
            while (j < b.n) 
            { 
                c.elemek[c.n++] = b.elemek[j++]; 
            } 
            return c; 
        }
        public static Halmaz<T> operator *(Halmaz<T> a, Halmaz<T> b) 
        { 
            Halmaz<T> c = new Halmaz<T>();
            int i = 0;
            int j = 0;
            while (i < a.n && j < b.n) 
            { 
                int x = a.elemek[i].CompareTo(b.elemek[j]);
                if (x < 0) { i++; }
                else if (x > 0) { j++; }
                else { c.elemek[c.n++] = a.elemek[i++]; j++; } 
            }
            return c; 
        }
        public static Halmaz<T> operator -(Halmaz<T> a, Halmaz<T> b) 
        { 
            Halmaz<T> c = new Halmaz<T>();
            int i = 0;
            int j = 0;
            while (i < a.n && j < b.n) 
            { 
                int x = a.elemek[i].CompareTo(b.elemek[j]);
                if (x < 0) { c.elemek[c.n++] = a.elemek[i++]; }
                else if (x > 0) { j++; } 
                else { i++; j++; }
            } 
            while (i < a.n) 
            { 
                c.elemek[c.n++] = a.elemek[i++]; 
            } 
            return c;
        }
        public string Kiir()
        {
            string s = "{ ";
            for (int i = 0; i < n; i++)
            {
                s += elemek[i].ToString();
                s += (i < n - 1 ? "; " : "");
            }
            s += " }";
            return s;
        }
    }
}
