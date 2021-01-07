using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace harom_halmaz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_rajz_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.Clear(Color.CornflowerBlue);
            Pen p = new Pen(Color.Black, 2);
            g.DrawEllipse(p, 1, 1, 298, 298);
            g.DrawEllipse(p, 200, 1, 298, 298);
            g.DrawEllipse(p, 100, 150, 298, 298);
            int maxA = (int)num_A.Value;
            int maxB = (int)num_B.Value;
            int maxC = (int)num_B.Value;
            Random R = new Random();
            Halmaz<int> A = new Halmaz<int>();
            int x;
            for (int i = 1; i <= maxA; i++)
            {
                do
                {
                    x = R.Next(1, 41);
                } while (A.ElemeE(x));
                A += new Halmaz<int>(x);
            }
            Halmaz<int> B = new Halmaz<int>();
            for (int i = 1; i <= maxB; i++)
            {
                do
                {
                    x = R.Next(1, 21);
                } while (B.ElemeE(x));
                B += new Halmaz<int>(x);
            }
            Halmaz<int> C = new Halmaz<int>();
            for (int i = 1; i <= maxC; i++)
            {
                do
                {
                    x = R.Next(1, 21);
                } while (C.ElemeE(x));
                C += new Halmaz<int>(x);
            }
            l_A.Text = "A = " + A.Kiir();
            l_B.Text = "B = " + B.Kiir();
            l_C.Text = "C = " + C.Kiir();
            Halmaz<int> AminuszBC = A - B - C;
            Halmaz<int> BminuszAC = B - A - C;
            Halmaz<int> CminuszAB = C - B - A;
            Halmaz<int> AmetszetB = A * B;
            Halmaz<int> BmetszetC = B * C;
            Halmaz<int> AmetszetC = A * C;
            Halmaz<int> AmetszetBC = A * B * C;

            SolidBrush br = new SolidBrush(Color.Black);
            g.DrawString(AminuszBC.Kiir(), l_A.Font, br, 13, 150);
            g.DrawString(AmetszetB.Kiir(), l_A.Font, br, 213, 100);
            g.DrawString(BminuszAC.Kiir(), l_A.Font, br, 323, 150);
            g.DrawString(CminuszAB.Kiir(), l_A.Font, br, 213, 350);
            g.DrawString(AmetszetC.Kiir(), l_A.Font, br, 130, 240);
            g.DrawString(BmetszetC.Kiir(), l_A.Font, br, 313, 250);
            g.DrawString(AmetszetBC.Kiir(), l_A.Font, br, 230, 200);
            pictureBox1.Image = bmp;

        }
    }
}
