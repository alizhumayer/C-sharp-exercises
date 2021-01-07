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
using System.Windows.Forms.DataVisualization.Charting;

namespace Idojaras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<List<int>> falvak = new List<List<int>>();
        List<int> fokok;
        int melegMin;


        private void btn_generate_Click(object sender, EventArgs e)
        {
            l_readDone.Visible = false;


            int faluDb, napDb;
            Random vsz = new Random();
            int seged;
            faluDb = (int)nud_faluk.Value;
            napDb = (int)nud_days.Value;
            melegMin = (int)nud_melegMin.Value;
            for (int i = 0; i < faluDb; i++)
            {
                fokok = new List<int>();
                for (int j = 0; j < napDb; j++)
                {
                    seged = vsz.Next(0,51);
                    fokok.Add(seged);

                 
                }
                falvak.Add(fokok);
                
            }
            btn_genOut.Enabled = true;
            btn_longest.Enabled = true;

        }

        private void btn_genOut_Click(object sender, EventArgs e)
        {
            l_readDone.Visible = false;

            string fileName = "adatok" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".txt"; 
            StreamWriter genWriter = File.CreateText(fileName);

            genWriter.WriteLine(falvak.Count + " " + falvak[0].Count + " " + melegMin);
            foreach (var fokok in falvak)
            {
                foreach (var value in fokok)
                {
                    genWriter.Write(value + " ");
                }
                genWriter.WriteLine();
            }
            genWriter.Close();
            btn_genOut.Enabled = false;


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn_genOut.Enabled = false;
            l_readDone.Visible = false;
            btn_longest.Enabled = false;
            l_longAvg.Visible = false;
            l_longH.Visible = false;
            l_longLength.Visible = false;
            btn_reset.Enabled = false;
        }

        private void btn_read_Click(object sender, EventArgs e)
        {
            btn_genOut.Enabled = false;
            l_readDone.Visible = false;
            if (ofd_find.ShowDialog() == DialogResult.OK) 
            {
                StreamReader olvaso = File.OpenText(ofd_find.FileName);
                string[] darabolt;
                int faludb, meresdb, minMeleg;
                darabolt = olvaso.ReadLine().Split(' ');
                try
                {
                    faludb = int.Parse(darabolt[0]);
                    meresdb = int.Parse(darabolt[1]);
                    minMeleg = int.Parse(darabolt[2]);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Hibás bemeneti fájl!");
                    throw;
                }
                melegMin = minMeleg;
                try
                {
                    for (int i = 0; i < faludb; i++)
                    {
                        fokok = new List<int>();
                        darabolt = olvaso.ReadLine().TrimEnd().Split(' ');
                        for (int j = 0; j < darabolt.Length; j++)
                        {
                            fokok.Add(int.Parse(darabolt[j]));
                        }
                        falvak.Add(fokok);
                    }
                    l_readDone.Visible = true;
                }
                catch (FormatException)
                {
                    MessageBox.Show("Hibás bemeneti fájl!");                  
                }
                
            }
            btn_longest.Enabled = true;
        }

        private void btn_longest_Click(object sender, EventArgs e)
        {
            l_readDone.Visible = false;

            int sorozatAvg,sorozatID;
            List<int> sorozat = new List<int>();
            int szStop, szHossz, szMaxhossz;
            szMaxhossz = 0;
            sorozatID = 0;
            sorozatAvg = 0;
            szStop = 0;
            int i = 0;
            int j = 0;
            foreach (var fokok in falvak)
            {
                szHossz = 0;
                foreach (var value in fokok)
                {
                    if (value>melegMin)
                    {
                        szHossz++;
                    }
                    else
                    {
                        if (szMaxhossz<szHossz)
                        {
                            szMaxhossz = szHossz;
                            sorozatID = i;
                            szStop = j-1;
                        }
                        szHossz = 0;
                    }
                    j++;
                }
                j = 0;
                i++;
                
            }
            sorozat.AddRange(falvak[sorozatID]);
            for (int k = 0; k < sorozat.Count; k++)
            {
                if (k>szStop-szMaxhossz && k<=szStop)
                {
                    sorozatAvg += sorozat[k];
                }
            }
            try
            {
                sorozatAvg = sorozatAvg / szMaxhossz;
            }
            catch (DivideByZeroException)
            {
                sorozatAvg = -1;
                
            }
           
            l_longAvg.Visible = true;
            l_longH.Visible = true;
            l_longLength.Visible = true;
            if (sorozatAvg<0)
            {
                l_longAvg.Text = "N/A";
                l_longLength.Text = "N/A";
                l_longH.Text = "N/A";
            }
            else
            {
                l_longAvg.Text = sorozatAvg.ToString();
                l_longLength.Text = szMaxhossz.ToString();
                l_longH.Text = (sorozatID + 1).ToString();
            }
            chart1.ChartAreas[0].AxisY.StripLines.Clear();
            StripLine stripline = new StripLine();         
            stripline.Interval = 0;
            stripline.IntervalOffset = melegMin;
            stripline.StripWidth = 1;
            stripline.BackColor = Color.Red;
            chart1.Series.Clear();
            chart1.Series.Add("A1");
            
            for (int l = 0; l < sorozat.Count; l++)
            {
                chart1.Series["A1"].Points.AddXY((l+1), sorozat[l]);
            }
            chart1.ChartAreas[0].AxisY.StripLines.Add(stripline);
            



            btn_generate.Enabled = false;
            btn_genOut.Enabled = false;
            btn_read.Enabled = false;
            btn_longest.Enabled = false;

            btn_reset.Enabled = true;
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            falvak.Clear();
            btn_generate.Enabled = true;
            btn_read.Enabled = true;

        }

    }
}
