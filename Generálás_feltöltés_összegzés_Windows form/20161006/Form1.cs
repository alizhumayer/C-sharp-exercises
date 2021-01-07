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

namespace _20161006
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (mentes.ShowDialog().ToString()=="OK")
            {
                StreamWriter ki = File.CreateText(mentes.FileName);
                Random r = new Random();
                for (int sor = 0; sor < 10; sor++)
                {
                    for (int oszlop = 0; oszlop < 7; oszlop++)
                    {
                        ki.Write(r.Next(-10, 21).ToString() + " ");
                    }
                    ki.WriteLine(r.Next(-10, 21).ToString() + " ");
                    
                }
                ki.Close();
            } 
        }
        static int[,] matrix = new int[10, 8];
        private void button2_Click(object sender, EventArgs e)
        {
            if (megnyitas.ShowDialog().ToString()=="OK")
            {
                
                StreamReader be = File.OpenText(megnyitas.FileName);
                for (int sor = 0; sor < 10; sor++)
                {
                    string[] darabolt = be.ReadLine().Split(' ');
                    for (int oszlop = 0; oszlop < 8; oszlop++)
                    {
                        matrix[sor, oszlop] = int.Parse(darabolt[oszlop]);
                    }  
                }
                be.Close();
                dataGridView1.RowCount = 10;
                dataGridView1.ColumnCount = 8;
                for (int sor = 0; sor < 10; sor++)
                {
                    for (int oszlop = 0; oszlop < 8; oszlop++)
                    {
                        dataGridView1.Rows[sor].Cells[oszlop].Value = matrix[sor, oszlop];
                    }
                }



                osszeg.Enabled = true;
                btn_min.Enabled = true;
                btn_vane.Enabled = true;
            }
        }
        static int osszegzes = 0;
        private void osszeg_Click(object sender, EventArgs e)
        {
            for (int sor = 0; sor < 10; sor++)
            {
                for (int oszlop = 0; oszlop < 8; oszlop++)
                {
                    osszegzes = osszegzes + matrix[sor, oszlop];
                }
            }
            label1.Text ="A számok összege: " + osszegzes.ToString();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            int min = matrix[0, 0];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (matrix[i,j]<min)
                    {
                        min = matrix[i, j];
                    }
                }
            }
            this.Text = "Minimum:" + min.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_vane_Click(object sender, EventArgs e)
        {
            bool talalt = false;
            int i = 0;

            while (i<10&&!talalt)
            {
                int j = 0;
                while (j<8 && !talalt)
                {
                    if (matrix[i,j]%3==0)
                    {
                        talalt = true;
                    }
                    j++;
                }
                i++;
            }
            if (talalt==true)
            {
                MessageBox.Show("Találtam");
            }
            else
            {
                MessageBox.Show("Nem talált");
            }
        }
    }
}
