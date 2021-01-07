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
/*A hajo.txt állományban cégünk sétahajóiról talál adatokat.
pl: 7,Durbincs,WIN-22,5,24000
	Hajós sorszáma
	Hajó neve
	Típusa
	Maximális utas szám
	Napi bérleti díj 
Hozzon léte grafikus programot, 
melynek segítségével a hajótársaság által kért statisztikákat elkészítheti!
*/
namespace hajo
{
    public partial class Form1 : Form
    {

        struct hajok
        {
            public int sorsz;
            public string hajonev;
            public string tipus;
            public int maxutasszam;
            public int napiberletidij;
        }
        static hajok[] adatok = new hajok[100];
        string[] fajlbol = File.ReadAllLines("hajo.txt");
        double osszesen = 0;
        int utasokszama = 0;
        int sorszam = 0;
        bool van = false;
       
        int sorokszama = 0;//sorok száma a fájlban
        int i, j;//ciklusváltozó
        public Form1()
        {
            InitializeComponent();
            adatokbetoltese();
        }
        private void adatokbetoltese()
        {
            sorokszama = 0;
            for (int k = 0; k < fajlbol.Count(); k++)
            {
                string[] egysordarabolva = fajlbol[k].Split(',');
                adatok[sorokszama].sorsz = Convert.ToInt32(egysordarabolva[0]);
                adatok[sorokszama].hajonev = egysordarabolva[1];                
                adatok[sorokszama].tipus = egysordarabolva[2];                
                adatok[sorokszama].maxutasszam = Convert.ToInt32(egysordarabolva[3]);
                adatok[sorokszama].napiberletidij = Convert.ToInt32(egysordarabolva[4]);               
                sorokszama++;
            }
            int hajokszama = sorokszama;
            /*Írja ki az összes kis hajó nevét és árát a 
             * kishajok.txt állományba! 
             * (Akkor nagy hajó, ha legalább 6 főt el tud szállítani.)*/
            FileStream fnev = new FileStream("kishajok.txt", FileMode.Create);
            StreamWriter fajlbairo = new StreamWriter(fnev);

            for (i = 0; i < hajokszama; i++)
            {
                osszesen += adatok[i].napiberletidij;
                if (adatok[i].maxutasszam < 6)
                {
                    fajlbairo.Write("{0};", adatok[i].hajonev);
                    fajlbairo.WriteLine("{0}", adatok[i].napiberletidij);
                }
                
            }
            fajlbairo.Close();
            fnev.Close();
           
                i = 0;
                sorszam = 0;
                van = false;
                while(i<hajokszama && !van)
                {
                    if(adatok[i].maxutasszam> utasokszama)
                    {
                        van = true;
                        sorszam = i;
                    }
                i++;
                }
                
           
            
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            /*5.	Olvassa be a felhasználótól, hogy hány főre szeretne hajót bérelni!
             * A „Keresés” gomb hatására tájékoztassuk a felhasználót, 
             * hogy van-e olyan hajó, amely ennyi főt el tud szállítani? 
             * Ha van, írja ki minta szerint egy ilyen hajó nevét, 
             * maximális utasszámát és a napi bérleti díját! 
             * Ha nincs, akkor a „Sajnos nem tudunk hajót ajánlani” felirat jelenjen meg a képernyőn!*/
            if (utasokszamatextBox.Text != "")
            {
                try
                {
                    utasokszama = Convert.ToInt32(utasokszamatextBox.Text);
                    adatokbetoltese();
                    if (van)
                    {
                        string szoveg = "Ajánlott hajó " + adatok[sorszam].hajonev + " \n" + adatok[sorszam].maxutasszam + " befogadására képes \nNapidíja: " + adatok[sorszam].napiberletidij + " Ft";
                        label4.Text = szoveg;
                    }
                    else
                    {
                        label4.Text = "Ajánlott hajó: -";
                        MessageBox.Show("Sajnos nem tudunk hajót ajánlani!");
                    }
                }
                catch
                {
                    MessageBox.Show("Nem számot adtál meg!");
                }
            }
            else
            {
                MessageBox.Show("Nem adtál meg adatot!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*Olvassa be a felhasználótól, hogy hány napra szeretne hajót bérelni! 
             * A Számoljunk feliratú nyomógombara kattintás hatására írja ki a képernyőre,
             * hogy mennyibe kerül, ha minden hajónkat kibérli ennyi napra.*/
            if (napokszamatextBox.Text != "")
            {
                try
                {
                    int napokszama = Convert.ToInt32(napokszamatextBox.Text);                                        
                    osszesen = osszesen * napokszama;
                    label2.Text = "5 napi költség: " + Convert.ToString(osszesen) + " Ft";
                }
                catch
                {
                    MessageBox.Show("Nem számot adtál meg!");
                }
            }
            else
            {
                MessageBox.Show("Nem adtál meg adatot!");
            }
        }
    }
}
