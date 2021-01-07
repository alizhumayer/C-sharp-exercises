using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Osztalypenz
{
    public partial class Form1 : Form
    {
        // kezdőértékek beállítása

        int db = 0;
        int egyenleg = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Tranzakcio()
        {
            // megadtunk-e minden adatot?

            if (textBox1.Text != "" && textBox2.Text != "")
            {
                try
                {
                    int penz = int.Parse(textBox2.Text);
                    if (penz > 0)
                    {
                        // befizetés kezelése
                        if (radioButton1.Checked)
                        {
                            db++;
                            egyenleg += penz;
                            label5.Text = egyenleg.ToString() + " Ft";
                            listBox1.Items.Add(db.ToString() + ". tranzakció: " + textBox1.Text + " befizetett " + penz.ToString() + " Ft-ot.");
                        }
                        // kifizetés kezelése
                        else
                        {
                            if (egyenleg >= penz)
                            {
                                db++;
                                egyenleg -= penz;
                                label5.Text = egyenleg.ToString() + " Ft";
                                listBox1.Items.Add(db.ToString() + ". tranzakció: " + penz.ToString() + " Ft-ot kifizettünk " + textBox1.Text + " részére.");
                            }
                            else
                            {
                                MessageBox.Show("A tranzakcióra nincsen fedezet!");
                            }
                        }
                        textBox1.Text = "";
                        textBox2.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Hibás összeg!");
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Hibás adatbevitel!");
                }
            }
            else
            {
                MessageBox.Show("Nem adtál meg minden szükséges adatot!");
            }
        }

        private void Mentes()
        {
            // A ListBox tartalmának, és az egyenlegnek fájlba mentése

            StreamWriter f = File.CreateText("osztalypenz.txt");
            f.WriteLine(egyenleg);
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                f.WriteLine(listBox1.Items[i]);
            }
            f.Close();
            MessageBox.Show("Az osztálypénz nyilvántartását az osztalypenz.txt fájlba írtam.");
        }

        private void Betoltes()
        {
            // A ListBox tartalmának, és az egyenlegnek betöltése fájlból

            if (File.Exists("osztalypenz.txt"))
            {
                listBox1.Items.Clear();
                db = 0;
                StreamReader f = File.OpenText("osztalypenz.txt");
                egyenleg = int.Parse(f.ReadLine());
                label5.Text = egyenleg.ToString() + " Ft";
                while (!f.EndOfStream)
                {
                    listBox1.Items.Add(f.ReadLine());
                    db++;
                }
                f.Close();
            }
            else
            {
                MessageBox.Show("A megadott fájl nem található");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tranzakcio();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mentes();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Betoltes();
        }

    }
}
