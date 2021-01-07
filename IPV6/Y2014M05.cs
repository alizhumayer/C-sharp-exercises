using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSGradSolutions
{
    [Erettsegi(2014, 5, "IPv6", 5)]
    class Y2014M05
    {
        static string Be = System.IO.Path.Combine(Program.BasePath, "Forrasok\\4_IPv6\\ip.txt");
        static string Ki = System.IO.Path.Combine(Program.BasePath, "megoldas\\sok.txt");

        // az IP címeket tároló tömb
        static string[] ipCimek;

        static void Main(string[] args)
        {
            Feladat1();
            Feladat2();
            Feladat3();
            Feladat4();
            Feladat5();
            var ip = Feladat6();
            Feladat7(ip);
        }


        static void Feladat1()
        {
            // az összes IP cím beolvasása
            ipCimek = System.IO.File.ReadAllLines(Be);
        }

        static void Feladat2()
        {
            Kiir(2);
            // az IP címek számának kiírása
            Console.WriteLine($"Az állományban {ipCimek.Length} darab adatsor van.");
            Console.WriteLine();
        }

        static void Feladat3()
        {
            Kiir(3);
            // a legalacsonyabb IP címet tároló változó
            string legalacsonyabbIP = ipCimek[0];

            // Példa:
            // cim1: abcd
            // cim2: aacd
            // cim3: bacd
            // cim4: aaca

            // legalacsonyabb: abcd
            // cim2: a=a, a<b -> legacsonyabb: aacd
            // cim3: a<b -> legalacsonyabb: aacd
            // cim4: a=a, a=a, c=a, d>a -> legalacsonyabb: aaca

            // végigmegyün kaz összes címen
            for (int i = 1; i < ipCimek.Length; i++)
            {
                // majd a i. cím karakterein
                for (int j = 0; j < legalacsonyabbIP.Length; j++)
                {
                    // ha az eddigi legalacsonyabb cím karaktere alacsonyabb, mint az i. címé
                    if (legalacsonyabbIP[j] < ipCimek[i][j])
                    {
                        // akkor az i. cím magasabb, mint az eddigi legalacsonyabb
                        // kilépünk a karakter-ciklusból
                        break;
                    }
                    // különben ha az eddigi legalacsonyabb cím karaktere nagyobb, mint az i. címé
                    else if (legalacsonyabbIP[j] > ipCimek[i][j])
                    {
                        // akkor az i. cím alacsonyabb, eltároljuk
                        legalacsonyabbIP = ipCimek[i];
                        // kilépünk a karakter-ciklusból
                        break;
                    }
                }
            }
            // kiírjuk a címet
            Console.WriteLine("A legalacsonyabb tárolt IP-cím:");
            Console.WriteLine(legalacsonyabbIP);
            Console.WriteLine();
        }

        static void Feladat4()
        {
            Kiir(4);
            // az egyes tartományokhoz tartozó címek száma
            int dokumentacios = 0, eszkozokGlobalis = 0, eszkozokHelyi = 0;
            for (int i = 0; i < ipCimek.Length; i++)
            {
                // ha a cím elején 2001:0db8 áll (kezdet: IndexOf()=0)
                if (ipCimek[i].IndexOf("2001:0db8") == 0)
                    dokumentacios++;
                // különben ha a cím elején 2001:0e áll
                else if (ipCimek[i].IndexOf("2001:0e") == 0)
                    eszkozokGlobalis++;
                // különben ha a cím eljén fc vagy fd áll
                else if (ipCimek[i].IndexOf("fc") == 0 || ipCimek[i].IndexOf("fd") == 0)
                    eszkozokHelyi++;
            }
            // kiírjuk az egyes tartományokhoz tartozó címek számát
            Console.WriteLine($"Dokumentációs cím: {dokumentacios} darab");
            Console.WriteLine($"Globális egyedi cím: {eszkozokGlobalis} darab");
            Console.WriteLine($"Helyi egyedi cím: {eszkozokHelyi} darab");
            Console.WriteLine();
        }

        static void Feladat5()
        {
            using (var writer = System.IO.File.CreateText(Ki))
            {
                // vegigmegyünk a címeken
                for (int i = 0; i < ipCimek.Length; i++)
                {
                    // az adott címben található nullák száma
                    int nullak = 0;
                    // végigmegyünk a cím karakterein
                    for (int j = 0; j < ipCimek[i].Length; j++)
                    {
                        // ha az adott karakter 0
                        if (ipCimek[i][j] == '0')
                        {
                            // megnöveljük a nullák számát
                            nullak++;
                            // ha nullák száma 18 vagy több
                            if (nullak >= 18)
                            {
                                // kiírjuk a címet a fájlba
                                writer.WriteLine($"{i + 1} {ipCimek[i]}");
                                // kilépünk a karakter-ciklusból
                                break;
                            }
                        }
                        // ha nincs már elég karakter, hogy elérjük a 18 db nullát, akkor is kiléphetünk a ciklusból
                        if (18 - nullak + j >= ipCimek[i].Length)
                            break;
                    }
                }
            }
        }

        static short[] Feladat6()
        {
            Kiir(6);
            Console.Write("Kérek egy sorszámot: ");
            // beolvasunk egy sorszámot, amit 1-el csökkentünk a tömb indexelése miatt
            var sorszam = int.Parse(Console.ReadLine()) - 1;
            // a címet szám tömbbé alakítjuk
            var ip = StringToInt32Tomb(ipCimek[sorszam]);
            // kiírjuk a címet
            Console.WriteLine(ipCimek[sorszam]);
            // a szám tömböt hexadecimális szöveggé alakítjuk, bevezetö nullák nélkül, 
            // majd ezeket kettösponttal összekapcsolt szöveggé alakítjuk és kiírjuk
            Console.WriteLine(string.Join(":", ip.Select(x => x.ToString("x"))));
            Console.WriteLine();

            return ip;
        }

        static void Feladat7(short[] ip)
        {
            Kiir(7);

            // ez az összes feladat közül a legnehezebb
            // a feladat lényege, hogy meghatározzuk, hogy hol van a címben a legtöbb 0 csoport egymás után
            // mivel a címet számokká alakítottuk, ezért csak azt kell figyelnünk, hogy az adott szám nulla-e
            // ehhez egy 8 elemü tömböt készítünk.
            // a tömb minden eleme azt adja meg, hogy az adott indexen lévö szám a tömbben hányadik 0 (ha a szám nulla, különben a tömb eleme 0)
            // a feladatban példájában szereplö cím: 2001:0000:0000:00f5:0000:0000:0000:0123
            // szám tömbbé alakítva: [8193, 0, 0, 245, 0, 0, 0, 291]
            // ezen a tömb elemeit fogjuk vizsgálni, ha találunk egy elemet, ami 0, megjegyezzük ennek a pozícióját
            // majd addig haladunk tovább, amíg egy olyan számot nem találunk, ami nem 0
            // ezután meghatározzuk a 0 csoport hosszát, ha ez nagyobb, mint az elözö csoport hossza,
            // akkor eltároljuk a csoport elejét és a hosszát
            // a ciklus végén megnézzük, hogy van-e az aktualisIndexnek -1-nél nagyobb értéke,
            // ha igen, akkor a cím végén is 0-k vannak
            // ha a cím végi 0 csoportok száma > 1 && > max, akkor ezt az értéket tároljuk
            // ezzel megállapítottuk, hogy hol van a címben az leghosszabb 0-s csoport
            // a példában maxIndex = 4, max = 3
            // ha a maxIndex>-1, akkor a cím tovább rövidíthetö
            // ehhez elöször 0. indextöl a maxIndex-ig minden elemet kiírunk hexadecimális szöveggé alakítva
            // ez azt jelenti, hogy a 0-tól 4-ig kiírjuk az értékeket majd kiírunk mindegyik után egy kettöspontot:
            //     0: 2001, 1: 0, 2: 0, 3: f5 -> 2001:0:0:f5:
            // ha a lehosszabb nulla csoport a cím elején lenne, akkor az eddigi eredmény üres, ezért ezt egy kettöspontra változtatjuk
            // majd kiírjuk a maxIndex+max utáni csoportokat, egy kettösponttal az elején
            // azaz maxIndex+hossz - 8-ig (4+3=7) -> 7-8-ig (<8!)
            //      7: 291 -> :123
            // ha az így kapott címünk kettösponttal végzödne, akkor az utolsó nullás csoport volt a leghosszabb, tehát a végéhez kel legy kettöspontot füznünk
            // az eredmény pedig 2001:0:0:f5::123 lesz
            // ezzek akár olyan címek is rövidíthetöek, mint a loopback (::1), unspecified (::), stb.

            int maxIndex = -1, max = 1,
                aktualisIndex = -1;

            // végigmegyünk az egyes számokon
            for (int i = 0; i < ip.Length; i++)
            {
                // ha a szám 0
                if (ip[i] == 0)
                {
                    // akkor az aktualisIndex-ben eltároljuk az i értékét, ha az -1 (ez az elsö 0, amit épp vizsgálunk)
                    if (aktualisIndex == -1)
                        aktualisIndex = i;
                }
                // különben, ha az aktuális index > -1 (volt 0 az i. elem elött)
                else if (aktualisIndex > -1)
                {
                    // a 0-k száma az i. pozíció elött
                    var hossz = i - aktualisIndex;
                    // mivel a max értékét egyre állítottuk, így azt nem kell vizsgálnunk, hogy a 0-k száma egynél nagyobb, mivel max már 1
                    if (hossz > max)
                    {
                        // eltároljuk a 0-k számát és azok kezdeztét
                        max = hossz;
                        maxIndex = aktualisIndex;
                    }
                    // visszaállítjuk az aktuális index értékét -1-re
                    aktualisIndex = -1;
                }
            }
            // a ciklus után megvizsgáljuk, hogy a cím végén 0-k vannak-e
            if (aktualisIndex > -1)
            {
                var hossz = ip.Length - aktualisIndex;
                // ha a cím végén több 0 van, mint eddig bárhol a címben, akkor eltároljuk azok számát és kezdetét
                if (hossz > max)
                {
                    maxIndex = aktualisIndex;
                    max = hossz;
                }
            }

            // ha maxIndex > -1, akkor van legalább egy olyan csoport, ami több mint egy 0-t tartalmaz
            if (maxIndex > -1)
            {
                // a röviditett cím
                string cim = "";
                // végigmegyünk a cím számain 0-tól maxIndex-ig (a példában 4-ig)
                for (int i = 0; i < maxIndex; i++)
                {
                    // a címhez adjuk az adott pozícióban lévö számot és egy kettöspontot
                    cim += $"{ip[i]:x}:";
                }
                // ha a cím üres, akkor a leghosszabb nullás csoport a cím elején van (pl. localhost IPv6 = ::1)
                // a címet egy kettöspontra változtatjuk
                if (cim.Length == 0)
                    cim = ":";
                // végigmegyünk a maradék számokon a maxIndex utánival kezdve
                for (int i = maxIndex + max; i < ip.Length; i++)
                {
                    // a címhez hozzáadjuk a maradék számokat egy kettösponttal az elején
                    cim += $":{ip[i]:x}";
                }
                // ha a cím utolsó karaktere egy kettöspont, akkor a végéhez hozzáadunk még egy kettöspontot (pl 2001:0:0:f5::)
                if (cim[cim.Length - 1] == ':')
                    cim += ":";
                // kiírjuk a címet
                Console.WriteLine(cim);
            }
            // különben a cím nem rövidíthetö tovább
            else
                Console.WriteLine("Nem rövidíthető tovább.");
        }

        static short[] StringToInt32Tomb(string ip)
        {
            short[] tomb = new short[8];
            // a címet a kettöspontok mentén szétválasztjuk
            var s = ip.Split(':');
            for (int i = 0; i < s.Length; i++)
            {
                // minden elemet számmá akalítunk (16 -> hexadecimális szám)
                tomb[i] = Convert.ToInt16(s[i], 16);
            }
            return tomb;
        }

        static void Kiir(int feladat)
        {
            Console.WriteLine($"{feladat}. feladat");
        }
    }
}
