using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masodikora
{
    class Program
    {
        static void Main(string[] args)
        {

            // kérjünk be egy számot és írjuk ki a köbgyököt 4 tizedesjegyig
            /*
            double a = 0, b=0;
            Console.WriteLine("Adj meg egy számot");
            a = Convert.ToDouble(Console.ReadLine());
            //b = Math.Sqrt(a);
            b = Math.Pow(a, 1 / 3.0);
            Console.WriteLine("Gyök: {0:0.0000}", b);
            */
            /*segít a pénztárosnak a papírpénzek értékének megszámolásában. kérje be a benkjegyekből (500,1000,2000,5e,10e,20e) hány darab van és a végén adja meg a teljes bevételt*/


            /*
            int a = 0, b = 0, c = 0, d = 0, e = 0, f = 0, af = 0, bf = 0, cf = 0, df = 0, ef = 0, ff =0, full= 0;
            Console.WriteLine("Adja meg az 500-asok számát");
            a = Convert.ToInt32(Console.ReadLine());
            af = a * 500;
            Console.WriteLine("Adja meg az 1000-esek számát");
            b = Convert.ToInt32(Console.ReadLine());
            bf = b * 1000;
            Console.WriteLine("Adja meg az 2000-esek számát");
            c = Convert.ToInt32(Console.ReadLine());
            cf = c * 2000; 
            Console.WriteLine("Adja meg az 5000-esek számát");
            d = Convert.ToInt32(Console.ReadLine());
            df = d * 5000;
            Console.WriteLine("Adja meg az 10000-esek számát");
            e = Convert.ToInt32(Console.ReadLine());
            ef = e * 10000;
            Console.WriteLine("Adja meg az 20000-esek számát");
            f = Convert.ToInt32(Console.ReadLine());
            ff = f * 20000;
           
            full = af + bf + cf + df + ef + ff;
            Console.WriteLine("A teljes bevétel: {0}", full);
             */

            //pénztáros bevétel 5 % megkapja, kerekítse egész értékre
            /*
            double a = 0, b = 0;
            Console.WriteLine("Adja meg az bevételt");
            a = Convert.ToDouble(Console.ReadLine());
            b = Math.Round(a * 0.05); 
            Console.WriteLine("A mai fizetése: {0}",b);
            */


           /*Be :2 szám, és írja ki a nagyobbat */
/*
            double a = 0, b = 0;
            Console.WriteLine("Adja meg az egyik számot");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Adja meg az másik számot");
            b = Convert.ToDouble(Console.ReadLine());
            
            if (a > b)
            {
                Console.WriteLine("Az első a nagyobb: {0}", a);

            }
            else
            {
                if (a < b)
                {
                    Console.WriteLine("Az második a nagyobb: {0}", b);
                }
                else
                {
                    Console.WriteLine("A 2 szám egyenlő: {0} = {1}",a, b);
                }
            }

            */


            // szám bekér, ha nagyobb 0nal irjuk ki h. pozitív
           /*
            
            double a = 0, b = 0 ;
            Console.WriteLine("Adja meg a számot");
            a = Convert.ToDouble(Console.ReadLine());
            b = Math.Sign(a);
            if (a > 0)
            {
                Console.WriteLine("A szám pozitív {0}", b);
            }
            else
            {
                if (a == 0)
                {
                    Console.WriteLine("A szám 0");
                }
                else
                {
                    Console.WriteLine("A szám negatív {0}", b);

                }
            }

            */

            // be: egész szám, páros/páratlan

            /*
            int a = 0, b = 0;
            Console.WriteLine("Adja meg a számot");
            a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0 )
            {

                Console.WriteLine("A szám páros");
            }
            else
            {
                    Console.WriteLine("A szám páratlan");
             
            }

            */

            // Be: másodfoku egyenlet együthatóit és számítsuk ki a gyököket 2 tizedesig, ha a diszkrimináns negatív írjuk ki : nincs megoldás

            /*
            double a = 0, b = 0, c = 0, D = 0, xe = 0, xk = 0;
            Console.WriteLine("Adja meg a a-t");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Adja meg a b-t ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Adja meg a c-t ");
            c = Convert.ToDouble(Console.ReadLine());

            D = Math.Pow(b, 2) - 4 * a * c;

            

                if (D < 0)
                {
                    Console.WriteLine("Nincs megoldás");
                }
                else if( D > 0)
                    {
                    xe = (-b + Math.Sqrt(D)) / (2 * a);
                    xk = (-b - Math.Sqrt(D)) / (2 * a);
                     Console.WriteLine("X1 = {0:0.00} és X2 = {1:0.00}", xe, xk);
                    }
                    
                else 
                {
                    Console.WriteLine("X = {0:0.00}", -b/(2*a));
                }
                
            */
            // be 2 szám, ki hányados


            /*
            double a = 0, b = 0, c = 0, d = 0;
            Console.WriteLine("Adja meg az egyik számot ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Adja meg a másik számot-t ");
            b = Convert.ToDouble(Console.ReadLine());
            if ( b == 0 )
            {
                Console.WriteLine("0-val nem lehet osztani ");
            }
            else
            {
                c = a / b;
                d = a % b;
                Console.WriteLine("{0} osztva {1} = {2}.{3}",a,b,c,d);
            }

             */



            //be 3 szám, ki: lehet e 3 szög oldalai a+b>c és a+c>b és b+c>a
            /*

            double a = 0, b = 0, c = 0;
            Console.WriteLine("Adja meg az első számot ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Adja meg a második számot-t ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Adja meg a harmadik számot ");
            c = Convert.ToDouble(Console.ReadLine());
            if (a + b > c && a + c > b && b + c > a )
            {
                Console.WriteLine("EBBŐL LEHET HÁROMSZÖG");
            }
            else
            {
                Console.WriteLine("EBBŐL NEM LEHET HÁROMSZÖG");
            }

            */
            //---------------------------------------------------------------------------------------------------------------------------------------------
            /*HÁZI: 1.: Derékszögű háromszög 2 befogója, határozzuk meg az átfogót (a2+b2=c2)
                    2. Egy tetszőleges szám osztható-e maradék nélkül
                    3. Ha ismerjük a viz hőmérsékletét, adjuk meg a halmazállapotát (szil,foly,gáz)
                    4. be: 2 szám, a nagyobbat ossza el a kisebbel, az eredményt 2 tizedesig (nullával nem osztunk)
                    5
                    
             */ 


            Console.ReadKey();
        }
    }
}
