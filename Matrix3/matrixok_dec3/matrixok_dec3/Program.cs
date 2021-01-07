using System;
using System.Text;
using System.IO;

namespace matrixok_dec3
{
    class Program
    {
        static void Main(string[] args)
        {
            //van matrix1.txt is, normál mátrixszal
            StreamReader beolvas = new StreamReader("matrixvandermonde.txt",Encoding.Default);
            string[] elsosor = beolvas.ReadLine().Split(' ');
            int N = int.Parse(elsosor[0]);
            int M = int.Parse(elsosor[1]);
            int[,] m = new int[N,M];        //2 dimenziós tömb
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
                    Console.Write(m[k, j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();

            bool vandermonde = true;
            for (int j = 0; j < M; j++)
            {
                if (m[0, j] != 1) vandermonde = false;
            }

            for (int e = 1; e < N; e++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (m[e,j] != m[1,j] * m[e-1, j])
                    {
                        vandermonde = false;
                    }
                }

            }
            if (vandermonde) Console.WriteLine("Ez egy Vandermonde-mátrix.");
            else Console.WriteLine("Ez nem Vandermonde-mátrix.");

            Console.ReadLine();

            if (vandermonde)
            {
                double r = 1.0;
                for (int c = 0; c < M; c++)
                {
                    r = r * m[1, c];
                }
                Console.WriteLine(r);
            }

            Console.ReadLine();

            //Transzponálás:
             int[,] m2 = new int[M,N];
             for(int b=0;b<N;b++) 
              for(int j=0;j<M;j++)
                  m2[j, b] = m[b, j];

            for (int k = 0; k < N; k++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write(m2[k, j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();

            //ide beírom a kódot determinánshoz, és majd úgy töltöm fel
            double det = 1;

            double[,] m3 = new double[N,M];
                       
            for (int k = 0; k < N; k++)
            {
                for (int j = 0; j < M; j++)
                {
                    m3[k, j] = Convert.ToDouble(m[k,j]);
                }
            }
            
            for (int b = 0; b < N; b++)
            {
                for (int j = b+1; j < M; j++)
                {
                    double dseged = m3[b, j] / m3[j, j];
                    for (int g = b+1; g < N; g++)
                    {
                        m3[j,g] = m3[j,g] - dseged * m3[b, g];
                    }
                }
            det = det * m3[b,b];
            }

            Console.WriteLine(det);
            Console.ReadLine();
        }
    }
}
