using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dohanyzaskalulator
{
    public partial class Form1 : Form
    {
        double osszeg,dbszam,dobozszam;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dbszam = Convert.ToDouble(cigarettaszam.Value);
            dobozszam =dbszam/Convert.ToDouble(cigiszam.Value);
            osszeg = dobozszam * Convert.ToDouble(dobozar.Value)*30;
            MessageBox.Show("ENNYIT KÖLT CIGARETTÁRA:" + "\n"+ "Havi összeg:"+Convert.ToString(osszeg) + "\n" + "Évi összeg: " + Convert.ToString(osszeg*12));
        }
    }
}
