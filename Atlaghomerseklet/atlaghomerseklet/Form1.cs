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

namespace atlaghomerseklet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sorok, oszlopok;
        static int[,] matrix;
        static int osszegzes, ossz_db;
        static double atlag;



        private void btn_feltolt_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog().ToString() == "OK")
            {
                int[] sor_oszlop = new int[2];
                StreamReader be = File.OpenText(openFile.FileName);
                string[] darabolt = be.ReadLine().Split(' ');
                matrix = new int[int.Parse(darabolt[0]), int.Parse(darabolt[1])];
                sorok = int.Parse(darabolt[0]);
                oszlopok = int.Parse(darabolt[1]);
                dataGridView1.RowCount = sorok;
                dataGridView1.ColumnCount = oszlopok;
                for (int i = 0; i < sorok; i++)
                {
                    darabolt = be.ReadLine().Split(' ');
                    for (int j = 0; j < oszlopok; j++)
                    {
                        matrix[i, j] = int.Parse(darabolt[j]);
                        dataGridView1.Rows[i].Cells[j].Value = matrix[i, j];
                    }
                }
                be.Close();
            }
            btn_atlag.Enabled = true;
            btn_legmelegebb.Enabled = true;
            btn_fok.Enabled = true;
            btn_fokalatt.Enabled = true;
            textBox1.Enabled = true;
            van_e.Enabled = true;
            button4.Enabled = true;
        }

        private void btn_fok_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[0].Cells[0].Selected = false;
            int db = 0;
            for (int i = 0; i < sorok; i++)
            {
                for (int j = 0; j < oszlopok; j++)
                {
                    if (matrix[i,j]>10)
                    {
                        
                        db++;
                        dataGridView1.Rows[i].Cells[j].Selected = true;
                    }
                }
            }
            fok10_alatt.Text = db + " alkalommal";
        }

        private void btn_fokalatt_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[0].Cells[0].Selected = false;

            int db = 0;
            for (int i = 0; i < sorok; i++)
            {
                for (int j = 0; j < oszlopok; j++)
                {
                    if (matrix[i, j] < 10)
                    {                       
                        db++;
                        dataGridView1.Rows[i].Cells[j].Selected = true;
                    }
                }
            }
            l_fokalatt.Text = db + " alaklommal";
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            int bekertszam = int.Parse(textBox1.Text);
            bool talaltam = false;
            int talaltdb = 0;

            dataGridView1.Rows[0].Cells[0].Selected = false;

            for (int i = 0; i < sorok; i++)
            {
                for (int j = 0; j < oszlopok; j++)
                {
                    if (matrix[i,j]==bekertszam)
                    {
                        talaltdb++;
                        talaltam = true;
                        dataGridView1.Rows[i].Cells[j].Selected = true;


                    }
                }
                               
            }
            if (talaltam==true)
            {
                van_e.ForeColor = Color.Green;
                van_e.Text = talaltdb + " találat";
            }
            else
            {
                van_e.ForeColor = Color.Red;
                van_e.Text = "Nem találtam ilyet";
            }
        }

        private void btn_atlag_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < sorok; i++)
            {
                for (int j = 0; j < oszlopok; j++)
                {
                    osszegzes = osszegzes + matrix[i, j];
                }
            }
            ossz_db = sorok * oszlopok;
            atlag = osszegzes / ossz_db;
            atlag_ki.Text = atlag.ToString();
        }

        private void btn_legmelegebb_Click(object sender, EventArgs e)
        {
            int max = matrix[0, 0];
            int maxi = 0;
            int maxj = 0;
            for (int i = 0; i < sorok; i++)
            {
                for (int j = 0; j < oszlopok; j++)
                {
                    if (matrix[i, j] > max)
                    {
                        max = matrix[i, j];
                        maxi = i;
                        maxj = j;

                    }
                }
            }
            legmelegebb.Text = max.ToString();
            dataGridView1.Rows[0].Cells[0].Selected = false;
            dataGridView1.Rows[maxi].Cells[maxj].Selected = true;
        }
    }
}
