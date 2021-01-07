using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Nov26_listamuveletek
{
    class Program
    {
        const int N = 15;

        static void Main(string[] args)
        {
            Console.WriteLine("Lista");
            Random rnd = new Random();
            List<int> szamok = new List<int>();

            for (int i = 1; i < N; i++)
            {
                szamok.Add(rnd.Next(1,75));
            }

            foreach (int i in szamok) Console.Write("{0} ", i);
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("A lista legnagyobb eleme: {0}", szamok.Max());
            Console.WriteLine("A lista legkisebb eleme: {0}", szamok.Min());
            Console.WriteLine("A listaelemek átlaga: {0}", szamok.Average());
            Console.WriteLine("A listaelemek összege: {0}", szamok.Sum());
            Console.ReadKey();

        }
    }
}
