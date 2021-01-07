using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13e_14_2_10_19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Halmaz<int> számok;

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_sorsolás_Click(object sender, EventArgs e)
        {
            
            Random vsz = new Random();
            if (rb_ötös.Checked==true)
            {
                számok = new Halmaz<int>(5);
                do
                {
                    számok.halmazba(vsz.Next(1, 91));
                } while (számok.Elemszám != 5);
            }
            if (rb_hatos.Checked == true)
            {
                számok = new Halmaz<int>(6);
                do
                {
                    számok.halmazba(vsz.Next(1, 46));
                } while (számok.Elemszám != 6);
            }
            Halmaz<int> skandi = new Halmaz<int>(7);
            if (rb_skandináv.Checked == true)
            {
                számok = new Halmaz<int>(7);
                do
                {
                    számok.halmazba(vsz.Next(1, 36));
                } while (számok.Elemszám != 7);
                do
                {
                    skandi.halmazba(vsz.Next(1, 36));
                } while (skandi.Elemszám != 7);

            }
            MessageBox.Show("Számok: " + számok.Kiir()+"\n"+skandi.Kiir());
        }
    }
}
