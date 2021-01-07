using System;

namespace feladat_szorzotabla
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Szorzótábla kiírató");
            Console.Write("Melyik szorzótáblát írjuk ki? ");
            var szam = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i<11; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", i, szam, i * szam);
            }
            Console.ReadKey();
        }
    }
}
