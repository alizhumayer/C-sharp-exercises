using System;

namespace Nov26_matrixmuvelet
{
    class Program
    {
        const int N = 4;
        const int M = 4;

        static void Main(string[] args)
        {
            Console.WriteLine("Mátrix feltöltése véletlenszámokkal");

            int[,] tomb = new int[N, M];
            Random rnd = new Random();  

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    tomb[i, j] = rnd.Next(1, 15);
                }
            }

            Console.WriteLine("Az elemek: ");

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++) Console.Write("{0}  ", tomb[i, j]);
                Console.WriteLine();
            }
            Console.ReadKey();

            //Mátrix tükrözése
            for (int i = 0; i < N; i++)
            {
                for (int j = i; j < M; j++)
                {
                    int cs = tomb[i, j];
                    tomb[i, j] = tomb[j,i];
                    tomb[j, i] = cs;
                }
            }

            Console.WriteLine("A tükrözött mátrix: ");

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++) Console.Write("{0}  ", tomb[i, j]);
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
