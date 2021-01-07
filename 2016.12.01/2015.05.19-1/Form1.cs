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

namespace _2015._05._19_1
{
    public partial class Form1 : Form
    {
        struct stVaros
        {
            public string vnev;
            public int vfo;
        }
        stVaros[] rVaros = new stVaros[100];
        public int sz = 0;
        public int szamlalo = 0;
        public Form1()
        {
            InitializeComponent();
            btn_atlagolas.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int sz = 0;
            try
            {
                StreamReader fv_be = File.OpenText("Varosok.txt");
                sz = 0;
                string sor, vnev, vfo = "";
                while (!fv_be.EndOfStream)
                {
                    // ------------------------ lisboxba való beolvasás kezdete
                    vnev = fv_be.ReadLine();
                    vfo = fv_be.ReadLine();
                    sor = vnev + " " + vfo + " fő";
                    listBox1.Items.Add(sor);
                    // ------------------------ lisboxba való beolvasás vége

                    // ------------------------ REKORDBA való beolvasás kezdete
                    rVaros[sz].vnev = vnev;
                    rVaros[sz].vfo = Convert.ToInt32(vfo);
                    sz++;
                    // ------------------------ REKORDBA való beolvasás vége
                }
                fv_be.Close();
                btn_atlagolas.Enabled = true;
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Nincs meg a 'Varosok.txt'");
            }
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int oszzeg = 0;
            double atlag = 0;
            for (int i = 0; i <= sz-1; i++)
            {
                oszzeg = oszzeg + rVaros[i].vfo;
            }
            atlag = oszzeg / sz;
            listBox1.Items.Add("");
            listBox1.Items.Add("A városok átlag lélekszáma " + atlag + " fő.");

            MessageBox.Show("A városok átlag lélekszáma " + atlag + " fő.");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "Minimum";
            timer1.Enabled = true;
            radioButton1.Checked = true;
            button2.Enabled = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int i;
            int MinInd = 0;
            int MaxInd = 0;

            if (comboBox1.Text == "Minimum")
            {
                for (i = 1; i <= sz-1; i++)
                {
                    if (rVaros[i].vfo < rVaros[MinInd].vfo)
                    {
                        MinInd = i;
                    }
                }
            MessageBox.Show("A legkisebb lélekszámú város: " + rVaros[MinInd].vnev);
            }

            else
            {
                for (i = 1; i <= sz - 1; i++)
                {
                    if (rVaros[i].vfo > rVaros[MaxInd].vfo)
                    {
                        MaxInd = i;
                    }
                }
                MessageBox.Show("A legnagyobb lélekszámú város: " + rVaros[MaxInd].vnev);
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            szamlalo++;
            label3.Text = Convert.ToString(szamlalo);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            int lelszum = 0;
            if (radioButton1.Checked == true)
            {
                for (int i = 0; i <= sz - 1; i++)
                {
                    if (rVaros[i].vfo<200000)
                    {
                        lelszum++;
                    }
                }
                MessageBox.Show("A 200 000-nél kisebb lélekszámú városok száma: " + lelszum);
            }
            else
            {
                for (int i = 0; i <= sz - 1; i++)
                {
                    if (rVaros[i].vfo > 200000)
                    {
                        lelszum++;
                    }
                }
                MessageBox.Show("A 200 000-nél nagyobb lélekszámú városok száma: " + lelszum);
            }
        }
    }
}
