using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace elso
{
    public partial class Form1 : Form
    {
        List<adat> adatok = new List<adat>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bevitel_Click(object sender, EventArgs e)
        {
            try
            {
                adatok.Add(new adat(nev.Text,Convert.ToInt32(szul_ev.Text)));
                levf_box.Text = adatok[legfiatalabb()].kora(DateTime.Now.Year).ToString();
                darab_box.Text = adatok.Count.ToString();
                atlag_box.Text = atlag().ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public int legfiatalabb()
        {
            int max_index = 0;
            for (int i = 1; i < adatok.Count; i++)
            {
                if(adatok[i].kor > adatok[max_index].kor)
                {
                    max_index = i;
                }
            }
            return max_index;
        }
        public double atlag()
        {
            int ossz = 0;
            for (int i = 0; i < adatok.Count; i++)
            {
                ossz = ossz + adatok[i].kora(DateTime.Now.Year);
            }
            return (double)ossz/adatok.Count;
        }
    }
}
