using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace orszagok
{
    public partial class Form1 : Form
    {
        struct Rekord
        {
            public string orszagnev;
            public int terulet;
        }

        const int MAX = 40;
        Rekord[] adattomb = new Rekord[MAX];
        int n;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            n = 0;
            if (textBox1.Text != "")
            {
                if (File.Exists(textBox1.Text))
                {
                    StreamReader f = File.OpenText(textBox1.Text);

                    while (!f.EndOfStream && n < MAX)
                    {
                        adattomb[n].orszagnev = f.ReadLine();

                        string sor = f.ReadLine();
                        adattomb[n].terulet = int.Parse(sor);

                        listBox1.Items.Add(adattomb[n].orszagnev + " terület: " + adattomb[n].terulet.ToString());
                        n++;
                    }
                    f.Close();
                }
                else MessageBox.Show("Nem létező fájl.");
            }
            else MessageBox.Show("Nincs megadva fájlnév!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double teruletatlag = 0;
            for (int i = 0; i < n; i++)
            {
                teruletatlag += adattomb[i].terulet;
            }
            teruletatlag = teruletatlag / n;
            MessageBox.Show("Az országok területének átlaga: " + teruletatlag.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int db1 = 0;
            int db2 = 0;
            if (radioButton1.Checked)
            {                
                for (int i = 0; i < n; i++)
                {
                    if (adattomb[i].terulet > 100000) db1++;                    
                }
                MessageBox.Show("A 100 000-nél nagyobb területű országok száma: " + db1.ToString());
            }
            if (radioButton2.Checked)
            {                
                for (int j = 0; j < n; j++)
                {
                    if (adattomb[j].terulet < 100000) db2++;
                }
                MessageBox.Show(db2.ToString() + " db 100 000-nél kisebb területű ország van.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)           //SelectedItem == "Minimum"
            {
                int min = 0;
                for (int i = 0; i < n; i++)
                {
                    if (adattomb[i].terulet < min)      //lehet adattomb[i].terulet < adattomb[min].terulet
                    {
                        min = adattomb[i].terulet;      //ilyenkor  itt min = i;
                    }
                }
                MessageBox.Show("A legkisebb terület: " + min.ToString());
            }
            else
            {
                int max = 0;
                for (int j = 0; j < n; j++)
                {
                    if (adattomb[j].terulet > max)
                    {
                        max = adattomb[j].terulet;
                    }
                }
                MessageBox.Show("A legnagyobb terület: " + max.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (textBox2.Text != "")
                {
                    string file = textBox2.Text;
                    StreamWriter f = File.CreateText(file);
                    for (int i = 0; i < n; i++)
                    {
                        if (adattomb[i].terulet > 100000)
                        {
                            f.WriteLine(adattomb[i]);  //a fájlba mi kerüljön
                        }
                    }
                    f.Close();
                }
                else MessageBox.Show("Add meg a létrehozni kívánt fájl nevét.");
            }
            else if (radioButton2.Checked)
            {
                if (textBox2.Text != "")
                {
                    string file2 = textBox2.Text;
                    StreamWriter f2 = File.CreateText(file2);
                    for (int j = 0; j < n; j++)
                    {
                        if (adattomb[j].terulet < 100000)
                        {
                            f2.WriteLine(adattomb[j]);  //a fájlba mi kerüljön
                        }
                    }
                    f2.Close();
                }
                else MessageBox.Show("Add meg a létrehozni kívánt fájl nevét.");
            } 
        }
    }
}
