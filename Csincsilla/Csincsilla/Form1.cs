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
/*A következő feladatban csincsillákkal kapcsolatos feladatokat kell megoldanod. 
 * Pár csincsillatulajdonostól begyűjtöttünk adatokat a kedvencükről, 
 * és eltároltuk őket az UTF-8-as kódolású chi.txt állományban, 
 * az adattagokat egymástól pontosvesszővel elválasztva. Az állomány egy sora például:  
Lord Stanley;2016-12-09;503;I  
Amiben az adattagok rendre a következők:  
• kisállat neve (Lord Stanley),  
• kisállat születésének dátuma (ISO 8601 szabvány szerint: éééé-hh-nn)(2016-12-09),  
• kisállat súlya grammban (503),  
• szereti-e ha simogatják (I vagy N).  */
namespace Csincsilla
{
    public partial class Form1 : Form
    {

        struct csincsillak
        {
            public string nev;
            public DateTime szul;           
            public int suly;
            public string simi;
        }
        static csincsillak[] adatok = new csincsillak[300];
        string[] fajlbol = File.ReadAllLines("chi.txt");
        double szazalek = 0;
        int csincsillakszama = 0;
        int sorokszama = 0;//sorok száma a fájlban
        int i, j;//ciklusváltozó
        bool keresek = false;
        bool simogatoba = false;
        Random n = new Random();
        public Form1()
        {
            InitializeComponent();
            adatokbetoltese();
        }
        private void adatokbetoltese()
        {
            /* Készítsen form applikációt Csincsilla néven. 
             * Hozzon létre osztályt és egy megfelelő adatszerkezetet az adatok eltárolására! 
             * Olvassa be a chi.txt állomány sorait a létrehozott adatszerkezetbe!               */
            simogat.Text = "";
            keresettadatok.Text = "";
            sorokszama = 0;
            for (int k = 0; k < fajlbol.Count(); k++)
            {
                string[] egysordarabolva = fajlbol[k].Split(';');
                adatok[sorokszama].nev = egysordarabolva[0];
                adatok[sorokszama].szul =Convert.ToDateTime(egysordarabolva[1]);                
                adatok[sorokszama].suly = Convert.ToInt32(egysordarabolva[2]);
                adatok[sorokszama].simi = egysordarabolva[3];
                sorokszama++;
            }
            int csincsillakszama = sorokszama;
            /*2. Írja ki a képernyőre a minta szerint,
             * hogy hány csincsilla adatai szerepelnek az állományban!*/
            adatokszama.Text = Convert.ToString(csincsillakszama) + " csincsilla adatait eltároltuk";
            
            for (i = 0; i < csincsillakszama; i++)
            {
                if (adatok[i].simi == "I")
                {
                    szazalek++;
                }

            }
            szazalek = szazalek / csincsillakszama * 100;
            if (keresek)
            {
                i = 0;
                bool van = false;
                int sorszam = 0;
                string knev = keresettnev.Text;
                while (i < csincsillakszama && !van)
                {
                    if (adatok[i].nev.Contains(knev))
                    {
                        van = true;
                        sorszam = i;
                    }
                    i++;
                }
                if (van)
                {
                    keresettadatok.Text = adatok[sorszam].nev + " adatai\nSzületett:" + adatok[sorszam].szul + "\nSúlya: " + adatok[sorszam].suly;
                    if (adatok[sorszam].simi == "I")
                    {
                        keresettadatok.Text += "\nSzereti ha simogatják!";
                    }
                    else
                    {
                        keresettadatok.Text += "\nNem szereti ha simogatják!";
                    }
                }
                else
                {
                    MessageBox.Show("Nincs ilyen csincsilla!");
                }
            }
            if (simogatoba)
            {
                FileStream fnev = new FileStream("simogato.txt", FileMode.Create);
                StreamWriter fajlbairo = new StreamWriter(fnev);

                for (i = 0; i < csincsillakszama; i++)
                {
                    if (adatok[i].simi == "I")
                    {
                        fajlbairo.Write("{0};", adatok[i].nev);
                        fajlbairo.Write("{0};", adatok[i].szul);
                        fajlbairo.Write("{0};", adatok[i].suly);
                        fajlbairo.WriteLine("{0}", adatok[i].simi);
                    }
                    
                }
                fajlbairo.Close();
                fnev.Close();
                MessageBox.Show("kiírtam a „simogato.txt” állományba \na simogatóba betethető állatok minden adatát");
            }
        }
        private void kereses()
        {
           

        }
        private void button2_Click(object sender, EventArgs e)
        {
            /* Egy megfelelő objektum segítségével olvassa be egy csincsilla nevét! 
             * A Keresés gomb hatására jelenítse meg annak a csincsillának adatát, 
             * melynek neve megegyezik a keresett névvel, vagy részben tartalmazza azt! 
             * Kiírása felejen meg a mintának! Amennyiben nem szerepel a név az adatok között,
             * a „Nincs ilyen csincsilla” felirat jelenjen meg a képernyőn!*/
            
            if (keresettnev.Text != "")
            {
                keresek=true;
                simogatoba = false;
                adatokbetoltese();
            }
            else
            {
                MessageBox.Show("Nem írtál be nevet!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /* Az adatok állományba írás gombra kattintva írja ki a
             * „simogato.txt” állományba a simogatóba betethető állatok minden adatát! */
            simogatoba = true;
            keresek = false;
            adatokbetoltese();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* A simogatóba csak olyan állatot tehetünk, amelyik szereti, ha simogatják. 
             * A Simogatóba nyomógomb hatására jelenjen meg a képernyőn, 
             * hogy a csincsillák hány %-a szereti, ha simogatják! 
             * Amennyiben egyetlen állatka sem szereti a simogatást, 
             * a „Be kell zárni a simogatót” felirat jelenjen meg a képernyőn! */
            if (szazalek != 0)
            {
                simogat.Text = "A csincsillák "+Convert.ToString(Math.Round(szazalek,2))+" %-a mehet a simogatóba";
            }
            else
            {
                simogat.Text = "Be kell zárni a simogatót";
            }
        }
    }
}
