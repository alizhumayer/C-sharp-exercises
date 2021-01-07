using System;

namespace Nov19_1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int N = 4;
            const int M = 3;   //int[,] matrix = new int[N,M];
            
            Console.WriteLine("Mátrix (kétdimenziós tömb) feladat");

            int[,] matrix = new int[2,2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("Kérem a/z {0}. sor {1}. elemét: ", i+1,j+1);
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("A Mátrix: ");

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++) Console.Write("{0}  ", matrix[i, j]);
                Console.WriteLine("");
            }

            Console.ReadLine();
        }
    }
}
