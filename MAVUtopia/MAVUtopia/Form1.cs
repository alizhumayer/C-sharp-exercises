using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace MAVUtopia
    {
    public partial class Form1 : Form
        {
        public Form1()
            {
            InitializeComponent();
            }
        public int allomasDB;
        public int jegyar;
        public int koltsegek;
        public List<mozgasok> felLe;
        public struct mozgasok
            {
            public int felSzallok;
            public int leSzallok;
            }

        Stopwatch idoMero;

        private void Form1_Load(object sender, EventArgs e)
            {
            btn_do.Enabled = false;
            l_eredm.Visible = false;
            l_lefutasiIdo.Visible = false;




        }

        private void btn_read_Click(object sender, EventArgs e)
            {
            if (ofd_beolvas.ShowDialog() == DialogResult.OK)
                {
                StreamReader olvaso = File.OpenText(ofd_beolvas.FileName);
                bool minuszUtas = false;
                int utazok = 0;
                mozgasok seged = new mozgasok();
                string[] darabolt;
                int i = 0;
                try
                    {
                    allomasDB = int.Parse(olvaso.ReadLine());
                    }
                catch (FormatException)
                    {
                    MessageBox.Show("Hibás bemeneti fájl!");                    
                    }
                try
                    {
                    darabolt = olvaso.ReadLine().Split(' ');
                    jegyar = int.Parse(darabolt[0]);
                    koltsegek = int.Parse(darabolt[1]);
                    }
                catch (FormatException)
                    {
                    MessageBox.Show("Hibás bemeneti fájl!");
                    }
                try
                    {
                    l_eredm.Visible = false;
                    l_lefutasiIdo.Visible = false;
                    btn_do.Enabled = false;
                    felLe = new List<mozgasok>();
                    felLe.Clear();
                    while (!olvaso.EndOfStream)
                        {
                        darabolt = olvaso.ReadLine().Split(' ');
                        seged.felSzallok = int.Parse(darabolt[1]);
                        seged.leSzallok = int.Parse(darabolt[0]);

                        felLe.Add(seged);
                        i++;
                        utazok = utazok + int.Parse(darabolt[1]) - int.Parse(darabolt[0]);
                        if (utazok<0)
                            {
                            minuszUtas = true;
                            }
                        }
                    olvaso.Close();
                    
                    }
                catch (FormatException)
                    {
                    MessageBox.Show("Hibás bemeneti fájl!");
                    }



                if (minuszUtas)
                    {
                    MessageBox.Show("Az utasok száma egy ponton minuszba került: " + i.ToString());                  
                    }
                else
                    {
                    MessageBox.Show("Beolvasás kész!");
                    btn_do.Enabled = true;
                    }

                

                } 
            }

        private void btn_do_Click(object sender, EventArgs e)
            {
            idoMero = new Stopwatch();
            idoMero.Start();
            int nyereseg = 0;
            bool nyertekRajta = false;
            int bevetel = 0;
            int kiadas = 0;
            int utasokMost = 0;
            List<int> aktBevetel = new List<int>();
            int allomasdbMinuszEgy = allomasDB - 1;
            int i;
            for (i = 0; i < allomasdbMinuszEgy; i++)
                {
                utasokMost = utasokMost + felLe[i].felSzallok - felLe[i].leSzallok;
                bevetel = (utasokMost * jegyar );
                if (i>0)
                {
                    kiadas = koltsegek;
                }
                else
                {
                    kiadas = 0;
                }
               
                nyereseg = bevetel - kiadas;
                if (i>0)
                {
                    aktBevetel.Add((aktBevetel[i-1] + nyereseg));
                }
                else
                {
                    aktBevetel.Add(nyereseg);
                }
                
                }
            int j = 0;
            
                while (!nyertekRajta && j < aktBevetel.Count)
                {
                if (j == 0 && aktBevetel[j]>koltsegek)
                {
                    nyertekRajta = true;
                }
                else
                {
                    j++;
                    if (aktBevetel[j] > aktBevetel[j - 1])
                    {
                        nyertekRajta = true;
                    }
                }
                
                    
                }

            //int ossz = 0;
            //for (int i = 0; i < aktBevetel.Count; i++)
            //    {
            //    ossz += aktBevetel[j];
            //    }
            l_eredm.Visible = true;
            l_lefutasiIdo.Visible = true;
            if (!nyertekRajta)
            {
                l_eredm.Text = "Eredmény: 0 Nincs olyan pont ahol nyereseges lett volna.";
            }                
            else if (j==0)
            {
                l_eredm.Text = "Eredmény: 0 A vonat már az első állomásnál pénz hozott. ";
            }
            else
            {
                l_eredm.Text = "Eredmény: " + (j + 1).ToString() + " Profit: " + aktBevetel[j] + " ft";
            }

            idoMero.Stop();
            l_lefutasiIdo.Text = "Lefutási idő: " + idoMero.ElapsedMilliseconds.ToString() + " ms";
            idoMero.Reset();
            
        }
        }
    }
