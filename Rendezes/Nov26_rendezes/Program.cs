using System;

namespace Nov26_rendezes
{
    class Program
    {
        const int N = 30;
        static void Main(string[] args)
        {
            Console.WriteLine("Egyszerű cserés rendezés");
            int[] t = new int[N];
            Random rnd = new Random();

            for (int i = 0; i < N; i++)
            {
                t[i] = rnd.Next(1, 100);
            }

            foreach (int b in t) Console.Write("{0} ", b);
            Console.WriteLine();
            Console.ReadKey();
            //egyszerű cserés rendezés  5 3 1 4 2
            for (int i = 0; i < N - 1; i++)
            {
                for (int j = i + 1; j < N; j++)
                {
                    if (t[j] < t[i])
                    {
                        int seged = t[i];
                        t[i] = t[j];
                        t[j] = seged;
                    }
                }
            }
            Console.WriteLine("A rendezett elemek: ");
            foreach (int b in t) Console.Write("{0} ", b);
            Console.ReadKey();

            Console.WriteLine("\nSzétválogatás két tömbbe");
            int[] paros = new int[N];
            int[] paratlan = new int[N];
            int pdb = 0;
            int ptlandb = 0;

            for (int i = 0; i < N; i++)
            {
                if (t[i] %2 == 0)
                {                    
                    paros[pdb] = t[i];
                    pdb++;
                }
                else
                {                    
                    paratlan[ptlandb] = t[i];
                    ptlandb++;
                }
            }
            Console.WriteLine("A tömb páros elemei:");
            Console.WriteLine("A tömbben {0} db páros szám van.",pdb);
            int f = 0;
            while (f<pdb)
            {
                Console.Write("{0} ", paros[f]);
                f++;
            }
            //foreach (int b in paros) 
           
            Console.WriteLine("\nA tömb páratlan elemei:");
            Console.WriteLine("A tömbben {0} db páratlan szám van.", ptlandb);
            int d = 0;
            while (d < ptlandb)
            {
                Console.Write("{0} ", paratlan[d]);
                d++;
            }
            //foreach (int b in paratlan) Console.Write("{0} ", b);
            Console.ReadKey();

            Console.WriteLine("\nSzétválogatás egy tömbbe");
            int[] szetvalogatas_egy_tombbe = new int[N];           
            int dbe = -1; 
            int dbv = N;

            for (int i = 0; i < N; i++)
            {
                if (t[i] % 2 == 0)
                {
                    dbe++;
                    szetvalogatas_egy_tombbe[dbe] = t[i];
                }
                else
                {
                    dbv--;
                    szetvalogatas_egy_tombbe[dbv] = t[i];
                }
            }
            Console.WriteLine("Szétválogatás egy tömbbe: ");
            foreach (int b in szetvalogatas_egy_tombbe) Console.Write("{0} ", b);
            Console.ReadKey();
        }
    }
}
