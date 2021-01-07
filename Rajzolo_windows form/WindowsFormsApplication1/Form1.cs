using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Graphics g;
        Pen toll = new Pen(Color.Tomato, 10);
        List<Point> pontok = new List<Point>();

        Bitmap b = new Bitmap(800, 600);

        private void Form1_Load(object sender, EventArgs e)
        {
            g = pictureBox1.CreateGraphics();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog().ToString() == "OK")
            {                
                StreamReader f = File.OpenText(openFileDialog1.FileName);

                toll.Width = (float)Convert.ToDouble(f.ReadLine());

                int sR = Convert.ToInt32(f.ReadLine());
                int sB = Convert.ToInt32(f.ReadLine());
                int sG = Convert.ToInt32(f.ReadLine());
                toll.Color = Color.FromArgb(255, sR, sB, sG);

                while (!f.EndOfStream)
                {
                    int sX = Convert.ToInt32(f.ReadLine());
                    int sY = Convert.ToInt32(f.ReadLine());
                    Point sP = new Point(sX, sY);
                    pontok.Add(sP);
                }
                f.Close();

                MessageBox.Show("Beolvasás kész!");
                int n = pontok.Count;
                MessageBox.Show("Beolvasott pontok száma: " + n);

                b = new Bitmap(800, 600);
                Graphics mem = Graphics.FromImage(b);

                Point[] pnt = new Point[2];
                for (int i = 0; i < 2; i++)
                {
                    pnt[i] = pontok[i];
                }
                g.DrawPolygon(toll, pnt);
                mem.DrawPolygon(toll, pnt);

                //250,0 300,300
                g.DrawEllipse(toll, pontok[2].X, pontok[2].Y, pontok[3].X, pontok[3].Y);
                g.DrawEllipse(toll, pontok[2].X - (pontok[3].X / 2 - Convert.ToInt32(pontok[3].X * 0.05)), pontok[2].Y + (pontok[3].Y / 4 - Convert.ToInt32(pontok[3].Y * 0.2)), pontok[3].X / 2, pontok[3].Y / 2);
                g.DrawEllipse(toll, pontok[2].X - (pontok[3].X / 2 - Convert.ToInt32(pontok[3].X * 0.05)), pontok[2].Y + (pontok[3].Y / 4 + Convert.ToInt32(pontok[3].Y * 0.2)), pontok[3].X / 2, pontok[3].Y / 2);
                g.DrawEllipse(toll, pontok[2].X + (pontok[3].X - Convert.ToInt32(pontok[3].X * 0.05)), pontok[2].Y + (pontok[3].Y / 4 - Convert.ToInt32(pontok[3].Y * 0.2)), pontok[3].X / 2, pontok[3].Y / 2);
                g.DrawEllipse(toll, pontok[2].X + (pontok[3].X - Convert.ToInt32(pontok[3].X * 0.05)), pontok[2].Y + (pontok[3].Y / 4 + Convert.ToInt32(pontok[3].Y * 0.2)), pontok[3].X / 2, pontok[3].Y / 2);

                mem.DrawEllipse(toll, pontok[2].X, pontok[2].Y, pontok[3].X, pontok[3].Y);
                mem.DrawEllipse(toll, pontok[2].X - (pontok[3].X / 2 - Convert.ToInt32(pontok[3].X * 0.05)), pontok[2].Y + (pontok[3].Y / 4 - Convert.ToInt32(pontok[3].Y * 0.2)), pontok[3].X / 2, pontok[3].Y / 2);
                mem.DrawEllipse(toll, pontok[2].X - (pontok[3].X / 2 - Convert.ToInt32(pontok[3].X * 0.05)), pontok[2].Y + (pontok[3].Y / 4 + Convert.ToInt32(pontok[3].Y * 0.2)), pontok[3].X / 2, pontok[3].Y / 2);
                mem.DrawEllipse(toll, pontok[2].X + (pontok[3].X - Convert.ToInt32(pontok[3].X * 0.05)), pontok[2].Y + (pontok[3].Y / 4 - Convert.ToInt32(pontok[3].Y * 0.2)), pontok[3].X / 2, pontok[3].Y / 2);
                mem.DrawEllipse(toll, pontok[2].X + (pontok[3].X - Convert.ToInt32(pontok[3].X * 0.05)), pontok[2].Y + (pontok[3].Y / 4 + Convert.ToInt32(pontok[3].Y * 0.2)), pontok[3].X / 2, pontok[3].Y / 2);




                kor(275, 325, pontok[3].Y / 2);
                kor(275 + 250, 325, pontok[3].Y / 2);

                korB(275, 325, pontok[3].Y / 2, mem);
                korB(275 + 250, 325, pontok[3].Y / 2, mem);

                b.Save("virag.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
                b.Dispose();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            g.Clear(Color.Black);
            pontok.Clear();
        }

        private void kor(int x, int y, int d) {
            g.DrawEllipse(toll, x - d / 2, y -d / 2, d , d);            
        }

        private void korB(int x, int y, int d, Graphics mem)
        {
            mem.DrawEllipse(toll, x - d / 2, y - d / 2, d, d);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog().ToString() == "OK")
            {
                pictureBox1.Image = Image.FromFile(openFileDialog2.FileName);
                b = new Bitmap(800, 600);
                Graphics mem = Graphics.FromImage(b);
                Point t = new Point(0,0);
                mem.DrawImage(Image.FromFile(openFileDialog2.FileName), t);
            }
        }
    }
}
