using System;

namespace Vegyes_nov12_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérek egy mondatot!");
            string mondat = Console.ReadLine();
            int db = 0;

            for (int i = 0; i < mondat.Length; i++)
            {
                if (mondat[i] != ' ')
                {
                    Console.Write(mondat[i]);
                }
                db += 1;
            }

            Console.WriteLine("\nKarakterek száma: {0}", db);
            Console.ReadLine();

            Console.Write("A szám: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("B szám: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("C szám: ");
            int c = int.Parse(Console.ReadLine());

            if (a>b && a>c && b>c)
            {
                Console.WriteLine("A legnagyobb szám az A, a legkisebb a C, és B a középső.");
            }
            if (a<b && a>c && b>c)
            {
                Console.WriteLine("A legnagyobb szám B, a legkisebb C, és A a középső.");
            }
            if (c>a && c>b && b>a)
            {
                Console.WriteLine("A legnagyobb szám C, a legkisebb A és a középső B.");
            }
            //gyakorlásnak a többi esetet is le lehet programozni

            Console.ReadLine();
        }
    }
}
