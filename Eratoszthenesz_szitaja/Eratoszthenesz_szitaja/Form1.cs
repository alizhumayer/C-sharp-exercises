using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eratoszthenesz_szitaja
{
    public partial class Form1 : Form
    {
        Szita szitam;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cb_ie.Items.Add("Prímek mentése");
            //cb_ie.Items.Add("Import");
            //cb_ie.Items.Add("Export");
            cb_ie.SelectedIndex = 0;
        }
        
        private void listazd()
        {
            bool joe = false;
            int n;
            try
            {
                n = int.Parse(cb_max.Text);
                joe = true;
                cb_max.Items.Add(n);
            }
            catch (FormatException)
            {
                MessageBox.Show("Pozitív egész számot adj meg!");
                throw;
            }

            if (joe)
            {
                szitam = new Szita(n);
            }

            szitam.szitalas();


            l_elemszam.Text = "Elemek száma: " + szitam.elemszam;
            l_szum.Text = "Szum: " + szitam.szum;
            l_atlag.Text = "Átlag: " + szitam.atlag;
            lb_primek.Items.Clear();
            for (int i = 0; i < szitam.elemszam; i++)
            {
                lb_primek.Items.Add(szitam.szamok[i]);
            }
        }


        private void btn_listaz_Click(object sender, EventArgs e)
        {
            listazd();
            
        }

        private void vegrehajtas()
        {
            if (cb_ie.SelectedIndex == 0)
            {
                szitam.fajlba_primek();
            }
        }

        private void btn_do_Click(object sender, EventArgs e)
        {
            vegrehajtas();
        }

        private void cb_max_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                listazd();
            }
        }

        private void cb_ie_KeyPress(object sender, KeyPressEventArgs e)
        {
            vegrehajtas();
        }
    }
}
