using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace VillamosMegalloKihaygas
    {
    class Program
        {
        public static int allomasDb;
        public static string fileName;
        public struct allomasok
            {
            public int tavolsag;
            public int erkezes;
            public int indulas;

            }
        public static List<allomasok> adatok = new List<allomasok>();

        static void Main(string[] args)
            {
            if (args.Length == 0)
                {
                fileName = "adatok.txt";
                }
            else
                {
                fileName = args[0];
                }
            int feladat1;
            //Adatok tárolva
            /* 
            beolvas(fileName);
            feladat1 = nemAlltMeg();
            */
            //Adatok tárolás nélkül
            feladat1 = lowMemory(fileName);



            Console.WriteLine("Az első megálló ahol nem állt meg: " + feladat1 + ".megálló");

            Console.ReadKey();

            }

        public static void beolvas(string filename)
            {
            StreamReader olvaso = File.OpenText(filename);
            allomasDb = Convert.ToInt32(olvaso.ReadLine());
            allomasok seged;
            string[] darabolt;
            for (int i = 0; i < allomasDb; i++)
                {
                darabolt = olvaso.ReadLine().Split(' ');
                seged.tavolsag = Convert.ToInt32(darabolt[0]);
                seged.erkezes = Convert.ToInt32(darabolt[1]);
                seged.indulas = Convert.ToInt32(darabolt[2]);
                adatok.Add(seged);
                }
            }
        public static int nemAlltMeg()
            {
            int nemAlltMeg = -1;
            for (int i = 0; i < adatok.Count; i++)
                {
                if (adatok[i].erkezes == adatok[i].indulas && nemAlltMeg == -1)
                    {
                    nemAlltMeg = i+1;
                    }
                }          
            return nemAlltMeg;
            }
        public static int lowMemory(string filename)
            {
            int nemAlltMeg = -1;

            StreamReader olvaso = File.OpenText(filename);
            allomasDb = Convert.ToInt32(olvaso.ReadLine());
            string[] darabolt;
            int i = 0;
            do
                {
                darabolt = olvaso.ReadLine().Split(' ');
                if (darabolt[1] == darabolt[2] && nemAlltMeg == -1)
                    {
                    nemAlltMeg = i + 1;
                    }
                i++;
                } while (nemAlltMeg == -1 && i < allomasDb);               
            return nemAlltMeg;
            }
        }
    }
