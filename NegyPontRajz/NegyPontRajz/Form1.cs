using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NegyPontRajz
{
    public partial class Form1 : Form
    {
        Graphics vaszon;

        Pen toll = new Pen(Color.Black, 3);
        int r = 0, g = 0, b = 0;
        Point[] pontok = new Point[4];
        Point[] rajzpontok = new Point[4];
        int p_db = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            vaszon = pb_vaszon.CreateGraphics();

            label5.Text = "Tollvastagság: " + hScrollBar1.Value.ToString();
            toll.Color = Color.FromArgb(255, r, g, b);
            l_nowcolor.BackColor = toll.Color;
            l_r.Text = vScrollBar1.Value.ToString();
            l_g.Text = vScrollBar2.Value.ToString();
            l_b.Text = vScrollBar3.Value.ToString();
            vaszon.Clear(Color.White);

        }

        private void btn_szin_Click(object sender, EventArgs e)
        {
            if (szin_valaszt.ShowDialog() == DialogResult.OK)
            {
                toll.Color = szin_valaszt.Color;
                vScrollBar1.Value = toll.Color.R;
                vScrollBar2.Value = toll.Color.G;
                vScrollBar3.Value = toll.Color.B;
                l_nowcolor.BackColor = toll.Color;

            }
        }

        
        private void hScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            toll.Width = hScrollBar1.Value;
            label5.Text = "Tollvastagság: " + hScrollBar1.Value.ToString();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            vaszon.Clear(Color.White);
        }

        private void pb_vaszon_MouseDown(object sender, MouseEventArgs e)
        {
            if (p_db==0)
            {
                pontok[p_db].X = e.X;
                pontok[p_db].Y = e.Y;
                p_db++;
            }
            else if (p_db==1)
            {
                pontok[p_db].X = e.X;
                pontok[p_db].Y = e.Y;
                p_db++;
            }
            else if (p_db==2)
            {
                pontok[p_db].X = e.X;
                pontok[p_db].Y = e.Y;
                p_db++;
            }
            else if (p_db==3)
            {
                pontok[p_db].X = e.X;
                pontok[p_db].Y = e.Y;
                p_db++;
            }          
        }

        private void pb_vaszon_MouseUp(object sender, MouseEventArgs e)
        {
            if (p_db==6)
            {
                double[] ponthossz = new double[4];
                double[,] ponth_i = new double[3,4];
                Point[] pontok_rajz = new Point[4];
               
                var minX = pontok[0].X;
                var maxX = pontok[0].X;
                var minY = pontok[0].Y;
                var maxY = pontok[0].Y;

                for (var i = 1; i < pontok.Length; i++)
                {
                    if (pontok[i].X < minX) minX = pontok[i].X;
                    if (pontok[i].X > maxX) maxX = pontok[i].X;
                    if (pontok[i].Y < minY) minY = pontok[i].Y;
                    if (pontok[i].Y > maxY) maxY = pontok[i].Y;
                }

                Point center = new Point();
                center.X = minX + (maxX - minX) / 2;
                center.Y = minY + (maxY - minY) / 2;

                for (var i = 0; i < pontok.Length; i++)
                {
                    ponthossz[i] = Math.Acos((pontok[i].X - center.X) / vonalhossz(center, pontok[i]));

                    if (pontok[i].Y > center.Y)
                    {
                        ponthossz[i] = Math.PI + Math.PI - ponthossz[i];
                    }
                }
                for (int i = 0; i < ponthossz.Length; i++)
                {
                    ponth_i[i,0] = pontok[i].X;
                    ponth_i[i, 1] = pontok[i].Y;
                    ponth_i[i, 2] = ponthossz[i];
                }


                for (int i = 0; i < ponth_i.Length; i++)
                {
                    for (int j = 0; j < ponth_i.Length-i; j++)
                    {
                        if (ponth_i[j, 3] < ponth_i[j + 1, 3])
                        {
                            double temp1 = ponth_i[j, 0];
                            double temp2 = ponth_i[j, 1];
                            double temp3 = ponth_i[j, 2];

                            ponth_i[j, 0] = ponth_i[j + 1, 0];
                            ponth_i[j, 1] = ponth_i[j + 1, 1];
                            ponth_i[j, 2] = ponth_i[j + 1, 2];

                            ponth_i[j + 1, 0] = temp1;
                            ponth_i[j + 1, 1] = temp2;
                            ponth_i[j + 1, 2] = temp3;
                        }
                    }
                }
                for (int i = 0; i < ponth_i.Length; i++)
                {
                    rajzpontok[i].X = (int)ponth_i[i,0];
                    rajzpontok[i].Y = (int)ponth_i[i, 1];
                }
                

                vaszon.DrawPolygon(toll, rajzpontok);
                p_db = 0;
            }
        }
       


        private void vScrollBar1_ValueChanged(object sender, EventArgs e)
        {

            l_r.Text = vScrollBar1.Value.ToString();
            r = (int)vScrollBar1.Value;
            g = (int)vScrollBar2.Value;
            b = (int)vScrollBar3.Value;
            toll.Color = Color.FromArgb(255, r, g, b);
            l_nowcolor.BackColor = toll.Color;
        }

        private void vScrollBar2_ValueChanged(object sender, EventArgs e)
        {
            l_g.Text = vScrollBar2.Value.ToString();
            r = (int)vScrollBar1.Value;
            g = (int)vScrollBar2.Value;
            b = (int)vScrollBar3.Value;
            toll.Color = Color.FromArgb(255, r, g, b);
            l_nowcolor.BackColor = toll.Color;
        }

        private void vScrollBar3_ValueChanged(object sender, EventArgs e)
        {
            l_b.Text = vScrollBar3.Value.ToString();
            r = (int)vScrollBar1.Value;
            g = (int)vScrollBar2.Value;
            b = (int)vScrollBar3.Value;
            toll.Color = Color.FromArgb(255, r, g, b);
            l_nowcolor.BackColor = toll.Color;
        }
        private double vonalhossz(Point p1, Point p2)
        {
            var xs = 0;
            xs = p2.X - p1.X;
            xs = xs * xs;

            var ys = 0;
            ys = p2.Y - p1.Y;
            ys = ys * ys;

            return Math.Sqrt(xs + ys);

        }




    }
}
