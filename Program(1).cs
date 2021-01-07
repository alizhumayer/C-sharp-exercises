using System;

namespace Vegyes_nov12_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Kérek egy számot!");
            int szam = int.Parse(Console.ReadLine());

            if (szam % 2 == 0) Console.Write("a szám páros");
            else Console.Write("a szám páratlan");

            Console.ReadLine();

            Random rnd = new Random();
            int hatosokszama = 0;
            for (int i = 0; i < 5; i++)
            {
                if (rnd.Next(1, 7) == 6) hatosokszama += 1;                
            }
            Console.WriteLine("\n{0} db hatost dobtunk", hatosokszama);
            Console.ReadLine();
        }
    }
}
