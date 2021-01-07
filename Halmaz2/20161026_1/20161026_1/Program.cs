using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using halmaz_oszt;

namespace _20161026_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int elemsz = 5000;
            Halmaz<int> p = new Halmaz<int>(elemsz);
            int i;
            for (i = 2; i <= elemsz; i++)
            {
                p.halmazba(i);
            }
            i = 1;
            while (i<elemsz)
            {
                i++;
                if (p.eleme_e(i))
                {
                   int j = 1;
                    while (i*j<elemsz)
                    {
                        j++;
                        p.halmazból(i * j);
                    }
                }
            }
            Console.WriteLine(p.Kiir());

            Console.ReadKey();
        }
    }
}
