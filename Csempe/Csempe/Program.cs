using System;

namespace Csempe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rakjunk le csempét a konyhába!");

            Console.WriteLine("Szélesség méterben: ");
            double szel = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Hosszúság méterben: ");
            double hossz = Convert.ToDouble(Console.ReadLine());

            double terulet = szel * hossz;

            Console.WriteLine("A konyha területe: {0} nm", terulet);

            double cs = 0.2 * 0.2;  //1 csempe mérete
            double db = terulet / cs;
            double osszes_szukseges = db + 0.1 * db;

            Console.WriteLine("A szükséges csempe-mennyiség: {0:00,00} db", osszes_szukseges);
            Console.ReadLine();
        }           
        
    }
}
