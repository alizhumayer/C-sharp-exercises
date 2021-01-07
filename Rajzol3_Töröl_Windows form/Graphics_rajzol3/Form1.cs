using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphics_rajzol3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Graphics graf,graf2;
        Pen toll = new Pen(Color.Black);
        Point pont,pont2;

        private void Form1_Load(object sender, EventArgs e)
        {
            graf = pictureBox1.CreateGraphics();
            graf2 = pictureBox2.CreateGraphics();
        }

        private void btn_szinez_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                toll.Color = colorDialog1.Color;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            pont = new Point(e.X, e.Y);
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Bitmap copy = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
            Graphics gd = Graphics.FromImage(copy);
            if (e.Button == MouseButtons.Left)
            {
                graf.DrawLine(toll, pont.X, pont.Y, e.X, e.Y);
                //graf2.DrawLine(toll, pont.X, pont.Y, e.X, e.Y);
                gd.DrawLine(toll, pont.X, pont.Y, e.X, e.Y);    
                pont.X = e.X;
                pont.Y = e.Y;
            }
            pictureBox2.Image = copy;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_torol_Click(object sender, EventArgs e)
        {
            graf.Clear(Color.Gray);
        }

        private void btn_torol2_Click(object sender, EventArgs e)
        {
            graf2.Clear(Color.Gray);
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            MessageBox.Show(pont.ToString());
            //Bitmap copy = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
            //Graphics g;       
            //Rectangle rec = pictureBox1.Bounds;
            //pictureBox1.DrawToBitmap(copy, rec);
            //Bitmap copy2 = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
            //for (int i = 100; i < 200; i++)
            //{
            //    for (int j = 100; j < 200; j++)
            //    {
            //        Color color = copy.GetPixel(i, j);
            //        copy2.SetPixel(i, j, color);
            //    }
            //}
            //pictureBox2.Image = copy2;

        }  
            
        

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            pont2 = new Point(e.X, e.Y);
        }
    }
}
