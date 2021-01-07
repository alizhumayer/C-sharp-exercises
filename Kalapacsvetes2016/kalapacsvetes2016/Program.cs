using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalapacsvetes2016
{
    class versenyzo
    {
        public string nev { get; private set; }
        public string orszag { get; private set; }
        public List<string> dobasok { get; private set; }      
        public int dobasokszama { get { return dobasok.Count - 2; } }
       
        public versenyzo(string sor)
        {
            string[] m = sor.Split(';');
            nev = m[0];
            orszag = m[1];
            dobasok = new List<string>();
            
            for (int i = 2; i < m.Length; i++)
            {
                dobasok.Add(m[i]);
            }
        }


        static void Main(string[] args)
        {
            //Olvassa be a forrás fáj (kalapacsvetes2016.txt) sorait és tárolja el a
            //Versenyző típusú osztálypéldányokat (objektumokat)
           // egy olyan adatszerkezetben, ami a további feladatok megoldását lehetővé teszi!
            int dontobejutottakszama = 0;
            List<versenyzo> t = new List<versenyzo>();
            foreach (var i in File.ReadAllLines("kalapacsvetes2016.txt"))
            {
                t.Add(new versenyzo(i));
                Console.WriteLine(" {0} ", i);//sorok kiíratása
            }
            //Határozza meg és írja ki a képernyőre a döntőbe jutott versenyzők számát a minta szerint!
            Console.WriteLine("5. feladat: Döntőbe jutott versenyzők száma: {0}",t.Count());
            /*dobások kiíratása
            foreach (var i in t)
            {
                foreach (var j in i.dobasok)
                {
                    Console.Write("{0} ",j);
                }
                Console.WriteLine("\n");
            }*/
            //A 3. dobás után csak meghatározott számú versenyző folytathatta a döntőt. 
            //Az eredményt a minta szerint jelenítse meg a képernyőn!
            foreach (var i in t)
            {                
                    if (i.dobasok.Count > 3) dontobejutottakszama++;
            }
            Console.WriteLine("\n6.feladat: A 3. dobás után {0} versenyző folytathatta a döntőt", dontobejutottakszama);
            //Készítsen statisztikát a minta szerint! A döntőt folytató versenyzők érvényes, sikertelen és legjobb dobásaihoz 
            //készítsen a Versenyző osztályban jellemzőket az osztálydiagram szerint!
            int ervenyesdobasokszama = 0;
            int sikertelendobasokszama = 0;
            double legjobbdobas = 0;
            double[] legjobberedmenyek = new double[100];
            int sz = 0;
            string magyarsportolonev = "";
           
            double magyareredmeny = 0;
            Console.WriteLine("\n7.feladat: Statisztika (név;érvényes dobás;sikertelen dobás;legjobb dobás");
            foreach (var i in t)
            {
                if (i.dobasok.Count > 3)
                {
                    ervenyesdobasokszama = 0;
                    sikertelendobasokszama = 0;
                    legjobbdobas = 0;
                    foreach (var j in i.dobasok)
                    {
                        if (j != "x")
                        {
                            ervenyesdobasokszama++;
                            if (double.Parse(j) > legjobbdobas) legjobbdobas = double.Parse(j);
                        }
                        else sikertelendobasokszama++;
                        //Console.Write("{0} ", j);
                    }
                    Console.WriteLine("\t{0}; {1}; {2}; {3} cm", i.nev, ervenyesdobasokszama, sikertelendobasokszama, legjobbdobas);
                    if (i.orszag == "Magyarország")
                    {
                        magyarsportolonev = i.nev;
                        magyareredmeny = legjobbdobas;
                    }

                    legjobberedmenyek[sz] = legjobbdobas;
                    sz++;
                   
                }
            }
            //Határozza meg és írja ki a minta szerint a magyar sportoló nevét és helyezését! 
            //Feltételezheti, hogy a döntőbe csak egy magyar versenyző jutott!
            int helyezes =0;

            //legjobb eredmények sorbarendezése maximumkiválasztással
            int l,r, h = sz , db = 0;
            double max;
            while (h > 1)
            {
                l = 0; max = legjobberedmenyek[0]; r = 0;
                while (l <= h)
                {
                    if (legjobberedmenyek[l] > max)
                    {
                        max = legjobberedmenyek[l];
                        r = l;
                    }
                    l++;
                }
                db++;
                legjobberedmenyek[r] = legjobberedmenyek[h];
                legjobberedmenyek[h] = max;
                
                h--;
            }
            //Console.Write("\nSzámok sorbarendezve: ");
            for (l = 1; l <= sz; l++)
                if (legjobberedmenyek[l] == magyareredmeny) helyezes = l;
               // Console.Write("{0} ", legjobberedmenyek[l]);


            Console.WriteLine("\n8.feladat: A magyar versenyző {0} {1}. lett", magyarsportolonev, sz-helyezes+1);

            //Készítsen kalapacsvetes2016inch.txt néven szöveges állományt, 
            //amely csak annyiban különbözzön a forrás fájltól, 
            //hogy a dobások távolságát centiméter helyett hüvelyk (coll) mértékegységben, 
            //három tizedes jegyre kerekítve tartalmazza! 1coll=2,54cm!
            double eredmeny;
            FileStream fnev = new FileStream("kalapacsvetes2016inch.txt", FileMode.Create);
            StreamWriter fajlbairo = new StreamWriter(fnev);
            foreach (var i in t)
            {
                fajlbairo.Write(i.nev);
                fajlbairo.Write(";");
                fajlbairo.Write(i.orszag);
                fajlbairo.Write(";");
                foreach (var j in i.dobasok)
                {
                    if (j != "x")
                    {
                        eredmeny= double.Parse(j) / 2.54;
                        fajlbairo.Write("{0};", Math.Round(eredmeny,3));
                    }                 
                                          
                    else fajlbairo.Write("x;");
                    
                }
                fajlbairo.WriteLine("\n");
            }
            fajlbairo.Close();
            fnev.Close();
                Console.ReadKey();
        }
    }
}
