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
/*A következő feladatban Shakespeare drámáiról összeállított 
 * adatbázisból kell grafikus alkalmazást készítenie. 
 * A shakespeare.txt  állomány tartalmazza az író drámáinak listáját. 
 * A file minden sorában egy dráma adatai találhatók pontosvesszővel elválasztva,
 * egy sora például:  
Vízkereszt, vagy amit akartok;Twelfth Night or What You Will;1601;igen 
Amiben az adattagok rendre a következők:  
•	A mű magyar címe,  
•	a mű eredeti, angol címe,  
•	feltehetően melyik évben fejezet be Shakespeare a drámát,  
•	komédia  műfajába tartozik-e a darab? (igen- komédia, nem – tragédia vagy királydráma).  
*/
namespace shakespeare
{
    public partial class Form1 : Form
    {
        /*1.	Készítsen form applikációt shakespeare néven. 
         * Hozzon létre osztályt és egy megfelelő adatszerkezetet az adatok eltárolására! 
         * Olvassa be a shakespeare.txt állomány sorait a létrehozott adatszerkezetbe!  */
        struct dramak
        {
            public string magyarcim;
            public string angolcim;            
            public int ev;
            public string komedia;
        }
        static dramak[] adatok = new dramak[300];
        string[] fajlbol = File.ReadAllLines("shakespeare.txt");
        int dramakszama = 0;
        int evszam = 0;
        int sorszam = 0;
        string szoveg = "";
        string komediae = "";
        bool van = false;
        int max = 0, maxi = 0;
        int sorokszama = 0;//sorok száma a fájlban
        int i, j;//ciklusváltozó
        public Form1()
        {
            InitializeComponent();
            adatokbetoltese();
        }
        private void adatokbetoltese()
        {
            label1.Text = "";
            label2.Text = "";
            label4.Text = "";
            sorokszama = 0;
            for (int k = 0; k < fajlbol.Count(); k++)
            {
                string[] egysordarabolva = fajlbol[k].Split(';');
                adatok[sorokszama].magyarcim = egysordarabolva[0];
                adatok[sorokszama].angolcim = egysordarabolva[1];
                adatok[sorokszama].ev = Convert.ToInt32(egysordarabolva[2]);
                adatok[sorokszama].komedia = egysordarabolva[3];
                sorokszama++;
            }
            dramakszama = sorokszama;
            /*2.	Írja ki a képernyőre a minta szerint, 
             * hogy hány dráma adatai szerepelnek az állományban!  */
            label1.Text = Convert.ToString(dramakszama) + " Shakespeare dráma adatait eltároltuk";
            i = 0;
            sorszam = 0;
            van = false;
            while (i < dramakszama && !van)
            {
                if (adatok[i].ev == evszam)
                {
                    van = true;
                    sorszam = i;
                }
                i++;
            }
             max = adatok[0].ev;
            maxi = 0;
            for (i = 0; i < dramakszama; i++)
            {
                if (adatok[i].ev > max)
                {
                    max = adatok[i].ev;
                    maxi = i;
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*3.	Shakespeare drámái három műfajba sorolhatók: 
             * tragédia, komédia és királydrámák. 
             * A „Nem komédiák” feliratú nyomógomb hatására írja ki a dramak.txt állományba
             * a tragédiák és királydrámák angol címét. Minden cím külön sorban szerepeljen! */

            FileStream fnev = new FileStream("dramak.txt", FileMode.Create);
            StreamWriter fajlbairo = new StreamWriter(fnev);

            for (i = 0; i < dramakszama; i++)
            {
                if (adatok[i].komedia != "nem")
                {
                    fajlbairo.WriteLine("{0}", adatok[i].angolcim);
                }
               
               
            }
            fajlbairo.Close();
            fnev.Close();
            MessageBox.Show("tragédiák és királydrámák angol címét kiírtam \na dramak.txt-be");

           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*4.	Egy megfelelő objektum segítségével olvasson be egy évszámot! 
             * A „Keresés” gomb hatására jelenítse meg egy olyan dráma minden adatát a minta szerint,
             * melyet ebben az évben fejezett be Shakespeare. (A felhasználó által megadott adatot nem kell ellenőriznie!)  
Amennyiben nincs ilyen mű a listában, akkor a „Nem találtam megfelelő drámát” felirat jelenjen mega formon! 
*/

            if (evszamtextBox.Text != "")
            {
                try
                {
                    evszam = Convert.ToInt32(evszamtextBox.Text);
                    adatokbetoltese();
                    if (van)
                    {
                        if (adatok[sorszam].komedia == "igen")
                        {
                            komediae = "Komédia";
                        }
                        else
                        {
                            komediae = "Dráma";
                        }
                        string szoveg = adatok[sorszam].magyarcim + " \n" + adatok[sorszam].angolcim + " \n" + komediae;

                        label4.Text = szoveg;
                    }
                    else
                    {
                        label4.Text = "Nem találtam megfelelő drámát";
                        MessageBox.Show("Nem találtam megfelelő drámát");
                    }
                }
                catch
                {
                    MessageBox.Show("Nem számot adtál meg!");
                }
                
            }
            else
            {
                MessageBox.Show("Nem adtál meg évszámot");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*5.	Az „Utolsó műve” nyomógomb hatására jelenítse meg 
             * annak a drámának az angol címét, 
             * melyet Shakespeare utoljára fejezett be a lista szerint! */
            label2.Text = adatok[maxi].magyarcim;

        }
    }
}
