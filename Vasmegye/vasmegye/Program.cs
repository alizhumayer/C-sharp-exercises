using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vasmegye
{    
    class Program
    {       
        struct adatsor
        {
            public int nem;
            public int ev;
            public int ho;
            public int nap;
            public int sorsz;
            public int ell;         
        }
        static void Main(string[] args)
        {
            //vizsgáljuk Vas megyében az élve születések számát. 
            //A forrásállományba (vas.txt) az itt született csecsemők személyi azonosítója (személyi száma) került
            //A személyi szám úgynevezett „beszélő szám”, azaz struktúrája van. 
            //11 decimális számjegyből áll és M-ÉÉHHNN-SSSK alakú:
            //Az M számjegy alapvetően a nemre és a születési év első két jegyére utal:
            //Az ÉÉHHNN számjegyek a születési év utolsó két jegyét, a hónapot és a napot kódolják.
            //Az SSS az azonos napon születettek megkülönböztetésére való.
            //A K ellenőrzési célokat szolgál.A többi számjegyből kell képezni.
            //k11=(10*k1+9*k2+...+1*k10)mod 11

/*Minta:
2.	feladat: Adatok beolvasása, tárolása
4.	feladat: Ellenőrzés
Hibás	a	3-000115-5882	személyi	azonosító!
Hibás	a	3-000227-3942	személyi	azonosító!
Hibás	a	2-990101-1394	személyi	azonosító!
5.	feladat: Vas	megyében a vizsgált évek alatt 9126 csecsemő született.
6.	feladat: Fiúk száma: 4543
7.	feladat: Vizsgált időszak: 1998 - 2001
8.	feladat: Szökőnapon született baba!
9.	feladat: Statisztika
1998	- 2253 fő
1999	- 2320 fő
2000	- 2248 fő
2001	- 2305 fő
*/

//Olvassa be a vas.txt állományban lévő adatokat 
string[] fajlbol = File.ReadAllLines("vas.txt");
adatsor[] adatok = new adatsor[20000];   //A fájlban legfeljebb 20 000 sor lehet    
int tindex = 0;//helyes adatok számláló
int k11;
int ellenorzoosszeg = 0;
int ferfiakszama = 0;
int minev = 0;
int maxev = 0;
int evszam=0;
int n;
 string Id,id;
int[] k = new int[20000];           
Console.WriteLine("2. feladat: Adatok beolvasása tárolása");
Console.WriteLine("4. feladat: ellőrzés");
for (int i = 0; i < fajlbol.Count(); i++)
{
    string[] m = fajlbol[i].Split('-');
    k11 = int.Parse(m[2].Substring(3, 1));
    Id =fajlbol[i];
    id = Id.Remove(1, 1).Remove(7, 1);//eltávolítom a - jelet
    ellenorzoosszeg = 0;
    for ( n = 0; n < 10; n++)
    {
        ellenorzoosszeg += int.Parse(id.Substring(n, 1)) * (10 - n);
    } 
    if (k11==ellenorzoosszeg%11)//ha helyes az adat akkor eltárolom az adatokat
    {
        adatok[tindex].nem = int.Parse(id.Substring(0, 1));
        adatok[tindex].ev = int.Parse(id.Substring(1, 1)) * 10 + int.Parse(id.Substring(2, 1));
        if (adatok[tindex].nem==1 || adatok[tindex].nem == 3) ferfiakszama++;//megszámolom a férfiak számát
        adatok[tindex].ho = int.Parse(id.Substring(3, 1)) * 10 + int.Parse(id.Substring(4, 1));
        adatok[tindex].nap = int.Parse(id.Substring(5, 1)) * 10 + int.Parse(id.Substring(6, 1));
       // adatok[tindex].sorsz = int.Parse(id.Substring(7, 1)) * 100 + int.Parse(id.Substring(8, 1)) * 10+ int.Parse(id.Substring(9, 1));
       // adatok[tindex].ell = k11;
       tindex++;
    }
    else   //helytelen adatok esetén a hibás adatokat kiíratom
    {
        Console.Write("\n\tHibás a ");
        for (n = 0; n < id.Length; n++)
            if(n==1 ||n==7)
            Console.Write("-{0}", id[n]);
        else Console.Write("{0}", id[n]);
    }               
}

//5.	Határozza meg és írja ki a képernyőre a minta szerint, 
//hogy Vas megyében hány csecsemő született a vizsgált időszakban!
Console.WriteLine("\n5. feladat: Vas megyében a vizsgált évek alatt {0} csecsemő született", tindex);

//6.	Határozza meg és írja ki a képernyőre a minta szerint a fiú csecsemők számát!
Console.WriteLine("6. feladat: Fiúk száma {0}", ferfiakszama);

//7.	Határozza meg és írja ki a minta szerint a .vizsgált időszak kezdő és befejező évét! 
//Feltételezheti, hogy az időszak legalább 2 évig tartott.
minev = 3000;
maxev = 1000;
for (int i = 1; i < tindex; i++)
{
    if (adatok[i].nem == 1 || adatok[i].nem == 2) evszam = 1900 + adatok[i].ev;
    else evszam = 2000 + adatok[i].ev;
    if (evszam < minev) minev = evszam;
    if (evszam > maxev) maxev = evszam;
} 
Console.WriteLine("7. feladat: Vizsgált időszak {0} - {1}", minev,maxev);

//8.	Döntse el, hogy a szökőnapon (február 24-én) született-e csecsemő! 
//A keresést ne folytassa, ha a választ meg tudja adni! 
//Ebben a feladatban szökőévnek tekintheti az évet, ha az maradék nélkül osztható 4- gyel.
bool voltszokonapos = false;
int j = 0;
while ((j < tindex) && !voltszokonapos)
{
    if (adatok[j].ev % 4 == 0 && adatok[j].ho == 2 && adatok[j].nap == 24) voltszokonapos = true;
    j++;
}
if (voltszokonapos) Console.WriteLine("8. feladat: Szökőnapon született baba");
else
    Console.WriteLine("8. feladat: Szökőnapon nem született baba");

//9.	Készítsen statisztikát évek szerint a született gyermekek számáról! 
//A megoldást úgy készítse el, hogy az inputállományba később más évek adatai is bekerülhessenek!
int[] statisztika = new int[20000];

for (int i = 0; i < 3000; i++) statisztika[i] = 0;
    for (int i = 0; i < tindex; i++)
{
    if (adatok[i].nem == 1 || adatok[i].nem == 2) evszam = 1900 + adatok[i].ev;
   else evszam = 2000 + adatok[i].ev;
    statisztika[evszam]++;
}
Console.WriteLine("9. feladat: Statisztika");
for (int i = minev; i <=maxev; i++)
{
    Console.WriteLine("\t{0} - {1} fő",i,statisztika[i]);
}
    Console.ReadKey();
}
}
}
