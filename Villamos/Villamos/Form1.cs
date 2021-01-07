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

namespace Villamos
    {
    public partial class Form1 : Form
        {
        public Form1()
            {
            InitializeComponent();
            }
        public struct megalloAdatok
            {
            public int tavolsag;
            public int idoErkezes;
            public int idoIndulas;
            }
        
        List<megalloAdatok> listam = new List<megalloAdatok>();
        public int allomasDB;
        int leghosszabbSzakaszID;
        int leghosszabbSzakaszHossz;
        int leghosszabbUtazasiIdo;
        int leghosszabbUtazasiIdoStart;
        int leghosszabbUtazasiIdoStop;

        List<int> hosszabbak = new List<int>();

        private void btn_beolvas_Click(object sender, EventArgs e)
            {
            
            if (ofd_beolvas.ShowDialog() == DialogResult.OK)
                {
                StreamReader olvas;
                try
                    {
                    olvas = File.OpenText(ofd_beolvas.FileName);
                    }
                catch (FileNotFoundException)
                    {
                    MessageBox.Show("Rossz fájl!");
                    throw;
                    }
                string[] darabolt;
                megalloAdatok seged;
                try
                    {
                    allomasDB = int.Parse(olvas.ReadLine());
                    }
                catch (FormatException)
                    {
                    MessageBox.Show("Rossz fájl!");
                    throw;
                    }
                try
                    {
                    int i = 0;
                    while (i < allomasDB)
                        {
                        darabolt = olvas.ReadLine().Split(' ');
                        seged.tavolsag = int.Parse(darabolt[0]);
                        seged.idoErkezes = int.Parse(darabolt[1]);
                        seged.idoIndulas = int.Parse(darabolt[2]);
                        listam.Add(seged);
                        i++;
                        }


                    }
                catch (FormatException)
                    {
                    MessageBox.Show("Rossz fájl!");
                    throw;
                    }
                olvas.Close();
                leghosszabbSzakaszID = 0;
                leghosszabbSzakaszHossz = listam[0].tavolsag;

                leghosszabbUtazasiIdo = listam[1].idoErkezes - listam[0].idoIndulas;
                for (int i = 0; i < listam.Count; i++)
                    {
                    if (listam[i].tavolsag > leghosszabbSzakaszHossz)
                        {
                        leghosszabbSzakaszHossz = listam[i].tavolsag;
                        leghosszabbSzakaszID = i+1;
                        }                    
                    }
                label1.Text = "A legnagyobb táv két szakasz közt: " + leghosszabbSzakaszHossz + "Ez a " + leghosszabbSzakaszID + ". szakasz";
                for (int i = 1; i < listam.Count; i++)
                    {
                    if (i==1)
                        {
                        leghosszabbUtazasiIdoStart = i;
                        leghosszabbUtazasiIdoStop = i + 1;
                        }
                    else if (listam[i].idoErkezes - listam[i-1].idoIndulas > leghosszabbUtazasiIdo && i!=1)
                        {
                        leghosszabbUtazasiIdo = listam[i].idoErkezes - listam[i - 1].idoIndulas;
                        leghosszabbUtazasiIdoStart = i;
                        leghosszabbUtazasiIdoStop = i+1;
                        }
                    }
                label2.Text = "A legtöbb ido két szakasz közt: " + leghosszabbUtazasiIdo + "Indulási állomás_: " + leghosszabbUtazasiIdoStart + " Érkezési: " +
                    leghosszabbUtazasiIdoStop;

                int maxido = listam[0].idoErkezes;
                hosszabbak.Add(1);
                for (int i = 1; i < listam.Count; i++)
                    {
                    if (listam[i].idoErkezes - listam[i - 1].idoIndulas>maxido)
                        {
                        maxido = listam[i].idoErkezes - listam[i - 1].idoIndulas;
                        hosszabbak.Add(i + 1);
                        }
                    }
                string kiir = hosszabbak.Count + " ";
                for (int i = 0; i < hosszabbak.Count; i++)
                    {
                    kiir += hosszabbak[i] + " ";
                    }

                label3.Text = kiir;

                }
            }
        }
    }
