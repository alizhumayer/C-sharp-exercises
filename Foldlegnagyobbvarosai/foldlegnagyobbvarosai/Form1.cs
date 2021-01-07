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

namespace foldlegnagyobbvarosai
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            adatokbetoltese();
        }
        struct varos
        {
            public string nev;
            public string orszag;
            public double nepesseg;
        }
        static varos[] adatok = new varos[100];//Az állományban legfeljebb 100 sor lehet. 
        private void adatokbetoltese()
        {
            string[] fajlbol = File.ReadAllLines("varosok.csv");
            int sorokszama = 0;//sorok száma a fájlban
            int i, j, k;//ciklusváltozó
            for (k = 1; k < fajlbol.Count(); k++)//Ügyeljen arra, hogy az állomány első sora az adatok fejlécét tartalmazza!
            {
                string[] egysordarabolva = fajlbol[k].Split(';');//Az adatokat pontosvessző választja el.
                adatok[sorokszama].nev = egysordarabolva[0];
                adatok[sorokszama].orszag = egysordarabolva[1];
                adatok[sorokszama].nepesseg = Convert.ToDouble(egysordarabolva[2]);
                sorokszama++;
            }
            int varosokszama = sorokszama;
            listBox1.Items.Add("városnév" + "\t " + "ország" + "\t " + "népesség (millió fő)");
            for (i = 0; i < varosokszama; i++)
            {
                listBox1.Items.Add(adatok[i].nev + "\t " + adatok[i].orszag + "\t " + adatok[i].nepesseg);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(varosnevtextBox.Text!="" && orszagnevtextBox.Text!="" && lakossagtextBox.Text != "")
            {
                try
                {
                    double lakossag = double.Parse(lakossagtextBox.Text);
                    string varos = varosnevtextBox.Text;
                    string orszag = orszagnevtextBox.Text;
                    FileStream fnev = new FileStream("varosok.csv", FileMode.Append);
                    StreamWriter fajlbairo = new StreamWriter(fnev,System.Text.Encoding.UTF8);
                    fajlbairo.WriteLine("{0};{1};{2}", varos, orszag, lakossag);
                    fajlbairo.Close();
                    fnev.Close();
                    MessageBox.Show("Az állomány bővítése sikeres volt!", "üzenet");
                    varosnevtextBox.Text = "";
                    orszagnevtextBox.Text = "";
                    lakossagtextBox.Text = "";
                    adatokbetoltese();

                }
                catch
                {
                    MessageBox.Show("Nem számot adtál meg");
                }
            }
            else
            {
                MessageBox.Show("Minden mezőt ki kell tölteni");
            }
        }
    }
}
