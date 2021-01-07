using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace matrix1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader beolvas = new StreamReader("matrix1.txt", Encoding.Default);
            string[] elsosor = beolvas.ReadLine().Split(' ');
            int N = int.Parse(elsosor[0]);
            int M = int.Parse(elsosor[1]);
            int[,] m = new int[N, M];        //2 dimenziós tömb
                                             //int[] tomb = new int[2]; //2 elemű tömb:  tomb[0], tomb[1]  (2 és 125 az elemek)

            int i = 0;
            while (!beolvas.EndOfStream)
            {
                string[] sor = beolvas.ReadLine().Split(' ');
                for (int j = 0; j < M; j++)
                {
                    m[i, j] = int.Parse(sor[j]);
                }
                i++;
            }
            beolvas.Close();

            for (int k = 0; k < N; k++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.WriteLine(" ", m[k, j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }  
    }
}
