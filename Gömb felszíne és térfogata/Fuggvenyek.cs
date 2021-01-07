using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bdc_5perc_fuggveny
{
    class Program
    {
        /* FELADAT: kérjünk be a felhasználótól egy valós számban tárolt sugár értéket
         * Írjunk függvényeket, melyek egy gömb felszínét és térfogatát számolják ki!
         * (PARAMÉTERES, TÍPUSOS FÜGGVÉNYEK!)
         * A = 4 * PI * r * r; V = (4 * PI * r * r * r) /3
         */
        static double felszin(double r)
        {
            double felszin = 4 * Math.PI * r * r;
            return felszin;
        }

        static double terfogat(double r)
        {
            double terfogat = (4 * Math.PI * r * r * r) / 3;
            return terfogat;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Kérem a sugár értékét!");
            double sugar = Convert.ToDouble(Console.ReadLine());
            //függvényhívások
            Console.WriteLine("A felszín: " + Math.Round(felszin(sugar),2));
            Console.WriteLine("A térfogat: " + Math.Round(terfogat(sugar), 2));
            Console.ReadKey();
        }
    }
}
