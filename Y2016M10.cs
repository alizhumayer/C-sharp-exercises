using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSGradSolutions
{
    [Erettsegi(2016, 10, "Telefonos ügyfélszolgálat", 3)]
    class Y2016M10
    {
        static string Be = System.IO.Path.Combine(Program.BasePath, "Forrasok\\4_Telefonos_ugyfelszolgalat\\hivas.txt");
        static string Ki = System.IO.Path.Combine(Program.BasePath, "megoldas\\sikeres.txt");

        // egy telefonhívás adatait tartalmazó osztály
        class Telefonhivas
        {
            // a hívás kezdete
            public int Kezdet { get; }
            // a hívás vége
            public int Befejezes { get; }
            // fogadva lett-e a hívás
            public bool Fogadva { get; }

            public Telefonhivas(int kezdet, int befejezes, bool fogadva)
            {
                Kezdet = kezdet;
                Befejezes = befejezes;
                Fogadva = fogadva;
            }

            public override string ToString()
            {
                return $"{(Fogadva ? "F " : "")} {Kezdet}-{Befejezes}";
            }
        }

        // a hívásokat tároló lista
        static List<Telefonhivas> hivasok = new List<Telefonhivas>();

        static void Main(string[] args)
        {
            Feladat2();
            Feladat3();
            Feladat4();
            Feladat5();
            Feladat6();
            Feladat7();
        }

        static void Feladat2()
        {
            using (var reader = System.IO.File.OpenText(Be))
            {
                // a munkaidö kezdetét, végét és az utolsó fogadott hívás végét tároló változók
                int munkaidoKezdete = 8 * 3600, munkaidoVege = 12 * 3600, utolsoBeszelgetesVege = munkaidoKezdete;
                while (!reader.EndOfStream)
                {
                    // egy sor adatai szóközzel tagolva
                    var sor = reader.ReadLine().Split(' ');
                    // a hívás kezdete
                    var kezdet = mpbe(int.Parse(sor[0]), int.Parse(sor[1]), int.Parse(sor[2]));
                    // a hívás vége
                    var befejezes = mpbe(int.Parse(sor[3]), int.Parse(sor[4]), int.Parse(sor[5]));
                    // a hívás akkor lett fogadva, ha a hívásnak az utolsó fogadott hívás után lett vége, de a munkaidö vége elött kezdödött
                    var fogadva = befejezes > utolsoBeszelgetesVege && kezdet < munkaidoVege;
                    // ha a hívás fogadva lett, akkor eltároljuk befejezését
                    if (fogadva)
                        utolsoBeszelgetesVege = befejezes;
                    // hozzáadjuk a hívást a listához
                    hivasok.Add(new Telefonhivas(kezdet, befejezes, fogadva));
                }
            }
        }

        static void Feladat3()
        {
            Kiir(3);
            // a nap óráiban kezdett hívások számát tároló tömb
            int[] orak = new int[24];
            // végigmegyünk a hívásokon
            for (int i = 0; i < hivasok.Count; i++)
            {
                // a hívás orája Kezdet/3600 (mint a visszaalakításnál)
                // az órák 0-val kezdödnek, ezért nem kell -1
                // a megfelelö óra hivásait 1-el megemeljük
                orak[hivasok[i].Kezdet / 3600]++;
            }
            // végigmegyünk az órákon
            for (int i = 0; i < orak.Length; i++)
            {
                // ha volt az adott órában hívás
                // kiírjuk az órát és a hívások számát
                if (orak[i] > 0)
                    Console.WriteLine($"{i} óra {orak[i]} hívás");
            }
        }

        static void Feladat4()
        {
            Kiir(4);
            // a leghosszabb hívás indexe és hossza
            int index = 0, hossz = hivasok[0].Befejezes - hivasok[0].Kezdet;
            for (int i = 1; i < hivasok.Count; i++)
            {
                // az i. hívás hossza
                var aktHossz = hivasok[i].Befejezes - hivasok[i].Kezdet;
                // ha az aktuális hívás hosszabb volt, mint az eddigi leghosszabb
                if (aktHossz > hossz)
                {
                    // eltároljuk az indexét és a hosszát
                    index = i;
                    hossz = aktHossz;
                }
            }
            // kiírjuk a hívás sorszámát (+1!) és a hosszát
            Console.WriteLine($"A leghosszabb ideig vonalban lévö hívó {index + 1}. sorban szerepel, a hívás hossza: {hossz} másodperc.");
        }

        static void Feladat5()
        {
            Kiir(5);
            Console.Write("Adjon meg egy idöpontot! (óra perc másodperc) ");
            // beolvasunk egy idöpontot (pont úgy, mint a fájlból)
            var sor = Console.ReadLine().Split(' ');
            var mp = mpbe(int.Parse(sor[0]), int.Parse(sor[1]), int.Parse(sor[2]));

            // az éppen vonalban lévö indexe és a várakozók száma
            int index = -1, varakozok = 0;
            // végigmegyünk az összes híváson
            for (int i = 0; i < hivasok.Count; i++)
            {
                // ha a hívás a megadott idöpont elött kezdödött és utána ért véget
                if (hivasok[i].Kezdet <= mp && hivasok[i].Befejezes > mp)
                {
                    // ha a hívás fogadva lett, akkor ez az éppen vonalban lévö indexe
                    if (hivasok[i].Fogadva)
                        index = i;
                    // különben az adott személy várakozott
                    else
                        varakozok++;
                }
                // ha a hívás a megadott idö után kezdödött, akkor végeztünk a ciklussal
                // (a hívások a hivás kezdete szerint vannak rendezve, tehát ezután már csak olyan hívások vannak,
                //  amik nem kezdödhettek a megadott idö elött)
                if (hivasok[i].Kezdet > mp)
                    break;
            }

            // ha találtunk olyan hívást, ami fogadva lett, akkor kiírjuk a várakozók számát és a hívás sorszámát (+1!)
            if (index > -1)
                Console.WriteLine($"A várakozók száma: {varakozok} a beszélö a(z) {index + 1}. hívó.");
            // ha nem volt senki vonalban, akkor senki nem is várakozott
            else
                Console.WriteLine($"Nem volt beszélő.");
        }

        static void Feladat6()
        {
            Kiir(6);
            // az utolsó és az az elötti fogadott hívás indexe
            int utolsoIndex = -1, elozoIndex = -1;
            // végigmegyünk a hívásokon visszafelé
            for (int i = hivasok.Count - 1; i >= 0; i--)
            {
                // ha a hívás fogadva lett
                if (hivasok[i].Fogadva)
                {
                    // ha ez az elsö fogadott hívás amit találunk (azaz az utolsó)
                    // akkor eltároljuk az indexét
                    if (utolsoIndex == -1)
                        utolsoIndex = i;
                    else
                    {
                        // különben ez az utolsó elötti
                        // eltároljuk ennek is az indexét
                        elozoIndex = i;
                        // és kilépünk a ciklusból
                        break;
                    }
                }
            }

            // az utlosó elötti hívás vége
            // ha nem lenne ilyen, akkor a munkaidö kezdete
            int elozoHivasVege = elozoIndex > -1 ? hivasok[elozoIndex].Befejezes : 8 * 3600;
            // a várakozás ideje:
            //      ha az utolsó hívás az elözö vége után kezdödött, akkor 0,
            //      különben az elözö hívás vége - az utolsó hívás kezdete
            int varakozas = hivasok[utolsoIndex].Kezdet >= elozoHivasVege ? 0 : elozoHivasVege - hivasok[utolsoIndex].Kezdet;
            // kiírjuk az eredményt (+1!)
            Console.WriteLine($"A(z) utolsó telefonáló adatai a(z) {utolsoIndex + 1}. sorban vannak, {varakozas} másodpercig várt.");
        }

        static void Feladat7()
        {
            // az utolsó hívás vége (a munkaidö kezdete)
            int utolsoVege = 8 * 3600;
            using (var writer = System.IO.File.CreateText(Ki))
            {
                // végigmegyünk a hívásokon
                for (int i = 0; i < hivasok.Count; i++)
                {
                    // ha a hívás fogadva lett
                    if (hivasok[i].Fogadva)
                    {
                        // az mpbol függvény ezért adja vissza az eredményt szövegként
                        // ha a hívás kezdete az elözö hívás vége elött kezdödött, 
                        // akkor a beszélgetés kezdete az utolsó hívás vége
                        if (hivasok[i].Kezdet < utolsoVege)
                            writer.Write(mpbol(utolsoVege));
                        // különben a hívás kezdete
                        else
                            writer.Write(mpbol(hivasok[i].Kezdet));
                        // egy szóköz
                        writer.Write(" ");
                        // az utolsó hívás vége az aktuális hívás vége
                        utolsoVege = hivasok[i].Befejezes;
                        // kiírjuk a hívás végét is a fájlba
                        writer.WriteLine(mpbol(utolsoVege));
                    }
                }
            }
        }

        static int mpbe(int o, int p, int mp)
        {
            // kiszámítjuk hogy hány másodperc a megadott óra perc másodperc
            // egy óra: 3600mp
            // egy perc: 60mp
            return o * 3600 + p * 60 + mp;
        }

        static string mpbol(int mp)
        {
            // visszaalakítjuk a másodpercet órára, percre és másodpercre
            // óra: másodperc / 3600
            int o = mp / 3600;
            // a másodpercekböl kivonjuk az óra*3600 másodpercet
            mp -= 3600 * o;
            // perc: fennmaradó másodpercek / 60
            int p = mp / 60;
            // másodperc: másodpercek mod 60
            mp = mp % 60;
            // visszaadjuk az eredményt szövegként
            return $"{o} {p} {mp}";
        }

        static void Kiir(int feladat)
        {
            Console.WriteLine($"{feladat}. feladat");
        }
    }
}
