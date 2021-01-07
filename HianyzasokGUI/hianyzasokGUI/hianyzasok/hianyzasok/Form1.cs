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

namespace hianyzasok
{
    public partial class Form1 : Form
    {
        int elsonap, utolsonap, oraszam;
             bool ok = true;
        public Form1()
        {
            InitializeComponent();
            adatokbetoltese();
        }
        struct hianyzas//Készítsen összetett változót az adatok tárolására!
        {
            public string nev;
            public string osztaly;
            public int elsonap;
            public int utolsonap;
            public int mulasztottorak;
        }
        static hianyzas[] adatok = new hianyzas[200];//Az állományban legfeljebb 200 sor lehet. 
        private void adatokbetoltese()
        {
            string[] fajlbol = File.ReadAllLines("szeptember.csv");
            int sorokszama = 0;//sorok száma a fájlban
            int i, j;//ciklusváltozó
            for (int k = 1; k < fajlbol.Count(); k++)//Ügyeljen arra, hogy az állomány első sora az adatok fejlécét tartalmazza!
            {
                string[] egysordarabolva = fajlbol[k].Split(';');//Az adatokat pontosvessző választja el.
                adatok[sorokszama].nev = egysordarabolva[0];
                adatok[sorokszama].osztaly = egysordarabolva[1];
                adatok[sorokszama].elsonap = Convert.ToInt32(egysordarabolva[2]);
                adatok[sorokszama].utolsonap = Convert.ToInt32(egysordarabolva[3]);
                adatok[sorokszama].mulasztottorak = Convert.ToInt32(egysordarabolva[4]);
                sorokszama++;
            }
            int hianyzasokszama = sorokszama;
            listBox1.Items.Add("Név" + "\t " + "Osztály" + "\t " + " Első nap" + "\t " + " Utolsó nap" + "\t " + " Mulasztott órák");
            for (i = 0; i < hianyzasokszama; i++)
            {
                listBox1.Items.Add(adatok[i].nev + "\t " + adatok[i].osztaly + "\t " + adatok[i].elsonap + "\t " + adatok[i].utolsonap + "\t " + adatok[i].mulasztottorak);
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (nevtextBox.Text != "" && osztalytextBox.Text != "" && elsotextBox.Text != "" && utolsotextBox.Text != "" && mulasztotttextBox.Text != "")
            {
                
                string tanulonev = nevtextBox.Text;
                string osztalynev = osztalytextBox.Text;
                ok = true;
                try
                {
                    elsonap = int.Parse(elsotextBox.Text);
                }
                catch
                {
                    MessageBox.Show("Nem számot adtál meg");
                    ok = false;
                }
                try
                {
                    utolsonap = int.Parse(utolsotextBox.Text);
                }
                catch
                {
                    MessageBox.Show("Nem számot adtál meg");
                    ok = false;
                }
                try
                {
                    oraszam = int.Parse(mulasztotttextBox.Text);
                }
                catch
                {
                    MessageBox.Show("Nem számot adtál meg");
                    ok = false;
                }
                if(elsonap<=0 || elsonap >= 31)
                {
                    MessageBox.Show("Hibás adat! Csak 1 és 30 közötti érték lehet!");
                    elsotextBox.Text = "";
                    ok = false;
                }
                if (utolsonap <= 0 || utolsonap >= 31)
                {
                    MessageBox.Show("Hibás adat! Csak 1 és 30 közötti érték lehet!");
                    utolsotextBox.Text = "";
                    ok = false;
                }
                if (elsonap > utolsonap)
                {
                    MessageBox.Show("Az utolsó nap nagyobb legyen mint az első nap");
                    utolsotextBox.Text = "";
                    ok = false;
                }
                if (ok)
                {
                    FileStream fnev = new FileStream("szeptember.csv", FileMode.Append);
                    StreamWriter fajlbairo = new StreamWriter(fnev, System.Text.Encoding.UTF8);                   
                    fajlbairo.WriteLine("{0};{1};{2};{3};{4}", tanulonev, osztalynev, elsonap, utolsonap,oraszam);
                    fajlbairo.Close();
                    fnev.Close();
                    MessageBox.Show("Az állomány bővítése sikeres volt!", "üzenet");
                    nevtextBox.Text = "";
                    osztalytextBox.Text = "";
                    elsotextBox.Text = "";
                    utolsotextBox.Text = "";
                    mulasztotttextBox.Text = "";
                    listBox1.Items.Clear();
                    adatokbetoltese();
                    fajlbairo.Close();
                    fnev.Close();
                }
                
            }
            else
            {
                MessageBox.Show("Minden mezőt ki kell tölteni");
            }

        }
    }
}
