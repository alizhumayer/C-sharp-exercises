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

namespace iter_req_keres
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] szamok = new int[91];
        public List<int> list = new List<int>();
        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog().ToString() == "OK")
            {
                DateTime ido1 = DateTime.Now;
                StreamReader olvas = File.OpenText(openFileDialog1.FileName);

                string[] darabolt;
                


                while (!olvas.EndOfStream)
                {
                    darabolt = olvas.ReadLine().Split(';');
                    for (int i = 0; i < darabolt.Length; i++)
                    {
                        list.Add(Convert.ToInt32(darabolt[i]));
                    }

                }
                olvas.Close();
                list.Sort();
                DateTime ido2 = DateTime.Now;
                MessageBox.Show(ido2.Subtract(ido1).ToString());
                MessageBox.Show("Átlag: " + list.Average().ToString());

                //int index = linkeres(list, list.Count, 78703);
                button2.Enabled = true;
                button3.Enabled = true;
                numericUpDown1.Enabled = true;

            }
        }
        static int linkeres(List<int> list, int n, int ertek)
        {
            int i = 0;            
            while (i < list.Count && list[i]!=ertek) 
            {                
                i++;
            }
            bool van = i < n;
            if (van)
            {
                return i;
            }
            else
            {
                return -1;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index = linkeres(list, list.Count, (int)numericUpDown1.Value);            
            label1.Text = index.ToString();
        }
        static int logkeres(List<int> list, int n, int ertek)
        {
            int bal = 0;
            int jobb = n;
            int kozep;
            do
            {
                kozep = (bal + jobb) / 2;
                if (list[kozep]>ertek)
                {
                    jobb = kozep - 1;
                }
                else if(list[kozep] < ertek)
                {
                    bal = kozep + 1;
                }
            } while (bal<jobb&&list[kozep]!=ertek);
            bool van = bal < jobb;
            if (van)
            {
                return kozep;
            }
            else
            {
                return -1;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int index = logkeres(list, list.Count, (int)numericUpDown1.Value);
            label2.Text = index.ToString();
        }
    }
}
