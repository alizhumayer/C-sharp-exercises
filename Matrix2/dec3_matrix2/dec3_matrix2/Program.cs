using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dec3_matrix2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Kérem a mátrix méretét: ");
            int N = int.Parse(Console.ReadLine());
            int[,] matrix = new int[N,N];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (i == j) matrix[i,j] = 1;
                    else matrix[i,j] = 0;
                }
            }

            Console.WriteLine("A mátrix elemei: ");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write( matrix[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();

            bool van = false;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (i!=j)                   //kihagyjuk a főátlót
                    {
                        //if(i<j)
                        if (matrix[i, j] != 0) van = true;
                        //else if(i>j)
                    }                    
                    
                }
            }
            if (van) Console.WriteLine("van nem-nulla elem");
        }
    }
}
