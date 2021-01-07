using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1
{
    class Program
    {
        static void Main(string[] args)
        {
            //be: 100 elem [-1000,1000] ki: 2. legnagyobb

            int elemszam = 100;
            int[] szamok = new int[elemszam];
            Random vsz = new Random();
            int max1st = 0;
            int max2nd = 0; 

            for (int i = 0; i < elemszam; i++)
            {
                szamok[i] = vsz.Next(-1000, 1001);              
            }
            Console.WriteLine("A 100 szám a következő: ");

            for (int i = 0; i < elemszam; i++)
            {
                Console.Write("{0} ", szamok[i]);                
            }

            for (int i = 0; i < elemszam; i++)
            {
                if(szamok[i]> max1st)
                {
                    max1st = szamok[i];
                }
            }
            for (int i = 0; i < elemszam; i++)
            {
                if (szamok[i] > max2nd && szamok[i] != max1st)
                {
                    max2nd = szamok[i];
                }
            }

            Console.WriteLine("\n\nA 2. legnagyobb szám a(z): {0}", max2nd);
            Console.ReadKey();


        }
    }
}
