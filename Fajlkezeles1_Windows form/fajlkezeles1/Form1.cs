using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fajlkezeles1
{
    public partial class Form1 : Form
    {
        const int MAX = 30;
        int[] szamok = new int[MAX];
        int n;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            n = 0;
            string fnev = "szamok.txt";

            if (File.Exists(fnev))
            {
                StreamReader f = File.OpenText(fnev);
                while ((!f.EndOfStream) && (n < MAX))
                {
                    string sor = f.ReadLine();
                    szamok[n] = int.Parse(sor);

                    if (szamok[n] % 2 == 0)      //% maradékosan osztjuk
                    {
                        listBox1.Items.Add(sor);
                    }
                    else listBox2.Items.Add(sor);
                    n++;
                }
                f.Close();
                button2.Enabled = true;
            }
            else MessageBox.Show("A fájl nem létezik.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fnev2 = "paros.txt";
            string fnev3 = "paratlan.txt";

            StreamWriter f = File.CreateText(fnev2);
            StreamWriter f2 = File.CreateText(fnev3);

            for (int i = 0; i < n; i++)
            {
                if (szamok[i] % 2 == 0)
                {
                    f.WriteLine(szamok[i]);
                }
                else f2.WriteLine(szamok[i]);
            }
            f.Close();
            f2.Close();
            MessageBox.Show("Páros számok kész / kiírva fájlba.");

           /* string fnev3 = "paratlan.txt";
            StreamWriter f2 = File.CreateText(fnev3);
            for (int j = 0; j < n; j++)
            {
                if (szamok[n] % 2 == 1)
                {
                    f2.WriteLine(szamok[j]);
                }
            }
            f2.Close();
            MessageBox.Show("Páratlan számok kész / kiírva fájlba.");*/
        }
    }
}
