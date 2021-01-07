using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elsohazi
{
    class Program
    {
        static void Main(string[] args)
        {

            //henger: bekérés: sugár (r) , magasság (h) | Számítás: felszín (s) , térfogat (v) /2 tizedesig/ 

            double r = 0, h = 0, s = 0, v = 0;
            Console.WriteLine("Kérem adja meg a sugarat: ");
            r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Kérem adja meg a magasságot: ");
            h = Convert.ToDouble(Console.ReadLine());
            s = 2 * Math.PI * r * (r + h);
            v = r * r * h * Math.PI;
            Console.WriteLine("Felszín: {0:0.00}, Térfogat: {1:0.00}", s, v);


            Console.ReadKey();
        }
    }
}
