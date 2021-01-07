using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace VonatUresedes
    {
    class Program
        {
        public static int allomasDb;
        public struct mozgasok
            {
            public int fel;
            public int le;
            }
        public static string fileName;
        public static List<mozgasok> adatok = new List<mozgasok>();




        static void Main(string[] args)
            {
            if (args.Length==0)
                {
                fileName = "adatok.txt";
                }
            else
                {
                fileName = args[0];
                }
            beolvas(fileName);
            int uresedesekSzama;
            uresedesekSzama = uresedes();
            Console.WriteLine("Megállók száma ahol mindenki leszállt: " + uresedesekSzama + " db");
            Console.ReadKey();




            }

        public static void beolvas(string filename)
            {
            StreamReader olvaso = File.OpenText(filename);
            allomasDb = Convert.ToInt32(olvaso.ReadLine());
            mozgasok seged;
            string[] darabolt;
            for (int i = 0; i < allomasDb; i++)
                {
                darabolt = olvaso.ReadLine().Split(' ');
                seged.le = Convert.ToInt32(darabolt[0]);
                seged.fel = Convert.ToInt32(darabolt[1]);
                adatok.Add(seged);
                }
            }
        public static int uresedes()
            {
            int jelenlegiDb = adatok[0].fel;
            int uresedesDb = 0;
            for (int i = 1; i < adatok.Count; i++)
                {
                jelenlegiDb -= adatok[i].le;
                if (jelenlegiDb==0)
                    {
                    uresedesDb++;
                    }
                jelenlegiDb += adatok[i].fel;


                }

            return uresedesDb;
            }




        }
    }
