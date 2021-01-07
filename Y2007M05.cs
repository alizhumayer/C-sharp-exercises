using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSGradSolutions
{
    [Erettsegi(2007, 05, "SMS szavak", 2)]
    public class Y2007M05
    {
        static string Be = System.IO.Path.Combine(Program.BasePath, "Forrasok\\4_SMS_szavak\\szavak.txt");
        static string Ki = System.IO.Path.Combine(Program.BasePath, "megoldas\\kodok.txt");

        // az a betü byte-kódja
        static byte a = (byte)'a';
        // az egyes karakterekhez tartozó számok (a-z)
        static byte[] karakterSzam = new byte[] { 2, 2, 2, 3, 3, 3, 4, 4, 4, 5, 5, 5, 6, 6, 6, 7, 7, 7, 7, 8, 8, 8, 9, 9, 9, 9 };

        // az egyes szavak
        static string[] szavak;
        // minden szóhoz tartozó kód
        static string[] kodok;

        static void Main(string[] args)
        {
            Feladat1();
            Feladat2();
            Feladat3();
            Feladat4();
            Feladat5();
            Feladat6();
            Feladat7();
            Feladat8();
            Feladat9();
        }

        static void Feladat1()
        {
            Kiir(1);
            Console.Write("Adjon meg egy betüt: ");
            char c = Console.ReadLine()[0];
            // a karakterhez tartozó szám (karakter - 'a' -> 0..25)
            Console.WriteLine($"A {c} betühöz tartozó szám: {karakterSzam[c - a]}");
        }

        static void Feladat2()
        {
            Kiir(2);
            Console.Write("Adjon meg egy szót: ");
            var szo = Console.ReadLine();
            Console.Write("A szóhoz tartozó számsor: ");
            // végigmegyünk a szó karakterein
            for (int i = 0; i < szo.Length; i++)
            {
                // minden karakterhez kiírjuk a hozzá tartozó számot
                Console.Write(karakterSzam[szo[i] - a]);
            }
            Console.WriteLine();
        }

        static void Feladat3()
        {
            // a szavakat a fájlból a tömbbe olvassuk
            szavak = System.IO.File.ReadAllLines(Be);
        }

        static void Feladat4()
        {
            Kiir(4);
            // a szavakat hosszuk szerint csökkenö sorrendbe rendezzük, majd az elsöt kiválasztjuk
            var leghosszabb = szavak.OrderByDescending(s => s.Length).First();
            // kiírjuk a szót és a hosszát
            Console.WriteLine($"A leghosszabb szó: {leghosszabb}, hossza: {leghosszabb.Length}");
        }

        static void Feladat5()
        {
            Kiir(5);
            // kiválasztjuk a rövid szavakat (hossz <= 5), majd megszámoljuk az eredményt
            var rovidSzavak = szavak.Where(s => s.Length <= 5).Count();
            Console.WriteLine($"Rövid szavak száma: {rovidSzavak}");
        }

        static void Feladat6()
        {
            // létrehozunk egy tömböt az egyes szavak kódjainak tárolására
            kodok = new string[szavak.Length];
            for (int i = 0; i < szavak.Length; i++)
            {
                // az egyes karaktereket számmá alakítjuk, az eredményt pedig szöveggé
                kodok[i] = string.Join("", szavak[i].Select(s => karakterSzam[s - a]));
            }

            // a kódokat fájlba írjuk
            System.IO.File.WriteAllLines(Ki, kodok);
        }

        static void Feladat7()
        {
            Kiir(7);
            Console.Write("Adjon meg egy számsort: ");
            string szamsor = Console.ReadLine();
            Console.WriteLine("A számsorhoz tartozó szavak:");
            Console.WriteLine(string.Join(", ", SzamsorKeresese(szamsor)));
        }

        static IEnumerable<string> SzamsorKeresese(string szamsor)
        {
            for (int i = 0; i < kodok.Length; i++)
            {
                // ha a számsor megegyezik az i. kóddal
                if (kodok[i] == szamsor)
                {
                    // akkor visszaadjuk az i. szót (amihez a számsor tartozik)
                    yield return szavak[i];
                    // a yield return kulcsszavakkal egy enumerable jön létre, aminek elemein egy ciklussal végig lehet menni
                }
            }
        }

        static void Feladat8()
        {
            Kiir(8);
            // a kódokat csoportosítjuk
            var csoportok = kodok.Select((k, i) => new { kod = k, szo = szavak[i] }).GroupBy(i => i.kod);
            // a StringBuilder-t használjuk az eredmény szövegének összeállításához
            var sb = new StringBuilder();
            // majd kiválsztjuk azokat, amelyekböl több mint 1 van
            foreach (var csoport in csoportok.Where(cs => cs.Count() > 1))
            {
                // ha nem az elsö csoportot vizsgáljuk, akkor az eredményhez egy kettöspont+szóközt adunk
                if (sb.Length > 0)
                    sb.Append("; ");
                // a csoportot szöveggé alakítjuk
                // az egyes szavakból alkotott szövegeket ;+szóközzel elválasztva az eredményhez adjuk
                sb.Append(string.Join("; ", csoport.Select(cs => $"{cs.szo} : {csoport.Key}")));
            }
            // kiírjuk az eredményt
            Console.WriteLine(sb);
        }

        static void Feladat9()
        {
            Kiir(9);
            // a kódokat ismét csoportosítjuk
            var csoportok = kodok.Select((k, i) => new { kod = k, szo = szavak[i] }).GroupBy(cs => cs.kod);
            // elemek száma szerint csökkenö sorba rendezzük és az elsöt kiválasztjuk
            var kodLegtobbSzoval = csoportok.OrderByDescending(cs => cs.Count()).First();
            // kiírjuk a csoporthoz tartozó kódok
            Console.WriteLine($"A legtöbb szó a(z) {kodLegtobbSzoval.Key} kódhoz tartozik:");
            // a csoportban található szavakat vesszövel elválasztva szöveggé alakítjuk és kiírjuk
            Console.WriteLine(string.Join(", ", kodLegtobbSzoval.Select(cs => cs.szo)));
        }

        static void Kiir(int feladat)
        {
            Console.WriteLine($"{feladat}. feladat");
        }
    }
}
