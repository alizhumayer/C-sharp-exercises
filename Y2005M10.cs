using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSGradSolutions
{
    [Erettsegi(2005, 10, "Vigenère tábla", 2)]
    public class Y2005M10
    {
        static string Be = System.IO.Path.Combine(Program.BasePath, "Forrasok\\4_Vigenere\\Vtabla.dat");
        static string Ki = System.IO.Path.Combine(Program.BasePath, "megoldas\\kodolt.dat");

        static Dictionary<char, Dictionary<char, char>> tabla = new Dictionary<char, Dictionary<char, char>>();

        static void Main(string[] args)
        {
            var nyiltSzoveg = Feladat1();
            var atalakitottNyiltSzoveg = Feladat2(nyiltSzoveg);
            Kiir(3);
            // kiírjuk az átalakított szöveget
            Console.WriteLine(atalakitottNyiltSzoveg);

            var kulcs = Feladat4();

            Kiir(5);
            var teljesKulcs = Feladat5(kulcs, atalakitottNyiltSzoveg.Length);
            // kiírjuk a kulcsot
            Console.WriteLine(teljesKulcs);

            Beolvas();
            Kiir(7);
            Feladat67(atalakitottNyiltSzoveg, teljesKulcs);
        }

        static void Beolvas()
        {
            var sorIndex = 0;
            var sorok = System.IO.File.ReadAllLines(Be);
            // két ciklussal végig megyünk az angol ABC nagybetüin
            // a külsö ciklus a sorok, a belsö az oszlopok betüt jelenti
            for (char i = 'A'; i <= 'Z'; i++)
            {
                var oszlopIndex = 0;
                tabla.Add(i, new Dictionary<char, char>());
                for (char j = 'A'; j <= 'Z'; j++)
                {
                    // a tablaba irjuk a megfelelö karaktereket
                    tabla[i][j] = sorok[sorIndex][oszlopIndex];
                    oszlopIndex++;
                }
                sorIndex++;
            }
        }

        static string Feladat1()
        {
            Kiir(1);
            Console.Write("Adja meg a nyílt szöveget: ");
            var result = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(result) || result.Length > 255)
            {
                Console.WriteLine("Érvénytelen szöveg. A megadott szöveg nem lehet üres és nem lehet 255 karakternél hosszabb.");
                return Feladat1();
            }
            return result;
        }

        static string Feladat2(string eredeti)
        {
            string eredmeny = "";
            // a szöveget nagybetüssé alakítjuk
            eredeti = eredeti.ToUpper();
            for (int i = 0; i < eredeti.Length; i++)
            {
                char c = eredeti[i];
                // az ékezetes karaktereket átalakítjuk
                switch (c)
                {
                    case 'Á': c = 'A'; break;
                    case 'É': c = 'E'; break;
                    case 'Í': c = 'I'; break;
                    case 'Ó':
                    case 'Ö':
                    case 'Ő':
                        c = 'O'; break;
                    case 'Ú':
                    case 'Ü':
                    case 'Ű':
                        c = 'U'; break;
                }
                // a betüket az eredményhez adjuk, minden más karaktert figyelmen kívül hagyunk
                if (c >= 'A' && c <= 'Z')
                    eredmeny += c.ToString();
            }
            return eredmeny;
        }

        static string Feladat4()
        {
            Kiir(4);
            Console.Write("Adja meg a kulcsszót: ");
            // a beolvasott szöveget nagybetüsse alakítjuk
            return Console.ReadLine().ToUpper();
        }

        static string Feladat5(string kulcs, int length)
        {
            Kiir(5);
            var result = "";
            // a kulcsszót addig ismételjük, míg legalább olyan hosszú lesz, mint a nyilt szöveg
            while (result.Length < length)
            {
                result += kulcs;
            }
            // a végéröl levágjuk a felesleges karaktereket
            return result.Substring(0, length);
        }

        static void Feladat67(string nyilt, string kulcs)
        {
            Kiir(6);
            // a kódolt szöveg karaktereit tartalmazó tömb
            char[] eredmeny = new char[nyilt.Length];
            // végig megyünk a nyilt szöveg karakterein (a kulcs hossza egyenlö a nyílt szövegével) 
            for (int i = 0; i < nyilt.Length; i++)
            {
                // a tábla tartalmazza a kódoláshoz szükséges karaktereket
                // elöször a nyílt szöveg karakterét használjuk, hogy megkapjuk a kulcshoz tartozó sort
                // majd ebben megkeressük a kulcsó karakterét
                eredmeny[i] = tabla[nyilt[i]][kulcs[i]];
            }
            // kiírjuk az eredményt
            Console.WriteLine(eredmeny);
            // az eredményt szöveggé alakítjuk és fájlba írjuk
            System.IO.File.WriteAllText(Ki, new string(eredmeny));
        }

        static void Kiir(int feladat)
        {
            Console.WriteLine($"{feladat}. feladat");
        }
    }
}
