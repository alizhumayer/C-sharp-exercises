using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Erettsegi39_Kerites_Csharp
{
    class Telek
    {
        public int Házszám { get; private set; }
        public int Szélesség { get; private set; }
        public char Szín { get; private set; }
        public Telek(string[] m, ref int házszám)
        {
            Szélesség = int.Parse(m[1]);
            Szín = m[2][0];
            Házszám = házszám;
            házszám += 2;
        }
        public bool EzPáratlan => Házszám % 2 == 1;
    }

    class Utca
    {
        static void Main()
        {
            List<Telek> telkek = new List<Telek>(); // telkeket tároló lista
            int aktuálisPáratlan = 1, aktuálisPáros = 2;
            foreach (var i in File.ReadAllLines("kerites.txt"))
            {
                if (i[0] == '1') telkek.Add(new Telek(i.Split(), ref aktuálisPáratlan));
                else telkek.Add(new Telek(i.Split(), ref aktuálisPáros));
            }

            Console.WriteLine($"2. feladat\nEladott telkek száma: {telkek.Count}");

            Console.WriteLine($"\n3. feladat\nA {(telkek.Last().EzPáratlan ? "páratlan" : "páros")} oldalon adták el az utolsó telket.");
            Console.WriteLine($"Az utolsó telek házszáma: {telkek.Last().Házszám}");
            Console.Write("\n4.feladat\nA szomszédossal egyezik a kerítés színe: ");
            var páratlanTelkek = telkek.Where(x => x.EzPáratlan).ToList();
            for (int i = 0; i < páratlanTelkek.Count; i++)
            {
                if (char.IsLetter(páratlanTelkek[i].Szín) && páratlanTelkek[i].Szín == páratlanTelkek[i + 1].Szín)
                {
                    Console.WriteLine(páratlanTelkek[i].Házszám);
                    break;
                }
            }

            Console.Write("\n5.feladat\nAdjon meg egy házszámot! ");
            int házszámInput = int.Parse(Console.ReadLine());
            var keresettTelek = telkek.Where(x => x.Házszám == házszámInput).First(); // ilyen biztosan lesz
            var balSzomszéd = telkek.Where(x => x.Házszám == házszámInput - 2).FirstOrDefault(); // ilyen lehet nincs
            var jobbSzomszéd = telkek.Where(x => x.Házszám == házszámInput + 2).FirstOrDefault(); // ilyen lehet nincs
            HashSet<char> lehetségesSzínek = new HashSet<char>("ABCD".ToCharArray()); // legalább egy szín marad a festéshez
            lehetségesSzínek.Remove(keresettTelek.Szín);
            if (balSzomszéd != null) lehetségesSzínek.Remove(balSzomszéd.Szín);
            if (jobbSzomszéd != null) lehetségesSzínek.Remove(jobbSzomszéd.Szín);
            Console.WriteLine($"A kerítés színe / állapota: {keresettTelek.Szín}");
            Console.WriteLine($"Egy lehetséges festési szín: {lehetségesSzínek.First()}");

            string sor1 = "", sor2 = "";
            foreach (var i in páratlanTelkek)
            {
                sor1 += "".PadRight(i.Szélesség, i.Szín);
                sor2 += i.Házszám.ToString().PadRight(i.Szélesség, ' ');
            }
            File.WriteAllText("../../utcakep.txt", $"{sor1}\n{sor2}");
            Console.ReadKey();
        }
    }
}
