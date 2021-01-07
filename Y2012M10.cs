using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSGradSolutions
{
    [Erettsegi(2012, 10, "Szín-kép", 3)]
    class Y2012M10
    {
        static string Be = System.IO.Path.Combine(Program.BasePath, "Forrasok\\4_Szinkep\\kep.txt");
        static string Ki = System.IO.Path.Combine(Program.BasePath, "megoldas\\keretes.txt");
        
        // egy színt tároló osztály
        class Szin
        {
            // vörös
            public byte R { get; }
            // zöld
            public byte G { get; }
            // kék
            public byte B { get; }

            public Szin(byte r, byte g, byte b)
            {
                R = r;
                G = g;
                B = b;
            }

            // megadja, hogy ez a szín egy másikkal azonos-e
            public bool Azonos(Szin masik)
            {
                return R == masik.R && G == masik.G && B == masik.B;
            }

            // megadja, hogy ez a szín egy másikkal azonos-e
            public bool Azonos(byte r, byte g, byte b)
            {
                return R == r && G == g && B == b;
            }
        }

        // színeket tároló tömb
        static Szin[] kep;

        static void Main(string[] args)
        {
            Feladat1();
            Feladat2();
            Feladat3();
            Feladat4();
            Feladat5();
            Feladat6();
            Feladat7();
        }

        static void Feladat1()
        {
            // a fájl egyes sorai
            var sorok = System.IO.File.ReadAllLines(Be);
            // annyi szín van, ahány sor a fájlban
            kep = new Szin[sorok.Length];
            for (int i = 0; i < sorok.Length; i++)
            {
                var sor = sorok[i].Split(' ');
                kep[i] = new Szin(
                    byte.Parse(sor[0]), // R
                    byte.Parse(sor[1]), // G
                    byte.Parse(sor[2])  // B
               );
            }
        }

        static void Feladat2()
        {
            Kiir(2);
            Console.WriteLine("Adjon meg egy színt!");
            // beolvasunk 3 értéket (r, g, b)
            Console.Write("R: ");
            byte r = byte.Parse(Console.ReadLine());
            Console.Write("G: ");
            byte g = byte.Parse(Console.ReadLine());
            Console.Write("B: ");
            byte b = byte.Parse(Console.ReadLine());

            // kiírjuk a színt
            Console.Write($"A szín ({r}, {g}, {b}) ");
            // végigmegyünk a képpontokon
            for (int i = 0; i < kep.Length; i++)
            {
                // ha a képpont színe megegyezik a megadottal,
                if (kep[i].Azonos(r, g, b))
                {
                    // akkor kiírjuk, hogy a szín megtalálható a képen
                    Console.WriteLine("megtalálható a képen.");
                    // visszatérünk
                    return;
                }
            }
            // különben kiírjuk, hogy nem található meg a képen
            Console.WriteLine("nem található meg a képen.");
        }

        static void Feladat3()
        {
            Kiir(3);
            // a kép egy pontja (sor*50 + oszlop)
            // a sorok és oszlop indexelése 0-val kezdödik, ezért a 35. sor indexe 34, a 8. oszlopé pedig 7
            var szin = kep[34 * 50 + 7];
            int sorban = 0, oszlopban = 0;

            // sor
            // végigmegyünk a sor képpontjain
            // kezdjük a 34. sor 0. oszlopánál és minden képpontot vizsgálunk a 35. sor 0. oszlopáig
            for (int i = 34 * 50; i < 35 * 50; i++)
            {
                // ha a szín azonos, akkor megnöveljük a sroban található azonos színek számát
                if (kep[i].Azonos(szin))
                    sorban++;
            }

            // oszlop
            // végigmegyünk a 7. oszlopon
            // az a 7. színnél kezdödik, a kép végéig tart és az i változót egy sor hosszával növeljük meg
            // 1. sorban 7, második sorban 57, stb.
            for (int i = 7; i < kep.Length; i += 50)
            {
                // ha a szín azonos, megnöveljük az oszlopban található  azonos színek számát
                if (kep[i].Azonos(szin))
                    oszlopban++;
            }

            // kiírjuk az eredményt
            Console.WriteLine($"A 35. sor 8. oszlopának színének elöfordulása ezen sorokban és oszlopokban:");
            Console.WriteLine($"Sorban: {sorban} Oszlopban: {oszlopban}");
        }

        static void Feladat4()
        {
            Feladat4();
            // a színek találatai
            int voros = 0, zold = 0, kek = 0;
            // a keresett színek
            Szin r = new Szin(255, 0, 0), g = new Szin(0, 255, 0), b = new Szin(0, 0, 255);
            for (int i = 0; i < kep.Length; i++)
            {
                // ha a képpont színe vörös, megnöveljük a vörös találatok számát
                if (r.Azonos(kep[i]))
                    voros++;
                // különben ha zöld, akkör a zöld találatok számát
                else if (g.Azonos(kep[i]))
                    zold++;
                // különben ha kék, akkör a kék találatok számát
                else if (b.Azonos(kep[i]))
                    kek++;
            }

            Console.Write("A képen legtöbbször elöforduló szín a ");
            // a több vörös képpont van mint zöld és kék, akkor a vörös szint írjuk ki
            if (voros >= zold && voros >= kek)
                Console.WriteLine("vörös.");
            // különben ha több zöld van, mint vörös és kék, akkor a zöld színt írjuk ki
            else if (zold >= voros && zold >= kek)
                Console.WriteLine("zöld.");
            // különben a kék színek száma vagy több, vagy egyenlö a vörös és zöld színek számával
            // mivel csak az egyik színt kell kiírni, ezért a kéket írjuk ki
            else
                Console.WriteLine("kék.");
        }

        static void Feladat5()
        {
            // a fekete szín
            var fekete = new Szin(0, 0, 0);
            // végigmegyünk minden képponton
            for (int i = 0; i < kep.Length; i++)
            {
                // meghatározzuk, hogy az melyik sorban/oszlopban található
                // a sorhoz az i-t 50-el osztjuk (egy sorban található színek száma)
                // 0-49=0, 50-99=1, ..., 2450-2499 = 49
                var sor = i / 50;
                // az oszlophoz az 50-el való osztás maradékát vesszük
                // 0 mod 50 = 0, 1 mod 50 = 1, ... 49 mod 50 = 49, 50 mod 5 = 0, stb
                var oszlop = i % 50;

                // a három képpontos kerethez az elsö 3 és utolsó 3 teljes sort,
                // minden más sorban az elsö 3 és utolsó 3 pontot kell feketévé alakítani
                // elsö 3 sor:      sor < 3 (0, 1, 2)
                // utolsó 3 sor:    sor > 46 (47, 48, 49)
                // elsö 3 oszlop:   oszlop < 3 (0, 1, 2)
                // utolsó 3 oszlop: oszlop > 46 (47, 48, 49)
                if (sor < 3 || sor > 46 || oszlop < 3 || oszlop > 46)
                    kep[i] = fekete;
            }
        }

        static void Feladat6()
        {
            // kiírjuk a képet, minden színt szöveggé alakítva ("R G B")
            System.IO.File.WriteAllLines(Ki, kep.Select(p => $"{p.R} {p.G} {p.B}"));
        }

        static void Feladat7()
        {
            Kiir(7);
            // a keresett szín
            var sarga = new Szin(255, 255, 0);
            
            // a bal felsö és a jobb alsó képpont indexe
            int balFelso = -1, jobbAlso = -1;

            // végigmegyünk minden képponton
            for (int i = 0; i < kep.Length; i++)
            {
                // ha a szín sárga
                if (kep[i].Azonos(sarga))
                {
                    // ha ez az elsö sárga képpont, eltároljuk az indexét a bal felsö változóban
                    // a jobb alsó képpontot is eltároljuk
                    if (balFelso == -1)
                        balFelso = jobbAlso = i;
                    // különben ha még ugyanabban a sorban vagyunk, mint az elsö sárga képpont
                    // akkor a jobb alsó képpont értékét egyel növeljük
                    else if (balFelso - balFelso % 50 + 50 > i)
                        jobbAlso++;
                    // különben vagy sort váltottunk, ezért befejezzük a ciklust
                    else
                        break;
                }
                // különben ha már találtunk egy sárga pontot,
                // akkor még ugyanabban a sorban vagyünk, de a szín már nem sárge
                // kilépünk a ciklusból
                else if (balFelso > -1)
                    break;
            }

            // a két változóban most a téglalap bal felsö és jobb felsö pontja található
            // most meg kell állapítanunk a téglalap magasságát
            // ehhez végigmegyünk azon az oszlopon, amelyben a jobb felsö képpont található
            // ezt ugyanúgy végezzük el, mint a 3. feladatban
            // csak nem az elsö sortól kezdünk, hanem a jobb felsö pont utáni sortól
            for (int i = jobbAlso + 50; i < kep.Length; i += 50)
            {
                // ha a szín még sárga
                // akkor eltároljuk az indexét
                if (kep[i].Azonos(sarga))
                    jobbAlso = i;
                // különben végeztünk a ciklussal
                else
                    break;
            }

            Console.WriteLine("A sárga téglalap helye és mérete:");
            // a téglalap helye:
            // x (oszlop):  balFelso % 50
            // y (sor):     balFelso / 50
            // szélesség:   jobbAlso % 50 - x (a jobb alsó képpont oszlopa - x)
            // magasság:    jobbAlso / 50 - y (a jobb alsó képpont sora - y)
            int x = balFelso % 50, y = balFelso / 50, szelesseg = jobbAlso % 50 - x, magassag = jobbAlso / 50 - y;
            // a bal felsö képpont pozíciója, +1 mert a tömb indexelése 0-val kezdödik, de a kiírásnál 1-el
            Console.WriteLine($"Kezd: {y + 1}, {x + 1}");
            // a jobb alsó képpont pozíciója (balFelso + szelesseg|magassag + 1), szintén +1
            Console.WriteLine($"Vége: {y + magassag + 1}, {x + szelesseg + 1}");
            // a képpontok száma (a téglalap területe), +1 mert a "0." sort/oszlopot is figyelembe kell venni
            Console.WriteLine($"Képpontok száma: {(szelesseg + 1) * (magassag + 1)}");
        }

        static void Kiir(int feladat)
        {
            Console.WriteLine($"{feladat}. feladat");
        }
    }
}
