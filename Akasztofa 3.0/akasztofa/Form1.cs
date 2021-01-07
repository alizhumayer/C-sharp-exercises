using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace akasztofa
{
    public partial class Form1 : Form
    {
        Button[] Buttons = new Button[60];
        int x, y, i, darab;
        string kitalálandó, közbülső = "", seged = "";
        char tipp;
        int tippekszama = 0;
        int hibapont = 0;
        int db;
        Random n = new Random();

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            switch (hibapont)
            {
                case 1:
                    g.DrawLine(toll, 600, 100, 600, 500);
                    break;
                case 2:
                    g.DrawLine(toll, 600, 100, 750, 100);
                    break;
                case 3:
                    g.DrawLine(toll, 750, 100, 750, 150);
                    break;
                case 4:
                    {
                        g.DrawEllipse(toll, 730, 150, 40, 40);
                    }
                    break;
                case 5:
                    g.DrawLine(toll, 750, 190, 750, 300);
                    break;
                case 6:
                    g.DrawLine(toll, 700, 200, 750, 200);
                    break;
                case 7:
                    g.DrawLine(toll, 750, 200, 800, 200);
                    break;
                case 8:
                    g.DrawLine(toll, 700, 400, 750, 300);
                    break;
                case 9:
                    g.DrawLine(toll, 750, 300, 800, 400);
                    break;
            }
        }

        Pen toll = new Pen(Color.Red, 1);
        void ellenoriz()
        {
            tippekszama++;
            seged = "";
            for (int i = 0; i < kitalálandó.Length; i++)
            {
                if (tipp == kitalálandó[i]) { seged += tipp; }
                else { seged += közbülső[i]; }
            }
            if (közbülső == seged) hibapont++;

            közbülső = seged;
            hibaszam.Text = Convert.ToString(hibapont);
            feladvany.Text = közbülső;
            if ((kitalálandó == közbülső) && (hibapont < 9))
            {
                feladvany.Text = "";
                uzenet.Text = "Gratulálok nyert! A megoldás:" + kitalálandó;
            }
            if (hibapont >= 9)
            {
                uzenet.Text = "vesztett! a megoldás:" + kitalálandó;


            }

        }
        string[] fajlbol = File.ReadAllLines("magyarszavak.txt");
        public Form1()
        {
            InitializeComponent();
        }
        protected void MyButton_click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            tipp = Convert.ToChar(b.Text.ToLower());
            b.Visible = false;
            ellenoriz();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string abc = "AÁBCDEÉFGHIÍJKLMNOÓÖŐPQRSTUÚÜŰVWXYZ";
            Button[] Gombok = new Button[35];
            for (int i = 0; i < 35; i++)
            {
                Gombok[i] = new Button();
                Gombok[i].Text = abc[i].ToString();
                y = 200 + (i / 12) * 60;
                Gombok[i].Width = 40;
                Gombok[i].Height = 40;
                Gombok[i].Tag = i;
                x = 5 + (i % 12) * 40;
                Gombok[i].Location = new Point(x, y);
                Gombok[i].Click += new EventHandler(MyButton_click);
                Controls.Add(Gombok[i]);

            }
            Invalidate();
            darab = fajlbol.Count();
            db = n.Next(0, darab);
            hibapont = 0;
            közbülső = "";
            tipp = ' ';
            kitalálandó = fajlbol[db];
            // kitalálandó = "alma";
            közbülső = közbülső.PadRight(kitalálandó.Length, '*');
            feladvany.Text = közbülső;
            uzenet.Text = "";
            hibaszam.Text = "";
        }
    }
}
