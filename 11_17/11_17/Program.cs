using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _11_17
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader f = File.OpenText("forras.txt");
            List<int> lista = new List<int>();
            while (!f.EndOfStream)
            {
                string[] sor = f.ReadLine().Split(';');
                for (int i = 0; i < sor.Length; i++)
                {
                    lista.Add(int.Parse(sor[i]));
                }
            }
            lista.Sort();
            DateTime x1 = DateTime.Now;
            Console.WriteLine(Linker(lista, lista.Count, 78703));
            DateTime x2 = DateTime.Now;
            Console.WriteLine(x2.Subtract(x1));
            x1 = DateTime.Now;
            Console.WriteLine(Logker(lista, lista.Count, 78703));
            x2 = DateTime.Now;
            Console.WriteLine(x2.Subtract(x1));
            x1 = DateTime.Now;
            Console.WriteLine(LinkerRek(lista, 0, 5000, 78703));
            x2 = DateTime.Now;
            Console.WriteLine(x2.Subtract(x1));
            x1 = DateTime.Now;
            Console.WriteLine(LogkerRek(lista, 0, lista.Count, 78703));
            x2 = DateTime.Now;
            Console.WriteLine(x2.Subtract(x1));
            Console.ReadKey();
        }
        static int Linker(List<int> list, int n, int ertek)
        {
            int i = 0;
            while (i < n && list[i] != ertek)
            {
                i++;
            }
            bool van = i < n;
            if (van)
            {
                return i;
            }
            else
            {
                return -1;
            }
        }
        static int Logker(List<int> list, int n, int ertek)
        {
            int bal = 0;
            int jobb = n;
            int kozep;
            do
            {
                kozep = (bal + jobb) / 2;
                if (list[kozep] > ertek)
                {
                    jobb = kozep - 1;
                }
                else if (list[kozep] < ertek)
                {
                    bal = kozep + 1;
                }
            } while (bal < jobb && list[kozep] != ertek);
            bool van = bal < jobb;
            if (van)
            {
                return kozep;
            }
            else
            {
                return -1;
            }
        }
        static int LinkerRek(List<int> list, int bal, int n, int ertek)
        {
            if (bal > n)
            {
                return -1;
            }
            else
            {
                if (list[bal] == ertek)
                {
                    return bal;
                }
                else
                {
                    return LinkerRek(list, bal + 1, n, ertek);
                }
            }
        }
        static int LogkerRek(List<int> list, int bal, int jobb, int ertek)
        {
            if (bal > jobb)
            {
                return -1;
            }
            else
            {
                int kozep = (bal + jobb) / 2;
                if (list[kozep] == ertek)
                {
                    return kozep;
                }
                else
                {
                    if (list[kozep] > ertek)
                    {
                        return LogkerRek(list, bal, kozep - 1, ertek);
                    }
                    else
                    {
                        return LogkerRek(list, kozep + 1, jobb, ertek);
                    }
                }
            }
        }
    }

}
