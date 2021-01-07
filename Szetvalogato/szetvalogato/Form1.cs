using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.IO;

namespace szetvalogato
{
    public partial class Form1 : Form
    {
        public object Interaction { get; private set; }


        const int MAX = 100;
        int[] szamok = new int[MAX];
        int szam;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            szam = 0;
            string fajlnev = "szamok.txt";

            StreamReader fn = File.OpenText(fajlnev);
            while (!fn.EndOfStream && szam < MAX)
            {
                string sor = fn.ReadLine();
                szamok[szam] = int.Parse(sor);
                if (szamok[szam] % 2 == 0)
                {
                    listBox1.Items.Add(sor);
                }
                else
                {
                    listBox2.Items.Add(sor);
                }
                szam++;
            }
            fn.Close();
            button2.Enabled = true;            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fnev = "rendezettszamok.txt";

            StreamWriter fn = File.CreateText(fnev);
            fn.WriteLine("Páros számok: ");
            for (int i = 0; i < szam; i++)
            {
                if (szamok[i] % 2 == 0)
                {
                    fn.WriteLine(szamok[i]);
                }
            }
            fn.WriteLine("Páratlan számok: ");
            for (int i = 0; i < szam; i++)
            {
                if (szamok[i] % 2 != 0)
                {
                    fn.WriteLine(szamok[i]);
                }
            }
            fn.Close();
            MessageBox.Show("A számokat rendezetten a "+ fnev +" fájlba írtam.");
        }
    }
}
