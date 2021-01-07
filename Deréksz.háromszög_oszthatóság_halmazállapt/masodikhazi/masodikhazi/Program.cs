using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masodikhazi
{
    class Program
    {
        static void Main(string[] args)
        {

            /*HÁZI: 1.: Derékszögű háromszög 2 befogója, határozzuk meg az átfogót (a2+b2=c2)
                    2. Egy tetszőleges szám osztható-e maradék nélkül 3 al
                    3. Ha ismerjük a viz hőmérsékletét, adjuk meg a halmazállapotát (szil,foly,gáz)
                    4. be: 2 szám, a nagyobbat ossza el a kisebbel, az eredményt 2 tizedesig (nullával nem osztunk)
                    
                    
             */

            /* 1. Derékszögű háromszög Be: a, b befogók | Ki: c átfogó | (a2+b2=c2) */
            /*
            double a = 0, b = 0, c = 0 ;
            Console.WriteLine("Adja meg az első 'a' befogót (cm)");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Adja meg a második 'b' befogót (cm)");
            b = Convert.ToDouble(Console.ReadLine());

            c = Math.Pow(a, 2) + Math.Pow(b, 2);
            Console.WriteLine("Az átfogó hossza: {0:0.00} cm", c);
            Console.ReadKey();

            */

            /* 2. Egy tetszőleges szám osztható-e maradék nélkül 3 -mal  */

            /*
            double a = 0, b = 0;
            Console.WriteLine("Adja meg a számot");
            a = Convert.ToDouble(Console.ReadLine());

            b = a % 3;
            if(b > 0 || b < 0 )
                Console.WriteLine("A szám nem osztható maradék nélkül");
            else
                Console.WriteLine("A szám maradék nélkül osztható");

            Console.ReadKey();


            */

            /*3. Ha ismerjük a viz hőmérsékletét, adjuk meg a halmazállapotát (szil,foly,gáz) */

            /*

            double a = 0;
            Console.WriteLine("Adja meg a hőfokot");
            a = Convert.ToDouble(Console.ReadLine());

            if (a < 0) 
                Console.WriteLine("Szilárd");
            else if (a >= 100)
                Console.WriteLine("Gáz");
            else
                Console.WriteLine("Folyékony");

            Console.ReadKey();
            
            */

            /* 4.  be: 2 szám, a nagyobbat ossza el a kisebbel, az eredményt 2 tizedesig (nullával nem osztunk) */

            double a = 0, b = 0, c = 0;
            Console.WriteLine("Adja meg az első számot");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Adja meg a második számot");
            b = Convert.ToDouble(Console.ReadLine());

            // Math.Min/Max

            if (a == 0 && b == 0)
                Console.WriteLine("A művelet nem értelmezhető");
            else if (Math.Min(a, b) != 0)
            { 
                c = Math.Max(a, b) / Math.Min(a, b);
              
            Console.WriteLine("Az osztás eredménye: {0:0.00}", c);
            }
            else
            {

                Console.WriteLine("0-val nem osztunk");
            }



            Console.ReadKey();
        }
    }
}
