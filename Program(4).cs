using System;

namespace Nov19_3
{
    class Program
    {
        const int N = 3;
        const int M = 4;

        static int Kivalogatas(int[,] v)
        {
            int i,j,db = 0;
            int[] tomb2 = new int[N * M];

            for (i = 0; i < N; i++)
            {
                for (j = 0; j < M; j++)
                {
                    if (v[i, j] > 10)       //if ((v[i, j])>max) -- maximumkiválogatáshoz
                    {
                        tomb2[db] = v[i, j];
                        db++;
                    }
                }                
            }
            int k = 0;
            while (k<db)
            {
                Console.Write("{0} ", tomb2[k]);
                k++;
            }
            Console.ReadLine();
            return 0;
        }

        static double Atlag(int[,] v)
        {
            double atlag = 0;
            int osszeg = 0;
            int db = 0;
            
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    osszeg = osszeg + v[i, j];
                    db++;                    
                }
            }
            atlag = osszeg / db;
            Console.WriteLine("Az elemek átlaga: {0}", atlag);
            return atlag;
        }

        static int Maximumkivalasztas(int[,] velszamok)
        {
            int max = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (velszamok[i, j] > max)
                    {
                        max = velszamok[i, j];
                    }
                }
            }
            Console.WriteLine("A legnagyobb érték: {0}", max);
            return max;
        }

        static int Kereses(int[,] vel)
        {
            int hely = 0;
            int i = 0;
            while (i<N)
            {
                for (int j = 0; j < M; j++)
                {
                    if ((vel[i, j] * vel[i, j]) > 80)
                    {
                        hely++;
                    }
                }
                i++;
            }
            if (hely > 0) Console.WriteLine("Az utolsó megfelelő keresett elem a {0}.",hely);
            return hely;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Mátrix feltöltése véletlenszámokkal");

            int[,] tomb = new int[N,M];            
            Random rnd = new Random();  //egy programban elég egy véletlenszám-generátor, nem kell több

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    tomb[i, j] = rnd.Next(1,15);
                }
            }

            Console.WriteLine("Az elemek: ");

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++) Console.Write("{0}  ", tomb[i, j]);
                Console.WriteLine();
            }                     

            Console.ReadLine();
            Atlag(tomb);
            Kivalogatas(tomb);
            Maximumkivalasztas(tomb);
            Kereses(tomb);
            Console.ReadLine();
            
            //tomb2-t kiírjuk
        }
    }
}
