using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace egyszamjatek
{
    class jatekos
    {
        public string nev { get; private set; }
        public List<int> tippek { get; private set; }
        public int fordulokszama { get { return tippek.Count - 1; } }
        public jatekos(string sor)
        {
            string[] m = sor.Split();
            nev = m[m.Length - 1];
            tippek = new List<int>();
            tippek.Add(-1);//a forduló sorszáma egyenlő lesz az indexxel
            for(int i = 0; i < m.Length - 1; i++)
            {
                tippek.Add(int.Parse(m[i]));
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //2.feladat
            List<jatekos> t = new List<jatekos>();
            foreach (var i in File.ReadAllLines("egyszamjatek.txt")) 
            {
                t.Add(new jatekos(i));
                Console.WriteLine(" {0} ",i);//sorok kiíratása
            }
            //3. feladat: a játékban hány játékos vett részt
            Console.WriteLine("3. feladat: játékosok száma: {0}",t.Count());
            //4. feladat: hány fordulót játszottak a játékosok
            Console.WriteLine("4. feladat: fordulók száma:  {0} ", t[0].fordulokszama);
            //5. feladat Az első fordulóban volt-e 1-es tipp
            bool voltegyes = false;
            foreach(var i in t)
            {
                if (i.tippek[1] == 1)
                {
                    voltegyes = true;
                    break;
                }

            }
            Console.WriteLine("5. feladat: az első fordulóban {0} volt egyes tipp!", voltegyes?"":"nem");
            //6. feladat legnagyobb tipp
            int max = 0;
            foreach (var i in t)
            {
                foreach(var j in i.tippek)
                {
                    if (j > max) max = j;
                }

            }
            Console.WriteLine("6. feladat: legnagyobb tipp a fordulók során: {0}", max);
            //7. feladat: forduló sorszámának bekérése (N)
            Console.Write("7. feladat: Kérem a forduló sorszámát [1-{0}]: ",t[0].fordulokszama);
            int fordulosorszama = int.Parse(Console.ReadLine());
            //Ha a beadott sorszám nem felel meg a lehetséges értékeknek akkor 1-el számolunk
            if (fordulosorszama < 1 || fordulosorszama > t[0].fordulokszama) fordulosorszama = 1;
            //8. feladat: melyik volt a nyertes tipp az N. fordulóban
            int[] stat = new int[100];
            foreach(var i in t)
            {
                stat[i.tippek[fordulosorszama]]++;
            }
            int nyertestipp = -1;
            for(int i = 1; i < stat.Length; i++)
            {
                if (stat[i] == 1)
                {
                    nyertestipp = i;
                    break;
                }
            }
            if (nyertestipp != -1) Console.WriteLine("8. feladat: A nyertes tipp a megadott fordulóban: {0}",nyertestipp);
            else Console.WriteLine("8. feladat: A megadott fordulóban nem volt egyedi tipp ");
            //9. feladat nyertes játékos neve az N. forulóban
            string fordulonyertese = "";
            if (nyertestipp != -1)
            {
                foreach(var i in t)
                {
                    if (i.tippek[fordulosorszama] == nyertestipp)
                    {
                        fordulonyertese = i.nev;
                        break;
                    }
                }
                Console.WriteLine("9. feladat: A megadott forduló nyertese: {0} ", fordulonyertese);
            }
            else
                Console.WriteLine("9. feladat: Nem volt nyertes a megadott fordulóban ");
            //9. feladat nyertes.txt
            FileStream fnev = new FileStream("nyertes.txt", FileMode.Append);
            StreamWriter fajlbairo = new StreamWriter(fnev);
            if (nyertestipp != -1)
            {
                fajlbairo.WriteLine("Forduló sorszáma: {0}.", fordulosorszama);
                fajlbairo.WriteLine("Nyertes tipp: {0}.", nyertestipp);
                fajlbairo.WriteLine("Nyertes játékos: {0}.", fordulonyertese);
            }                      
            fajlbairo.Close();
            fnev.Close();
            Console.ReadKey();
        }
    }
}
