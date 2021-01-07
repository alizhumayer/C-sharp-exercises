using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Homerseklet
{
    class Program
    {
        //Lista létrehozása
        static List<HomClass> hLista = new List<HomClass>();

        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("honapok.txt", Encoding.UTF8);
            string sor = ""; //nincs fejléc a fájlban
            while (!sr.EndOfStream)
            {
                sor = sr.ReadLine(); //beolvas egy sort -> "Január;2;5"
                HomClass h = new HomClass(sor);
                hLista.Add(h);
            }

            Console.WriteLine("Összesen ennyi sor volt a fájlban: " + hLista.Count);

            Console.WriteLine("3. feladat");
            for (int i = 0; i < hLista.Count; i++)
            {
                Console.WriteLine(hLista[i].Nev + ": " + hLista[i].KHom);
            }
            Console.WriteLine("3. feladat másként");
            foreach (HomClass h in hLista)
            {
                Console.WriteLine(h.Nev + ": " + h.KHom);
            }

            Console.WriteLine("4. feladat");
            int osszHom = 0;
            int minHom = hLista[0].KHom;
            for (int i = 0; i < hLista.Count; i++)
            {
                osszHom += hLista[i].KHom;
                if (minHom > hLista[i].KHom)
                {
                    minHom = hLista[i].KHom;
                }
            }
            double atlagHom = (double)osszHom / hLista.Count;
            Console.WriteLine("Az átlagos középhőmérséklet: " + Math.Round(atlagHom,2));

            Console.WriteLine("5. feladat");
            Console.WriteLine("A legkisebb középhőmérséklet: " + minHom);


            Console.WriteLine("6. feladat");
            for (int i = 0; i < hLista.Count; i++)
            {
                Console.WriteLine(hLista[i].Nev + ": " + hLista[i].MinHom);
            }

            Console.WriteLine("7. feladat");
            Console.Write("Kérek egy hónapot: ");
            string honap = Console.ReadLine();
            bool megvan = false;
            int index = 0;
            while (megvan == false && index < hLista.Count)
            {
                if (honap == hLista[index].Nev)
                {
                    megvan = true;
                    if (hLista[index].KHom > 10)
                    {
                        Console.WriteLine("Nagyobb volt mint 10!");
                    }
                    else
                    {
                        Console.WriteLine("Nem volt nagyobb mint 10!");
                    }
                }
                index++;
            }
            if (megvan == false)
            {
                Console.WriteLine("Nincs ilyen hónap!");
            }

            Console.ReadKey();
        }
    }
}
