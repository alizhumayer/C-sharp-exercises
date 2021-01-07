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

namespace _20160929
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn_Bezar.Enabled = true;
            this.BackColor = Color.Red;
            btn_Bezar.BackColor = Color.Green;
            
        }

        private void btn_Bezar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public struct Hal
        {
            public int hossz;
            public int suly;
        }      
        public Hal[] halak;
        

        private void btn_megnyitas_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            StreamReader be = File.OpenText(openFileDialog1.FileName);
            int sorokszama = 0;
            while (!be.EndOfStream)
            {
                be.ReadLine();
                sorokszama++;
            }
            be.Close();
            halak = new Hal[sorokszama / 2];
            be = File.OpenText(openFileDialog1.FileName);
            for (int i = 0; i < sorokszama/2; i++)
            {
                halak[i].hossz = int.Parse(be.ReadLine());
                halak[i].suly = Convert.ToInt32(be.ReadLine());
            }
            be.Close();
            btn_Atlag.Enabled = true;
            btn_legnhal.Enabled = true;
            btn_sulyki.Enabled = true;
            btn_kiir.Enabled = true;
            btn_legnhal.Enabled = true;

        }

        double halhosszatlag = 0;
        double halsulyatlag = 0;
        double halsulyatlag2 = 0;
        private void btn_Atlag_Click(object sender, EventArgs e)
        {
           
            for (int i = 0; i < halak.Length ; i++)
            {
                halhosszatlag = (halhosszatlag + halak[i].hossz)/halak.Length;
                halsulyatlag = (halsulyatlag + halak[i].suly)/halak.Length;
            }
            MessageBox.Show("A halak súlyának átlaga:"+ halsulyatlag + "\nA halak hosszának átlaga:" + halhosszatlag);
            
        }

        private void btn_sulyki_Click(object sender, EventArgs e)
        {
            int[] halsuly = new int[halak.Length];
            for (int i = 0; i < halak.Length; i++)
            {
                halsuly[i] = halak[i].suly;
                i++;
                
            }
            for (int i = 0; i < halak.Length; i++)
            {
                halsulyatlag2 = (halsulyatlag2 + halsuly[i]) / halak.Length;
            }
            MessageBox.Show("A halak súlyának átlaga: " + halsulyatlag2);
                  
          
        }

        private void btn_legnhal_Click(object sender, EventArgs e)
        {
            int legnhal = 0;
            for (int i = 0; i < halak.Length; i++)
            {
                if (halak[i].suly>legnhal)
                {
                    legnhal=halak[i].suly;
                }
                 
            }
        }

        private void leghhal_Click(object sender, EventArgs e)
        {
            int leghhal = 0;
            for (int i = 0; i < halak.Length; i++)
            {
                if (halak[i].hossz > leghhal)
                {
                    leghhal = halak[i].hossz;
                }

            }
            label1.Text = leghhal.ToString() ;
        }

        private void btn_kiir_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            StreamWriter ki = File.CreateText(saveFileDialog1.FileName);
            for (int i = 0; i < halak.Length; i++)
            {
                ki.WriteLine("{0}.hal hossza: {1}", i + 1, halak[i].hossz);
            }
            this.Close();
        }
        
    }
}
