using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _160322
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            Random rn = new Random();
            int db = rn.Next(3, 11);
            for (int i = 0; i < db; i++)
            {
                listBox1.Items.Add(rn.Next(100, 1000));
                comboBox1.Items.Add(listBox1.Items[listBox1.Items.Count-1]);
                comboBox2.Items.Add(listBox1.Items[listBox1.Items.Count - 1]);
                comboBox3.Items.Add(listBox1.Items[listBox1.Items.Count - 1]);
            }
            btn_delete.Enabled = true;
            btn_sorszam.Enabled = true;
            btn_sort.Enabled = true;
            btn_ibe.Enabled = true;
            btn_count.Enabled = true;
            btn_beszur.Enabled = true;
            btn_keres.Enabled= true;
            gb_sort.Enabled = true;
            textBox1.Enabled = true;
            tb_ibe.Enabled = true;
            btn_kijelol.Enabled = true;



        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult valasz = MessageBox.Show("Biztos mindent törölsz?","Kérdés",MessageBoxButtons.YesNo);
            if (valasz == DialogResult.Yes)
            {
                listBox1.Items.Clear();
            }
            
        }

        private void btn_count_Click(object sender, EventArgs e)
        {
            MessageBox.Show(listBox1.Items.Count.ToString());
        }

        private void btn_sort_Click(object sender, EventArgs e)
        {
            int temp;
            if (rb_up.Checked)
            {
                listBox1.Sorted = true;
            }
            else if (rb_down.Checked)
            {
                listBox1.Sorted = false;
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    for (int j = 1; j < listBox1.Items.Count; j++)
                    {
                        if (i < j)
                        {
                            temp = (int)listBox1.Items[i];
                            listBox1.Items[i] = (int)listBox1.Items[j];
                            listBox1.Items[j] = temp;
                        }
                    }
                }
            } 
            
        }

        private void btn_ibe_Click(object sender, EventArgs e)
        {
            String ibe = " ";
            bool joe = false;
            int i_szam = 0;
            while (!joe)
            {
                try
                {
                    ibe = tb_ibe.Text;
                    i_szam = int.Parse(ibe);
                    i_szam = i_szam - 1;
                    joe = true;
                }
                catch (FormatException)
                {
                    MessageBox.Show("Egész számot adj meg!");
                    throw;
                }
            }
            if (joe && i_szam > listBox1.Items.Count-1 || i_szam < 0)
            {
                MessageBox.Show("A szám túl nagy vagy túl kicsi");
            }
            else
            {
                MessageBox.Show("A(z) " + (i_szam+1) + ". szám a: " + listBox1.Items[i_szam].ToString());
            }


        }

        private void btn_sorszam_Click(object sender, EventArgs e)
        {
            String ibe = " ";
            bool joe = false;
            int i_szam = 0;
            while (!joe)
            {
                try
                {
                    ibe = tb_ibe.Text;
                    i_szam = int.Parse(ibe);
                    i_szam = i_szam - 1;
                    joe = true;
                }
                catch (FormatException)
                {
                    MessageBox.Show("Egész számot adj meg!");
                    throw;
                }
            }
            if (joe && i_szam > listBox1.Items.Count - 1 || i_szam < 0)
            {
                MessageBox.Show("A szám túl nagy vagy túl kicsi");
            }
            else
            {
                listBox1.Items.RemoveAt(i_szam);
            }
        }

        private void btn_beszur_Click(object sender, EventArgs e)
        {
            String ibe = " ";
            bool joe = false;
            int i_szam = 0;
            while (!joe)
            {
                try
                {
                    ibe = tb_ibe.Text;
                    i_szam = int.Parse(ibe);
                    i_szam = i_szam - 1;
                    joe = true;
                }
                catch (FormatException)
                {
                    MessageBox.Show("Egész számot adj meg!");
                    throw;
                }
            }
            if (joe && i_szam > listBox1.Items.Count - 1 || i_szam < 0)
            {
                MessageBox.Show("A szám túl nagy vagy túl kicsi");
            }
            else
            {
                listBox1.Items.Insert(i_szam, textBox1.Text);
            }
            
            
        }

        private void btn_keres_Click(object sender, EventArgs e)
        {
            string keresett = textBox1.Text;
            bool megvan = false;
            int i = 0;
            while (!megvan && i<listBox1.Items.Count)
            {
                if (listBox1.Items[i].ToString() == textBox1.Text)
                {
                    megvan = true;

                }
                i++;
            }
            if (megvan)
            {
                MessageBox.Show("A keresett elem (" + textBox1.Text + ") a " + (i) + ". helyen található");
            }
            else
            {
                MessageBox.Show("Ilyen elem nemtalálható");
            }
            


        }

        private void btn_kijelol_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex>=0)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }           
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.index.hu");
        }
    }
}
