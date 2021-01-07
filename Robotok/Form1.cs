using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Robotos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Random r = new Random();
            StreamReader sr = new StreamReader("mozgas.txt");
            List<Robot> robotok = new List<Robot>();
            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine();
                // A "this" magára a Form1 ablakra vonatkozik
                int x = r.Next(10, this.ClientSize.Width - 10);
                int y = r.Next(25, this.ClientSize.Height - 20);
                // Graphics graphics = new Graphics() -----> kell paraméter!!!!;
                Graphics graphics = this.CreateGraphics();
                Color color = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
                foreach (char c in sor)
                {
                    int ex = x;
                    int ey = y;
                    switch (c)
                    {
                        case 'E':
                            y -= 5;
                            break;
                        case 'D':
                            y += 5;
                            break;
                        case 'N':
                            x -= 5;
                            break;
                        case 'K':
                            x += 5;
                            break;
                        default:
                            MessageBox.Show("Nem megfelelő adat!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            break;
                    }
                    graphics.DrawLine(new Pen(color), x, y, ex, ey);
                    Robot robot = new Robot(sor.ToCharArray(), this.CreateGraphics());
                    robotok.Add(robot);
                    // robot.Mozog();
                    Thread szal = new Thread(robot.Mozog);
                    szal.Start();
                }
                while (robotok.Count > 0)
                {
                    this.Text = "" + robotok.Count;
                    int i = 0;
                    List<int> robot_sorszam = new List<int>();
                    foreach (Robot robot in robotok)
                    {
                        if (robot.Status == "Kesz")
                        {
                            robotok.Remove(robot);
                        }
                        i++;
                    }
                    foreach (int sorszam in robot_sorszam)
                    {
                        robotok.RemoveAt(sorszam);
                    }
                }
                Application.Exit();
            }
        }
    }
}

/*
 Egy grafikus felületen, minden egyes sor beolvasása előtt előállítunk egy véletlenszerű x-y koordináta párt és a beolvasott sort értelmezve mindig az aktuális pozíciótól a kivánt irányba húzunk egy 5-10 px hosszúságú egyenest a betűk alapján.
*/
