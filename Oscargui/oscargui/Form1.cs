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
/*Az oscar.csv állományban tároltuk el ezeknek a filmeknek az adatait! 
 * Az állomány minden sora egy-egy film adatait tárolja. 
 * Az adatokat ; karakter választja el egymástól. 
 * Az állomány első sora tartalmazza a mezőneveket.      
•	azon: a film azonosítója. Szöveg
•	cim: A film angol címe Pl.: Grand Prix Szöveg
•	ev: A díjazás éve Pl.: 1966 Egész szám
•	dij: Az elnyert díjak száma Pl.:3 Egész szám
•	jelol: A jelölések száma Pl.: 3 Egész száám
*/
namespace oscargui
{
    public partial class Form1 : Form
    {

        struct oscardijak
        {
            public string azon;
            public string cim;
            public int ev;
            public int dij;
            public int jelol;
        }
        static oscardijak[] adatok = new oscardijak[300];
        string[] fajlbol = File.ReadAllLines("oscar.csv");
        string keresettfilmcime="";
        string keresettszoveg="";
        bool van = false;
        int sorszam=0;
        int dijakszama = 0;
        Random n = new Random();
        int sorokszama = 0;//sorok száma a fájlban
        int i, j;//ciklusváltozó
        public Form1()
        {
            InitializeComponent();
            adatokbetoltese();
            label6.Visible = false;
            label7.Visible = false;
        }
        private void adatokbetoltese()
        {
            /*2.	Olvassa be az oscar.csv állomány tartalmát egy megfelelő adatszerkezetbe!
Jelenítse meg névsorba rendezve az összes film címét az „Oszkár-díjas filmek” felirat alatti ListBox objektumban!
*/

            sorokszama = 0;
            for (int k = 1; k < fajlbol.Count(); k++)//az első sor a mezőneveket tartalmazza
            {
                string[] egysordarabolva = fajlbol[k].Split(';');
                adatok[sorokszama].azon = egysordarabolva[0];
                adatok[sorokszama].cim = egysordarabolva[1];                
                adatok[sorokszama].ev = Convert.ToInt32(egysordarabolva[2]);
                adatok[sorokszama].dij = Convert.ToInt32(egysordarabolva[3]);
                adatok[sorokszama].jelol = Convert.ToInt32(egysordarabolva[4]);
                
                sorokszama++;
            }
            dijakszama = sorokszama;

            //sorbarendezés buborékmódszerrel cím szerint növekvő sorrendbe         
            int r = dijakszama;
            while (r > 1)
            {
                for (i = 0; i < r - 1; i++)
                {
                    int x = String.Compare(adatok[i].cim, adatok[i + 1].cim);
                    if (x > 0)
                    {
                        var seged = adatok[i];
                        adatok[i] = adatok[i + 1];
                        adatok[i + 1] = seged;
                    }
                }
                r--;

            }
            for (i = 0; i < dijakszama; i++)
            {
                listBox1.Items.Add(adatok[i].cim);
            }

            
                int max = adatok[0].dij;
                int maxi = 0;
                for (i = 0; i < dijakszama; i++)
                {
                    if (adatok[i].dij > max)
                    {
                        max = adatok[i].dij;
                        maxi = i;
                    }
                }
                label6.Text = "Film címe: "+ adatok[maxi].cim;
            
            
        }
        private void keresek()
        {
            i = 0;
            van = false;
            while (i <dijakszama && !van)
               
            {
                if (adatok[i].cim.ToLower().Contains(keresettfilmcime))
                {
                    van = true;
                    sorszam = i;
                }
                i++;
            }
            if (van)
            {
                label7.Visible = true;
                label7.Text = "Találat kiírása: Keresett film címe: "+ adatok[sorszam].cim;
            }
            else
            {
                MessageBox.Show("Sajnos nincs ilyen film a listában");
            }
        }
        private void keresek2()
        {
            
            for (i = 0; i < dijakszama; i++)
            {
                if (adatok[i].cim.ToLower().Contains(keresettszoveg))
                {
                    listBox2.Items.Add(adatok[i].cim);
                }               
            }            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*4.	A legtöbb díjat kapta feliratú gomb lenyomására 
             * a Film címe feliratú szövegmezőben jelenítse meg a legtöbb díjat elnyerő film címét!*/
            label6.Visible=true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*5.	A keresés gomb hatására a Keresett film feliratú szövegmezőbe 
             * írt címet vagy címrészletet keresse a filmek között! 
             * (Kis- és nagy betű ne jelentsen különbséget a keresés során!) 
             * A Találat kiírása szövegmezőbe jelenítse meg egy olyan film címét,
             * melyben szerepel a felhasználó által megadott szöveg! Amennyiben nincs ilyen,
             * a „Sajnos nincs ilyen film a listában” felirat jelenjen meg a képernyőn!*/
            if (keresettfilmtextBox.Text != "")
            {
                
                keresettfilmcime = keresettfilmtextBox.Text;
                
                keresek();
            }
            else
            {
                MessageBox.Show("Nem adtál meg adatot!");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*6.	A Listázz nyomógomb hatására jelenítse meg a felette lévő ListBox objektumban
             * az összes olyan film címét, melyben szerepel a Keresett szó feliratú szövegmezőben 
             * a felhasználó által megadott cím vagy annak részlete! 
             * (Kis- és nagy betű ne jelentsen különbséget a keresés során!)*/
            if (keresettszotextBox.Text != "")
            {

                keresettszoveg = keresettszotextBox.Text;

                keresek2();
            }
            else
            {
                MessageBox.Show("Nem adtál meg adatot!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*3.	Az „Új film felvétele” nyomógomb hatására bővítse az előbbi listát, 
             * valamint az állományt a felhasználó által a TextBox-okban megadott adatokkal! 
             * Amennyiben valamelyik mezőt üresen hagyta a felhasználó,
             * vagy nem megfelelő adatot adott meg benne, küldjön hibaüzenetet 
             * egy felugró ablak segítségével és a beírt adatokat ne mentse el!*/
             if(cimtextBox.Text!="" && evtextBox.Text != "" && jeltextBox.Text != "" && dijtextBox.Text != "")
            {
                try
                {//azon	cim	ev	dij	jelol

                    string filmcim = cimtextBox.Text;
                    int evszam = Convert.ToInt32(evtextBox.Text);
                    int dijak = Convert.ToInt32(dijtextBox.Text);
                    int jelolesekszama = Convert.ToInt32(jeltextBox.Text);
                    FileStream fnev = new FileStream("oscar.csv", FileMode.Append);
                    StreamWriter fajlbairo = new StreamWriter(fnev);

                    int azonosito = n.Next(0, 10000);
                    fajlbairo.Write("{0};", azonosito);
                    fajlbairo.Write("{0};", filmcim);
                    fajlbairo.Write("{0};", evszam);
                    fajlbairo.Write("{0};", dijak);
                    fajlbairo.WriteLine("{0}", jelolesekszama);

                    fajlbairo.Close();
                    fnev.Close();
                    MessageBox.Show("Adatok kiírása megtörtént a oscar.csv-be");
                    listBox1.Items.Clear();
                    adatokbetoltese();


                }
                catch
                {
                    MessageBox.Show("Nem számot adtál meg!");
                }
            }
            else
            {
                MessageBox.Show("Nem adtál meg minden adatot!");
            }
        }
    }
}
