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

namespace FelszallokSzama
    {
    public partial class Form1 : Form
        {
        public Form1()
            {
            InitializeComponent();
            }
        List<int> lista;
        public static int allomasDB;
        private void btn_do_Click(object sender, EventArgs e)
            {
            
            if (ofd_beolvas.ShowDialog() == DialogResult.OK)
                {
                l_eredm.Visible = false;
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
                lista = new List<int>();
                int osszFelszallo = 0;
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
                    while (i<allomasDB)
                        {
                        darabolt = olvas.ReadLine().Split(' ');
                        lista.Add(int.Parse(darabolt[1]));
                        i++;
                        }
                   

                    }
                catch (FormatException)
                    {
                    MessageBox.Show("Rossz fájl!");
                    throw;
                    }
                for (int i = 0; i < lista.Count; i++)
                    {
                    osszFelszallo += lista[i];
                    }
                l_eredm.Visible = true;
                l_eredm.Text = "Felszállók száma: " + osszFelszallo;
              


                    


                }
            }

        private void Form1_Load(object sender, EventArgs e)
            {
            l_eredm.Visible = false;
            }
        }
    }
