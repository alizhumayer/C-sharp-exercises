using System;
using System.Collections.Generic;

namespace Listak_nov12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Listát generálunk...");

            List<int> lista = new List<int>();

            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                lista.Add(rnd.Next(1,50));          //a listához adjuk az új elemet
                //Console.Write("{0} ",i);
            }

            foreach (int i in lista)        //kiíratjuk a lista elemeit
            {
                if (i % 2 != 0)
                {
                    Console.Write("{0} ", i);
                }
                
            }
            Console.ReadLine();

            int[] fib = new int[]{0,1,2,3,5,8,13,21};       //tömb deklarálás / létrehozás

            Console.WriteLine("A Fibonacci-sorozat első pár tagja: ");

            foreach (int j in fib)
            {
                Console.Write("{0} ", j);
            }
            Console.ReadLine();
        }
    }
}
