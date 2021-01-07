using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSGradSolutions
{
    [Erettsegi(2008, 5, "SMS", 2)]
    public class Y2008M05
    {
        static string Be = System.IO.Path.Combine(Program.BasePath, "Forrasok\\4_SMS\\sms.txt");
        static string Ki = System.IO.Path.Combine(Program.BasePath, "megoldas\\smski.txt");

        // egy sms-t tároló osztály
        class SMS
        {
            // az sms idöpontja
            public TimeSpan Ido { get; }
            // az uzenet szövege
            public string Uzenet { get; }
            // a küldö telefonszáma
            public string Telefonszam { get; }

            public SMS(TimeSpan ido, string telefonszam, string uzenet)
            {
                Ido = ido;
                Telefonszam = telefonszam;
                Uzenet = uzenet;
            }
        }

        static SMS[] smsek;

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
        }

        static void Feladat1()
        {
            // beolvassuk a fájl tartalmát
            var sorok = System.IO.File.ReadAllLines(Be);
            // meghatározzuk az sms-ek számát a tömb létrehozásához
            smsek = new SMS[int.Parse(sorok[0])];
            for (int i = 0; i < smsek.Length; i++)
            {
                // az sms-hez tartozó elsö sor száma: i. sms*2 + 1 (az elsö sorban az sms-ek száma szerepel)
                var sorszam = i * 2 + 1;
                var sor = sorok[sorszam].Split(' ');
                smsek[i] = new SMS(
                    new TimeSpan(int.Parse(sor[0]), int.Parse(sor[1]), 0),  // az sms idöpontja
                    sor[2],                                                 // telefonszám
                    sorok[sorszam + 1]                                      // az uzenet (a következö sorban)
                    );
            }
        }

        static void Feladat2()
        {
            Kiir(2);
            // az utolsó üzenetet tároló változó
            SMS utolsoSms = null;

            // ha több mint 10 üzenet érkezett, akkor a 10. üzenet az utolsó
            if (smsek.Length > 10)
            {
                // [9], mert a tömb indexelése 0-val kezdödik
                utolsoSms = smsek[9];
            }
            else
            {
                // különben az utoljára érkezett üzenet az utolsó
                utolsoSms = smsek.LastOrDefault();
            }

            // ha nem volt egy üzenet sem
            if (utolsoSms == null)
                Console.WriteLine("A telefon memóriájában nincs üzenet.");
            else
            {
                // az utolsó üzenet kiírása
                Console.WriteLine("A telefon memóriájában található utolsó üzenet:");
                Console.WriteLine(utolsoSms.Uzenet);
            }
        }

        static void Feladat3()
        {
            Kiir(3);
            // az üzeneteket azok hossza szerint növekvö sorba rendezzük
            var sorbaRendezett = smsek.OrderBy(s => s.Uzenet.Length).ToArray();
            // kiválasztjuk az elsö és utolsó üzenetet
            var legrovidebb = sorbaRendezett.First();
            var leghosszabb = sorbaRendezett.Last();
            // kírjuk az üzenetek adatait
            Console.WriteLine("A leghosszabb üzenet:");
            Console.WriteLine($"{leghosszabb.Ido.Hours} {leghosszabb.Ido.Minutes} {leghosszabb.Telefonszam} {leghosszabb.Uzenet}");
            Console.WriteLine("A legrövidebb üzenet:");
            Console.WriteLine($"{legrovidebb.Ido.Hours} {legrovidebb.Ido.Minutes} {legrovidebb.Telefonszam} {legrovidebb.Uzenet}");
        }

        static void Feladat4()
        {
            Kiir(4);
            // tömb, amiben az üzenetek számát tároljuk
            //  0:   1-20
            //  1:  21-40
            //  2:  41-60
            //  3:  61-80
            //  4:  81-100
            int[] hossz = new int[5];
            for (int i = 0; i < smsek.Length; i++)
            {
                // az egészrészes osztást kihasználva egyszerüen növelhetjük a tömb elemeinek értékét. Pl:
                //   1-1/20 = 0
                //  20-1/20 = 0
                //  21-1/20 = 1
                // 100-1/20 = 4
                hossz[(smsek[i].Uzenet.Length - 1) / 20]++;
            }
            for (int i = 0; i < hossz.Length; i++)
            {
                // az üzenetek hosszát a tömb indexéböl ki tudjuk számolni:
                // 0*20+1=1  - (0+1)*20=20
                // 1*20+1=21 - (1+1)*20=40, stb
                // kiírjuk az eredményt
                Console.WriteLine($"{i * 20 + 1}-{(i + 1) * 20}: {hossz[i]}");
            }
        }

        static void Feladat5()
        {
            Kiir(5);
            // a szolgáltatónál maradó sms-ek száma
            int szolgaltato = 0;
            // az aktuális óra és az adott órában érkezö sms-ek száma
            int ora = 0, aktualisSmsek = 0;
            for (int i = 0; i < smsek.Length; i++)
            {
                // ha az i. sms érkezésének órája nem egyezik az épp vizsgált órával
                if (smsek[i].Ido.Hours != ora)
                {
                    // ha több mint 10 sms érkezett, 
                    // akkor a fennmaradó sms-ek számát hozzáadjuk a szolgáltatónál maradt sms-ekhez
                    if (aktualisSmsek > 10)
                        szolgaltato += aktualisSmsek - 10;
                    // az órát az i. sms érkezésének órájára állítjuk
                    ora = smsek[i].Ido.Hours;
                    // visszaállítjuk az aktuális sms-ek számát nullára
                    aktualisSmsek = 0;
                }

                // mednöveljük az adott órában érkezö sms-ek számát 1-el
                aktualisSmsek++;
            }
            // ha az utolsó órában több, mint 10 sms érkezett,
            // akkor a 10-en felüli darabszámot is hozzáadjuk a szolgáltatónál maradók számához
            if (aktualisSmsek > 10)
                szolgaltato += aktualisSmsek - 10;

            // kiírjuk a szolgáltatónál tárolt üzenetek számát
            Console.WriteLine($"Szolgáltatónál tárolt üzenetek száma: {szolgaltato}");
        }

        static void Feladat6()
        {
            Kiir(6);
            // kiválasztjuk a barátnötöl kapott sms-eket
            var baratnoSmsek = smsek.Where(s => s.Telefonszam == "123456789").ToArray();
            
            // ha a barátnö nem küldött legalább 2 sms-t
            if (baratnoSmsek.Length < 2)
            {
                Console.WriteLine("Nincs elegendö üzenet.");
                // ebben az esetben végeztünk a feladattal
                return;
            }

            // eltároljuk a két sms között eltelt idöt 
            // és az utolsó sms érkezésének idöpontját (ami kezdetben az elsö sms idöpontja)
            TimeSpan elteltIdo = TimeSpan.Zero, utolsoSms = baratnoSmsek[0].Ido;
            for (int i = 1; i < baratnoSmsek.Length; i++)
            {
                // kiszámoljuk a i. sms és az utolsó sms között eltelt idöt
                var ido = baratnoSmsek[i].Ido - utolsoSms;
                // ha ez az idö több, mint a tárolt leghosszabb idö, akkor eltároljuk az új idötartamot
                if (ido > elteltIdo)
                    elteltIdo = ido;
                // eltároljuk az i. sms idöpontját, mint az utolsó sms idöpontja
                utolsoSms = baratnoSmsek[i].Ido;
            }

            // kiírjuk a leghosszabb eltelt idöt
            Console.WriteLine($"A lehosszabb eltelt idö: {elteltIdo.Hours} óra {elteltIdo.Minutes} perc");
        }

        static void Feladat7()
        {
            Kiir(7);
            Console.WriteLine("Adja meg az üzenet adatait!");

            // beolvassuk az üzenet adatait
            Console.Write("Óra: ");
            int ora = int.Parse(Console.ReadLine());

            Console.Write("Perc: ");
            int perc = int.Parse(Console.ReadLine());

            Console.Write("Telefonszám: ");
            string telefon = Console.ReadLine();

            Console.Write("Üzenet: ");
            string uzenet = Console.ReadLine();

            // a tömböt listává alakítjuk, hozzáadjuk a beolvasott üzenetet, majd tömbként újra tároljuk
            var lista = smsek.ToList();
            lista.Add(new SMS(new TimeSpan(ora, perc, 0), telefon, uzenet));
            smsek = lista.ToArray();
        }

        static void Feladat8()
        {
            // az üzeneteket telefonszámonként csoportosítjuk
            var csoportok = smsek.GroupBy(s => s.Telefonszam);
            using (var writer = System.IO.File.CreateText(Ki))
            {
                // ´vegigmegyünk a csoportokon, telefonszám szerint rendezve
                foreach (var csoport in csoportok.OrderBy(cs => cs.Key))
                {
                    // kiírjuk a telefonszámot
                    writer.WriteLine(csoport.Key);
                    // majd egyesével kiírjuk az üzeneteket
                    foreach (var sms in csoport)
                    {
                        writer.WriteLine($"{sms.Ido.Hours} {sms.Ido.Minutes} {sms.Uzenet}");
                    }
                }
            }
        }

        static void Kiir(int feladat)
        {
            Console.WriteLine($"{feladat}. feladat");
        }
    }
}
