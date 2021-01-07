using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Erettsegi37_Tarsalgo_Csharp
{
    class Áthaladás
    {
        public DateTime Idő { get; private set; }
        public string IdőShort => Idő.ToShortTimeString();
        public int Azon { get; private set; }
        public string Irány { get; private set; }

        public Áthaladás(string sor)
        {
            string[] m = sor.Split();
            Idő = DateTime.Parse($"{m[0]}:{m[1]}");
            Azon = int.Parse(m[2]);
            Irány = m[3];
        }
    }

    class Tarsalgo
    {
        static void Main(string[] args)
        {
            List<Áthaladás> a = new List<Áthaladás>();
            foreach (var i in File.ReadAllLines("ajto.txt")) a.Add(new Áthaladás(i));

            Console.WriteLine("2. feladat");
            Console.WriteLine($"Az első belépő: {a[0].Azon}");
            foreach (var i in a.OrderByDescending(x => x.Idő))
            {
                if (i.Irány == "ki")
                {
                    Console.WriteLine($"Az utolsó kilépő: {i.Azon}");
                    break;
                }
            }

            // 3. feladat
            Dictionary<int, int> stat = new Dictionary<int, int>();
            foreach (var i in a)
            {
                if (stat.ContainsKey(i.Azon)) stat[i.Azon]++;
                else stat.Add(i.Azon, 1);
            }
            List<string> ki = new List<string>();
            foreach (var i in stat.OrderBy(x => x.Key)) ki.Add($"{i.Key} {i.Value}");
            File.WriteAllLines("../../athaladas.txt", ki);

            Console.WriteLine("\n4. feladat");
            Console.Write("A végén a társalgóban voltak: ");
            foreach (var i in stat.OrderBy(x => x.Key)) if (i.Value % 2 == 1) Console.Write($"{i.Key} ");

            // 5. feladat:
            int aktLétszám = 0;
            int maxLétszám = 0;
            Áthaladás maxÁthaladás = null;
            foreach (var i in a)
            {
                if (i.Irány == "be") aktLétszám++;
                else aktLétszám--;
                if (aktLétszám > maxLétszám)
                {
                    maxLétszám = aktLétszám;
                    maxÁthaladás = i;
                }
            }
            Console.WriteLine("\n\n5. feladat");
            Console.WriteLine($"Például {maxÁthaladás.IdőShort}-kor voltak legtöbben a társalgóban.");

            Console.WriteLine("\n6. feladat");
            Console.Write("Adja meg a személy azonosítóját! ");
            int inputAzon = int.Parse(Console.ReadLine());

            Console.WriteLine("\n7. feladat");
            foreach (var i in a)
            {
                if (i.Azon == inputAzon)
                {
                    if (i.Irány == "be") Console.Write($"{i.IdőShort}-");
                    else Console.WriteLine($"{i.IdőShort}");
                }
            }

            Console.WriteLine("\n\n8. feladat");
            TimeSpan társalgóbanTöltöttIdő = TimeSpan.Zero;
            DateTime aktuálisBelépés = DateTime.MinValue;
            DateTime aktuálisKilépés = DateTime.MaxValue;
            foreach (var i in a)
            {
                if (i.Azon == inputAzon && i.Irány == "be")
                {
                    aktuálisBelépés = i.Idő;
                    aktuálisKilépés = DateTime.MinValue;
                }
                if (i.Azon == inputAzon && i.Irány == "ki")
                {
                    aktuálisKilépés = i.Idő;
                    társalgóbanTöltöttIdő += aktuálisKilépés - aktuálisBelépés;
                }
            }

            if (aktuálisKilépés == DateTime.MinValue) társalgóbanTöltöttIdő += DateTime.Parse("15:00") - aktuálisBelépés; // Társalgóban "ragadt" személyek
            Console.Write($"A(z) {inputAzon}. személy összesen {társalgóbanTöltöttIdő.TotalMinutes} percet volt bent, ");
            if (aktuálisKilépés == DateTime.MinValue) Console.WriteLine("a megfigyelés végén a társalgóban volt.");
            else Console.WriteLine("a megfigyelés végén nem volt a társalgóban.");
            Console.ReadKey();
        }
    }
}
