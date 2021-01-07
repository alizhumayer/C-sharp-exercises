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

namespace Horgaszverseny
{

    struct fogasok
    {
        public int halfajID;
        public int fogottDB;


    }


    public partial class Form1 : Form
    {
        List<string> halFajtak; //halfajták tárolása
        List<fogasok> kapasok; //halfajta(i) + fogott db / horgász
        List<int> aktHalak;




        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            halFajtak = new List<string>();
            addHalFajtak();
            dgw_tablazat.Visible = false;
            l_loser.Visible = false;
            l_winer.Visible = false;
        }


        public void addHalFajtak()
        {
            StreamReader halFLoad = new StreamReader("halfajtak.txt");
            try
            {
                halFLoad = File.OpenText("halfajtak.txt");
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Fájlok hiányoznak!");
                throw;
            }
            
            while (!halFLoad.EndOfStream)
            {
                halFajtak.Add(halFLoad.ReadLine());
            }

        }

        private void btn_gen_Click(object sender, EventArgs e)
        {
            int horgasz, halFajDb;
            int maxfoghato = 30;
            Random vsz = new Random();
            horgasz = (int)nud_horgaszok.Value;
            halFajDb = (int)nud_halfajtak.Value;
            fogasok seged;
            kapasok = new List<fogasok>();
            aktHalak = new List<int>();
            //fogható halak sorsolása
            for (int i = 0; i < halFajDb; i++)
            {
                aktHalak.Add(vsz.Next(0, halFajtak.Count));
            }
            
            //fogások sorsolása
            for (int i = 0; i < horgasz; i++)
            {
                for (int j = 0; j < halFajDb; j++)
                {
                    seged.halfajID = aktHalak[j];
                    seged.fogottDB = vsz.Next(0, maxfoghato+1);
                    kapasok.Add(seged);
                }
            }


            dgw_tablazat.Visible = true;
            l_loser.Visible = true;
            l_winer.Visible = true;


            tablazatFeltolt(horgasz, halFajDb);
            l_winer.Text = "Nyertes:" + win(horgasz, halFajDb).ToString() + ".horgász";
            l_winer.Font = new Font(l_winer.Font, l_winer.Font.Style | FontStyle.Bold);
            l_loser.Text = "Vesztes:" + lose(horgasz, halFajDb, maxfoghato).ToString() + ".horgász";
        }


        public void tablazatFeltolt(int horgaszok, int halfajok)
        {
            dgw_tablazat.RowCount = (horgaszok+1);
            dgw_tablazat.ColumnCount = halfajok;

            this.dgw_tablazat.DefaultCellStyle.Font = new Font("Arial", 8,FontStyle.Regular,GraphicsUnit.Point);

            //sorok elnevezése
            for (int i = 0; i < horgaszok+1; i++)
            {
                if (i<horgaszok)
                {
                    dgw_tablazat.Rows[i].HeaderCell.Value = (i + 1).ToString() + ". horgász";
                }
                else
                {
                    dgw_tablazat.Rows[i].HeaderCell.Value = "Össsz kifogott";
                } 
            }
            dgw_tablazat.RowHeadersWidth = 180;
            //oszlopok elnevezése
            for (int i = 0; i < halfajok; i++)
            {
                dgw_tablazat.Columns[i].HeaderText = halFajtak[aktHalak[i]];
            }
            //feltölt
            int db = 0;
            int m = 0;
            int n = 0;
            for (m = 0; m < horgaszok; m++)
            {
                for (n = 0; n < halfajok; n++)
                {
                    dgw_tablazat.Rows[m].Cells[n].Value = kapasok[db].fogottDB;
                    db++;
                }
            }
            List<int> szumFogasok = new List<int>();
            int seged;
            for (int i = 0; i < halfajok; i++)
            {
                seged = 0;
                for (int j = 0; j < horgaszok; j++)
                {
                    seged += (int)dgw_tablazat.Rows[j].Cells[i].Value;
                }
                szumFogasok.Add(seged);
                
            }
            for (int i = 0; i < halfajok; i++)
            {
                dgw_tablazat.Rows[m].Cells[i].Value = szumFogasok[i];
            }
            


        }
        public int win(int horgaszok, int halfajok)
        {
            List<int> szumHorgaszFogas = new List<int>();
            int topscore = 0;
            int winer = (horgaszok+1);
            int seged;
            for (int i = 0; i < horgaszok; i++)
            {
                seged = 0;
                for (int j = 0; j < halfajok; j++)
                {
                    seged += (int)dgw_tablazat.Rows[i].Cells[j].Value;
                }
                szumHorgaszFogas.Add(seged);

            }
            
            for (int i = 0; i < horgaszok; i++)
            {
                if (szumHorgaszFogas[i]>topscore)
                {
                    topscore = szumHorgaszFogas[i];
                    winer = i;
                }
            }
            return (winer+1);
        }

        public int lose(int horgaszok, int halfajok, int maxfoghato)
        {
            List<int> szumHorgaszFogas = new List<int>();
            int lowscore = (halfajok*maxfoghato+1);
            int loser = (horgaszok + 1);
            int seged;
            for (int i = 0; i < horgaszok; i++)
            {
                seged = 0;
                for (int j = 0; j < halfajok; j++)
                {
                    seged += (int)dgw_tablazat.Rows[i].Cells[j].Value;
                }
                szumHorgaszFogas.Add(seged);

            }

            for (int i = 0; i < horgaszok; i++)
            {
                if (szumHorgaszFogas[i] < lowscore)
                {
                    lowscore = szumHorgaszFogas[i];
                    loser = i;
                }
            }
            return (loser+1);
        }

    }
}
