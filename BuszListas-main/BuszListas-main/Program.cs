using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace bdc_Busz_Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> utasok = new List<int>();

            try
            {
                //beolvasás
                FileStream fs = new FileStream("busz.txt",FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                string sor = "";
                while (!sr.EndOfStream)
                {
                    sor = sr.ReadLine();
                    utasok.Add(Convert.ToInt32(sor));
                }

                sr.Close();
                fs.Close();
                Console.WriteLine("A beolvasás sikeres!");
            }
            catch (Exception hiba)
            {
                Console.WriteLine("Hiba a beolvasáskor: " + hiba);
            }

            Console.WriteLine("Itt folytatom!");

            Console.WriteLine("A lista elemei:");
            for (int i = 0; i < utasok.Count; i++)
            {
                Console.Write(utasok[i] + " ");
            }
            Console.WriteLine("\nEnnyi nap adatait rögzítettük: " + utasok.Count);
            Console.WriteLine("Összesen a hónapban ennyien utaztak: " + utasok.Sum());

            //Hány olyan nap volt, ami...
            int db200 = 0;
            foreach (int szam in utasok)
            {
                if (szam > 200)
                {
                    db200++;
                }
            }
            Console.WriteLine("Ennyiszer voltak 200-nál többen: " + db200);

            Console.WriteLine("A legnagyobb utasszám: " + utasok.Max());
            for (int i = 0; i < utasok.Count; i++)
            {
                if (utasok[i] == utasok.Max())
                {
                    Console.WriteLine((i+1) + ". napon");
                }
            }

            Console.WriteLine("Volt-e 200 utas valamelyik napon:");
            if (utasok.Contains(200))
            {
                Console.WriteLine("IGEN");
            }
            else
            {
                Console.WriteLine("NEM");
            }

            Console.ReadKey();
        }
    }
}
