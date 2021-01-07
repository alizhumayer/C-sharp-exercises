using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lufiloveszet
{
    public partial class Form1 : Form
    {
        //változók deklarálása
        int y;//a golyó y koordinátája
        int leggomblepes = 5;//a léggömb új helyzete ennyivel változik
        int golyolepes = 10;//a golyó új helyzete ennyivel változik
        Random veletlen = new Random();
        int talalatokszama = 0;
        int lovesekszama = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = timer2.Interval = 60;//időzítő beállítása
            timer2.Stop();//időzítő leállítása
            timer1.Start();//időzítő elindítása
            y = pictureBox2.Top;  // A golyó függőleges pozíciójának elmentése
            pictureBox2.Hide();         // A golyó eltüntetése
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Show();
            pictureBox1.Left += leggomblepes; // A léggömb léptetése
            if ((pictureBox1.Left + pictureBox1.Width >= this.ClientSize.Width) || (pictureBox1.Left <= 0)) // Az ablak jobb széléről visszafelé indul el
            {
                leggomblepes = -leggomblepes;        // visszafelé
                timer1.Interval = veletlen.Next(30, 200); // új sebességgel, hogy érdekesebb legyen a játék
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox2.Top -= golyolepes;  // A golyó léptetése
            if ((pictureBox2.Left >= pictureBox1.Left) && (pictureBox2.Right <= pictureBox1.Right) &&
                (pictureBox2.Top >= pictureBox1.Top) && (pictureBox2.Bottom <= pictureBox1.Bottom)) // Ha a golyó bemegy a léggömbbe
            {
                pictureBox2.Hide();//a golyó kép elrejtése
                pictureBox1.Hide();//a lufi kép elrejtése
                pictureBox1.Left = 0;  // A léggömböt az ablak bal oldalára visszük
                leggomblepes = 5;
                talalatokszama++;
                label1.Text = "Találat/Lövés: " + talalatokszama.ToString() + "/" + lovesekszama.ToString();//eredmények kiíratása
            }

            if (pictureBox2.Top + pictureBox2.Height <= 0)  // Ha a golyó az ablak tetején kilépett
            {
                pictureBox2.Hide();
                timer2.Stop();
                pictureBox2.Top = y;
                button1.Enabled = true;  // Az új lövés engedélyezése
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox2.Top = y; // A golyó függőleges kiindulási pozíciója 
            pictureBox2.Show();        // A golyó megjelenítése
            timer2.Start();            // A golyó mozgatás indítása    
            button1.Enabled = false;   // A gomb letiltása
            lovesekszama++;
            label1.Text = "Találat/Lövés: " + talalatokszama.ToString() + "/" + lovesekszama.ToString();
        }
    }
}
