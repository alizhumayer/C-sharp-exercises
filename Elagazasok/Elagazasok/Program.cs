using System;

namespace Elagazasok
{
    class Program
    {
        static void Main(string[] args)
        {
            int osztalyzat = 0;
            char c = 'i';

            while (c == 'i')
            {            
                Console.WriteLine("Kérem a pontszámot: ");
                int p = Convert.ToInt32(Console.ReadLine());
                
                // double p = Convert.ToDouble(Console.ReadLine());

                /*  Console.WriteLine("Kérek még egyet: ");
                    int p2 = int.Parse(Console.ReadLine());
                */
            
                if (p < 38) osztalyzat = 1;
                else if (p >= 38 && p < 60) osztalyzat = 2;
                else if (p >= 60 && p < 90) osztalyzat = 3;
                else if (p >= 90 && p < 120) osztalyzat = 4;
                else if (p >= 120) osztalyzat = 5;

                if (osztalyzat > 0) Console.WriteLine("Az elért eredmény: {0}", osztalyzat);
                   else Console.WriteLine("Valami nincs rendben. Talán nem jelent meg?");                
            }

            Console.WriteLine("Megvizsgálsz egy következőt is? i/n: ");
            c = Convert.ToChar(Console.ReadLine());
        }

    }
}
