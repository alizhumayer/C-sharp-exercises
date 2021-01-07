using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace Eratoszthenesz_szitaja
{
    class Szita
    {
        private int max;
        public List<int> szamok = new List<int>();     
        public long stopper_ms;
        public Szita(int n)
        {
            max = n;         
        }
        
        public void szitalas()
        {
            feltolt();
            var stopper = new Stopwatch();
            stopper.Start();
            int i = 1,j;
            while (i<max)
            {
                i++;
                if (bennevan(i))
                {
                    j = 1;
                    while (i*j<max)
                    {
                        j++;
                        szamok.Remove(i * j);
                    }
                }
            }
            stopper.Stop();
            stopper_ms = stopper.ElapsedMilliseconds;
        }

        public void feltolt()
        {
            for (int i = 2; i <= max; i++)
            {
                szamok.Add(i);
            }
        }
        public void fajlba_primek()
        {
            string fname = "Primek_" + max + "ig.txt";
            StreamWriter kiir = File.CreateText(fname);
            for (int i = 0; i < szamok.Count; i++) 
            {
                kiir.WriteLine(szamok[i] + " ");
            }
            kiir.WriteLine("Process time: " + stopper_ms + " ms");
            kiir.Close();
        }

        public int elemszam
        {
            get
            {
                return szamok.Count;
            }
        }

        public int szum
        {            
            get
            {
                return szamok.Sum();
            }
        }
        public double atlag
        {
            get
            {
                return (double)this.szum / max;
            }
        }
        public bool bennevan(int szam)
        {
            bool van = false;
            for (int i = 0; i < szamok.Count; i++)
            {
                if (szamok[i]==szam)
                {
                    van = true;
                }
            }
            return van;
        }



    }
}
