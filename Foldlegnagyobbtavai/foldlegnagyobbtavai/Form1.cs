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

namespace foldlegnagyobbtavai
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            adatokbetoltese();
        }
        struct to//2.	Készítsen összetett változót az adatok tárolására!
        {
            public string nev;
            public string teruletstr;
            public int terulet;
            public int teruletmin;
            public int teruletmax;
            public string orszag;
        }
        static to[] adatok = new to[500];//Az állományban legfeljebb 500 sor lehet. 
        private void adatokbetoltese()
        {
            string[] fajlbol = File.ReadAllLines("tavak.csv");
            int sorokszama = 0;//sorok száma a fájlban
            int i;//ciklusváltozó
            for (int k = 1; k < fajlbol.Count(); k++)//4.	Ügyeljen arra, hogy az állomány első sora az adatok fejlécét tartalmazza!
            {
                string[] egysordarabolva = fajlbol[k].Split(';');//Az adatokat pontosvessző választja el.
                adatok[sorokszama].nev = egysordarabolva[0];
                adatok[sorokszama].teruletstr = egysordarabolva[1];
                if (adatok[sorokszama].teruletstr.Contains('-'))
                //3.	Ha a tó területe változik (sivatagos területen fekszik), 
                //akkor a minimum és maximum érték számtani átlaga adja a terület jellemzőt! 
                {
                    string[] egysordarabolva2 = egysordarabolva[1].Split('-');//minimum és a maximum érték kötőjellel van elválasztva
                    adatok[sorokszama].teruletmin = Convert.ToInt32(egysordarabolva2[0]);
                    adatok[sorokszama].teruletmax = Convert.ToInt32(egysordarabolva2[1]);
                    adatok[sorokszama].terulet = (adatok[sorokszama].teruletmin + adatok[sorokszama].teruletmax) / 2;
                }
                else
                {
                    adatok[sorokszama].terulet = Convert.ToInt32(egysordarabolva[1]);
                }
                adatok[sorokszama].orszag = egysordarabolva[2];
                sorokszama++;
            }
            int tavakszama = sorokszama;
            listBox1.Items.Add("név" + "\t " + "terület" + "\t " + " ország(ok)");
            for (i = 0; i < tavakszama; i++)
            {
                listBox1.Items.Add(adatok[i].nev + "\t " + adatok[i].teruletstr + "\t " + adatok[i].orszag);
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (tonevtextBox.Text != "" && toterulettextBox.Text != "" && toorszagtextBox.Text != "")
            {
                string tonev = tonevtextBox.Text;
                string toorszag = toorszagtextBox.Text;
                FileStream fnev = new FileStream("tavak.csv", FileMode.Append);
                StreamWriter fajlbairo = new StreamWriter(fnev, System.Text.Encoding.UTF8);
                if (toteruletmaxtextBox.Text=="")
                {
                    try
                    {
                        int toterulet = int.Parse(toterulettextBox.Text);

                        fajlbairo.WriteLine("{0};{1};{2}", tonev, toterulet, toorszag);
                        fajlbairo.Close();
                        fnev.Close();
                        MessageBox.Show("Az állomány bővítése sikeres volt!", "üzenet");
                        tonevtextBox.Text = "";
                        toterulettextBox.Text = "";
                        toorszagtextBox.Text = "";
                        adatokbetoltese();

                    }
                    catch
                    {
                        MessageBox.Show("Nem számot adtál meg");
                    }
                }
                else
                {
                    try
                    {
                        int toteruletmax = int.Parse(toteruletmaxtextBox.Text);
                        int toterulet = int.Parse(toterulettextBox.Text);
                        fajlbairo.WriteLine("{0};{1}-{2};{3}", tonev, toterulet,toteruletmax, toorszag);
                        fajlbairo.Close();
                        fnev.Close();
                        MessageBox.Show("Az állomány bővítése sikeres volt!", "üzenet");
                        tonevtextBox.Text = "";
                        toterulettextBox.Text = "";
                        toteruletmaxtextBox.Text = "";
                        toorszagtextBox.Text = "";
                        adatokbetoltese();
                    }
                    catch
                    {
                        MessageBox.Show("Nem számot adtál meg");
                    }
                }

                fajlbairo.Close();
                fnev.Close();
            }
            else
            {
                MessageBox.Show("Minden mezőt ki kell tölteni");
            }
        }
    }
}
