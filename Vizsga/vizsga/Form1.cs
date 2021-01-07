using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*Az adatokat a pontosvesszővel (;) tagolt adatok.txt állomány tartalmazza. 
 * Az állomány minden sora egy diák adatait tartalmazza.
Pl: Albert Gyula;3;2;false;102
•	A diák neve. Pl: Albert Gyula
•	Az egyes modulok eredménye tizedes számként tárolva az alábbi sorrendben:
o	IT és hálózatok írásbeli
o	Programozás írásbeli
o	Hálózatok A modul
o	Hálózatok B modul
o	Hálózatok C modul
o	Hálózatok D modul
o	Szóbeli angol
o	Szóbeli IT
*/
namespace vizsga
{
    public partial class Form1 : Form
    {

        struct tanulok
        {
            public string nev;
            public double ithal;
            public double progr;
            public double hala;
            public double halb;
            public double halc;
            public double hald;
            public double szoba;
            public double szobit;
            public double eredmeny;
            public string minosites;
        }
        static tanulok[] adatok = new tanulok[100];//Az állományban legfeljebb 100 sor lehet.
        string[] fajlbol = File.ReadAllLines("adatok.txt");
        int tanulokszama = 0;
        double atlag = 0;
        int sikeresvizsgazokszama = 0;
        int sorszam = 0;
        string keresettnev = "";        
        bool van = false;
        double max = 0;
        double min = 0;
        int maxi = 0;
        int sorokszama = 0;//sorok száma a fájlban
        int i, j;//ciklusváltozó
        public Form1()
        {
            InitializeComponent();
            adatokbetoltese();
            erdemjegy();
        }
        private void adatokbetoltese()
        {
            /*3.	Olvassa be az adatok.txt állomány tartalmát egy megfelelő adatszerkezetbe!*/
            label1.Text = "";
            label2.Text = "";
            label4.Text = "";
            sorokszama = 0;
            for (int k = 0; k < fajlbol.Count(); k++)
            {
                string[] egysordarabolva = fajlbol[k].Split(';');
                adatok[sorokszama].nev = egysordarabolva[0];
                adatok[sorokszama].ithal =Convert.ToDouble(egysordarabolva[1]) * 100;
                adatok[sorokszama].progr =Convert.ToDouble(egysordarabolva[2]) * 100;
                adatok[sorokszama].hala =Convert.ToDouble(egysordarabolva[3]) * 100;
                adatok[sorokszama].halb =Convert.ToDouble(egysordarabolva[4]) * 100;
                adatok[sorokszama].halc =Convert.ToDouble(egysordarabolva[5]) * 100;
                adatok[sorokszama].hald =Convert.ToDouble(egysordarabolva[6]) * 100;
                adatok[sorokszama].szoba =Convert.ToDouble(egysordarabolva[7]) * 100;
                adatok[sorokszama].szobit =Convert.ToDouble(egysordarabolva[8]) * 100;                
                sorokszama++;
            }
            tanulokszama = sorokszama;
            //4.Írja ki a képernyőre, hogy összesen hány diák vett részt a vizsgán!
            label1.Text = Convert.ToString(tanulokszama) + " vizsgázó adatait beolvastuk";
            //5.	Jelenítse meg a vizsgázók nevét egy listBox segítségével!
            for (i = 0; i < tanulokszama; i++)
                listBox1.Items.Add(adatok[i].nev);
        }
        private void kereses()
        {
            i = 0;
            van = false;
            sorszam = 0;
            label4.Text = "";
            while (i<tanulokszama && !van)
            {
                if (adatok[i].nev.ToLower().Contains(keresettnev)){
                    van = true;
                    sorszam = i;
                }
                i++;
            }
            if (van)
            {
                max = adatok[sorszam].ithal;
                if (adatok[sorszam].progr  > max) max = adatok[sorszam].progr;
                if (adatok[sorszam].hala  > max) max = adatok[sorszam].hala;
                if (adatok[sorszam].halb  > max) max = adatok[sorszam].halb;
                if (adatok[sorszam].halc  > max) max = adatok[sorszam].halc;
                if (adatok[sorszam].hald  > max) max = adatok[sorszam].hald;
                if (adatok[sorszam].szoba  > max) max = adatok[sorszam].szoba;
                if (adatok[sorszam].szobit  > max) max = adatok[sorszam].szobit;
                min = adatok[sorszam].ithal ;
                if (adatok[sorszam].progr  < min) min = adatok[sorszam].progr;
                if (adatok[sorszam].hala  < min) min = adatok[sorszam].hala;
                if (adatok[sorszam].halb  < min) min = adatok[sorszam].halb;
                if (adatok[sorszam].halc  < min) min = adatok[sorszam].halc;
                if (adatok[sorszam].hald  < min) min = adatok[sorszam].hald;
                if (adatok[sorszam].szoba  < min) min = adatok[sorszam].szoba;
                if (adatok[sorszam].szobit  < min) min = adatok[sorszam].szobit;

                label4.Text="Tanuló neve: "+adatok[sorszam].nev+"\nLegjobb eredménye: "+ Convert.ToString(max) + " %";
                label4.Text+="\nLeggyengébb eredménye: "+ Convert.ToString(min) + " %";
                if (adatok[sorszam].eredmeny > 50)
                {
                    label4.Text += "\nSikeres vizsgát tett";
                }
                else
                {
                    label4.Text += "\nSikertelen vizsgát tett";
                }
            }
            else
            {
                label4.Text = "A keresett tanuló nem található a listában!";
                MessageBox.Show("A keresett tanuló nem található a listában!");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            /*7.	Az Eredmények állományba írása feliratú nyomógomb hatására hozza létre 
             * a vizsgaradmenyek.txt állományt! Írja ki az összes sikeres vizsga végeredményét!
Az állomány minden sora egy-egy vizsgázó adatait tartalmazza tabulátorral elválasztva. 
Első adat a tanuló neve, a vizsga végeredménye és az érdemjegy.
*/


            FileStream fnev = new FileStream("vizsgaradmenyek.txt", FileMode.Create);
            StreamWriter fajlbairo = new StreamWriter(fnev);

            for (i = 0; i < tanulokszama; i++)
            {
                if (adatok[i].eredmeny >= 51)
                {
                    fajlbairo.Write("{0}\t", adatok[i].nev);
                    fajlbairo.Write("{0}\t", adatok[i].eredmeny);
                    fajlbairo.WriteLine("{0}", adatok[i].minosites);
                } 
            }
            fajlbairo.Close();
            fnev.Close();
            MessageBox.Show("az összes sikeres vizsga végeredményét kiírtam \na vizsgaradmenyek.txt állományba");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*8.	Egy textBox segítségével olvassa be a felhasználótól egy tanuló nevét vagy nevének egy részletét.
             * Ellenőrizze, hogy a keresett tanuló neve szerepel-e a listában! (Feltételezheti, hogy egyetlen találat lesz.)
Amennyiben a tanuló nem szerepel a listában, egy felugró ablak segítségével tájékoztassa erről a felhasználót. 
Amennyiben a keresett név szerepel a listában, jelenítse meg a minta szerint, 
hogy mennyi volt a legjobb és leggyengébb eredménye, illetve hogy sikeres volt-e a vizsgája.
*/

            if (keresettnevtextBox.Text != "")
            {
                 keresettnev = keresettnevtextBox.Text;
                kereses();
            }
            else
            {
                MessageBox.Show("Nem adtál meg nevet");
            }
        }

        private void erdemjegy()
        {
            /*2.	Hozza létre az erdemjegy() metódust, 
             * amely szöveges formában adja vissza a vizsgára kapott érdemjegyet. 
             * Ha bármelyik modulon 51% alatt teljesített a vizsgázó, akkor elégtelen, 
             * különben a vegeredmeny alapján:
             81 – 100%	jeles 
	71 – 80%		jó 
	61 – 70%		közepes 
	51 – 60%		elégséges 
*/

            for (i = 0; i < tanulokszama; i++)
            {
                if (adatok[i].ithal <= 50 || adatok[i].progr <= 50 || adatok[i].hala <= 50 || adatok[i].halb <= 50 || adatok[i].halc <= 50 || adatok[i].hald <= 50 || adatok[i].szoba <= 50 || adatok[i].szobit <= 50)
                {
                    adatok[i].minosites = "elégtelen";
                }
                else
                {
                    atlag = Math.Round((adatok[i].ithal + adatok[i].progr + adatok[i].hala + adatok[i].halb + adatok[i].halc + adatok[i].hald + adatok[i].szoba + adatok[i].szobit) / 8 , 0);
                    adatok[i].eredmeny =(atlag );
                    if (atlag>=51 && atlag<=60) adatok[i].minosites = "elégséges";
                    if(atlag>=61 && atlag<=70) adatok[i].minosites = "közepes";
                    if(atlag>=71 && atlag<=80) adatok[i].minosites = "jó";
                    if(atlag>=81 ) adatok[i].minosites = "jeles";
                    sikeresvizsgazokszama++;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            /*6.	A megfelelő nyomógomb lenyomásának hatásásra a program 
             * jelenítse meg a képernyőn a sikeres vizsgát tett tanulók számát!*/
            label2.Text = Convert.ToString(sikeresvizsgazokszama) + " fő";
        }
    }
}
