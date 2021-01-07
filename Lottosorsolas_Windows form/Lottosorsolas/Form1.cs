using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lottosorsolas
{
    public partial class btn_sorsolas : Form
    {
        public btn_sorsolas()
        {
            InitializeComponent();
        }
        Halmaz szamok;
        Halmaz szamok2;

        private void btn_sorsolas_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            szamok = new Halmaz(); //mindig újra létrehozza az előzőre
            szamok2 = new Halmaz();
            Random vsz = new Random();
            if (rb_otos.Checked == true)
            {
                do
                {
                    szamok.Halmazba(vsz.Next(1, 91));
                } while (szamok.Elemszam!=5);
            }
            else if(rb_hatos.Checked==true)
            {
                do
                {
                    szamok.Halmazba(vsz.Next(1, 46));
                } while (szamok.Elemszam != 6);
            }
            else
            {
                do
                {
                    szamok.Halmazba(vsz.Next(1, 36));
                } while (szamok.Elemszam != 7);
                do
                {
                    szamok2.Halmazba(vsz.Next(1, 36));
                } while (szamok2.Elemszam != 7);
            }
            if (rb_hatos.Checked==true || rb_otos.Checked==true)
            {
                MessageBox.Show("Számok: " + szamok.Kiir());
            }
            else
            {
                MessageBox.Show("Gépi számok: " + szamok.Kiir() + "\nKézi számok: " + szamok2.Kiir());
            }
        }
    }
}
