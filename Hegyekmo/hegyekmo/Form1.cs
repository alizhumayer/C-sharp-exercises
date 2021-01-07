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

namespace hegyekmo
{
    public partial class Form1 : Form
    {
        bool ok = true;
        int magassag;
        public Form1()
        {
            InitializeComponent();
            adatokbetoltese();
        }
        struct hegyek//Készítsen összetett változót az adatok tárolására!
        {
            public string hegycsucsnev;
            public string hegysegnev;
            public int magassag;
        }
        static hegyek[] adatok = new hegyek[1000];//Az állományban legfeljebb 1000 sor lehet. 
        private void adatokbetoltese()
        {
            string[] fajlbol = File.ReadAllLines("hegyekMo.txt");
            int sorokszama = 0;//sorok száma a fájlban
            int i, j;//ciklusváltozó
            for (int k = 1; k < fajlbol.Count(); k++)//Ügyeljen arra, hogy az állomány első sora az adatok fejlécét tartalmazza!
            {
                string[] egysordarabolva = fajlbol[k].Split(';');//Az adatokat pontosvessző választja el.
                adatok[sorokszama].hegycsucsnev = egysordarabolva[0];
                adatok[sorokszama].hegysegnev = egysordarabolva[1];
                adatok[sorokszama].magassag = Convert.ToInt32(egysordarabolva[2]);
                sorokszama++;
            }
            int hegyekszama = sorokszama;            
            listBox1.Items.Add("Hegycsúcs neve" + "\t " + "Hegység" + "\t " + " Magasság");
            for (i = 0; i < hegyekszama; i++)
            {
                listBox1.Items.Add(adatok[i].hegycsucsnev + "\t " + adatok[i].hegysegnev + "\t " + adatok[i].magassag);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (hegycsucsnevtextBox.Text != "" && hegysegtextBox.Text != "" && magassagtextBox.Text != "")
            {
                string hegycsucsnev = hegycsucsnevtextBox.Text;
                string hegyseg = hegysegtextBox.Text;
                ok = true;
                try
                {
                   magassag = int.Parse(magassagtextBox.Text);
                }
                catch
                {
                    MessageBox.Show("Nem számot adtál meg");
                    ok = false;
                }
                if (ok)
                {
                    FileStream fnev = new FileStream("hegyekMo.txt", FileMode.Append);
                    StreamWriter fajlbairo = new StreamWriter(fnev, System.Text.Encoding.UTF8);
                    fajlbairo.WriteLine("{0};{1};{2}", hegycsucsnev, hegyseg, magassag);
                    fajlbairo.Close();
                    fnev.Close();
                    MessageBox.Show("Az állomány bővítése sikeres volt!", "üzenet");
                    hegycsucsnevtextBox.Text = "";
                    hegysegtextBox.Text = "";
                    magassagtextBox.Text = "";                   
                    listBox1.Items.Clear();
                    adatokbetoltese();
                    fajlbairo.Close();
                    fnev.Close();
                }
            }
            else
            {
                MessageBox.Show("Minden mezőt ki kell tölteni","üzenet");
            }
        }
    }
}
