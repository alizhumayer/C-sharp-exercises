using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kopapirollo
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        string szamitogep = "";
        string jatekos = "";
        int szgpont = 0;
        int jatekospont = 0;
        private void ellenoriz()
        {
            switch (r.Next(0, 3))
            {
                case 0: szamitogep = "kő"; gepvalasztpictureBox.ImageLocation = "kő.jpg"; break;
                case 1: szamitogep = "papír"; gepvalasztpictureBox.ImageLocation = "Papier.jpg"; break;
                case 2: szamitogep = "olló"; gepvalasztpictureBox.ImageLocation = "olló.jpg"; break;
            }
            if (
                     (jatekos == "kő" && szamitogep == "papír") ||
                     (jatekos == "papír" && szamitogep == "olló") ||
                     (jatekos == "olló" && szamitogep == "kő")
                     )
            {
                szgpont++;
                eredmenyek.Text= "Vesztettél! Az állás számítógép-Játékos:" + Convert.ToString(szgpont)+"-"+ Convert.ToString(jatekospont);
            }
            else if (szamitogep == jatekos)
            {
                eredmenyek.Text = "Döntetlen! Az állás számítógép-Játékos:" + Convert.ToString(szgpont) + "-" + Convert.ToString(jatekospont);
            }
            else
            {
                jatekospont++;
                eredmenyek.Text = "Nyertél! Az állás számítógép-Játékos:" + Convert.ToString(szgpont) + "-" + Convert.ToString(jatekospont);
            }
        }
        public Form1()
        {
            InitializeComponent();
        }
       
        private void kopictureBox_Click(object sender, EventArgs e)
        {
            jatekos = "kő";
            ellenoriz();
            jatekosvalasztpictureBox.ImageLocation = "kő.jpg";

        }

        private void papirpictureBox_Click(object sender, EventArgs e)
        {
            jatekos = "papír";
            ellenoriz();
            jatekosvalasztpictureBox.ImageLocation = "Papier.jpg";
        }

        private void ollopictureBox_Click(object sender, EventArgs e)
        {
            jatekos = "olló";
            ellenoriz();
            jatekosvalasztpictureBox.ImageLocation = "olló.jpg";
        }

        
    }
}
