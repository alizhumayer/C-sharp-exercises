using System;

namespace Nov19_2
{
    class Program
    {
        const int N = 3;
        const int M = 2;

        static int sorBekeres()
        {
            int i;
            Console.Write("Kérem a mátrix sorát 1..{0}:",N);
            do
            {
                i = int.Parse(Console.ReadLine());
                if (i<1  || i>N)
                {
                    Console.Write("Kérem újból.");
                }
            } while (i < 1 || i > N);
            return i;
        }

        static int oszlopBekeres()
        {
            int j;
            Console.Write("Kérem a mátrix oszlopát 1..{0}:",M);
            while (true)
            {
                j = int.Parse(Console.ReadLine());
                if (j>=1 && j<=M) return j;
                else Console.Write("Kérem újból.");
            }
            
        }

        static void Main(string[] args)
        {
            int[,] matrix = new int[N,M];

            Console.WriteLine("Függvényeket is használunk");

            for (int db = 0; db < N*M; db++)
            {            
                int i = sorBekeres();
                int j = oszlopBekeres();
                Console.Write("Kérem az értéket: ");
                int x = int.Parse(Console.ReadLine());
                matrix[i-1,j-1] = x;
            }

            Console.WriteLine("A mátrix elemei: ");

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++) Console.Write("{0}  ", matrix[i, j]);
                    Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}
