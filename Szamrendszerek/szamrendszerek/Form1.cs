using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace szamrendszerek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Stack<int> verem = new Stack<int>();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_szamol_Click(object sender, EventArgs e)
        {
            string szam = Interaction.InputBox("Add meg a számot!", "Átváltás", "0", 100, 100);
            //elég csak az első
            //MessageBox.Show(szam);
            //if (szam=="")
            //{
            //    MessageBox.Show("Nem írtál be semmit!");
            //}
            //else
            //{
            //    if (rb_10.Checked==true)
            //    {
            //        try
            //        {
            //            int tizszam = Convert.ToInt32(szam);
            //        }
            //        catch (Exception)
            //        {
            //            MessageBox.Show("Ez szerinted 10es számrendszerű szám?????");
            //        }
            //    }
            //    else if ( )
            //    {
            //        MessageBox.Show("Ez szerinted 2es számrendszerű szám?????");
            //    }
            //    else if (rb_16.Checked)
            //    {

            //    }
            //}

            if (szam != "")
            {
                if (rb_10.Checked)
                {
                    int tizszam = 0;
                    bool hiba = false;
                    try
                    {
                        tizszam = Convert.ToInt32(szam);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ez szerinted 10es számrendszerű szám?????");
                        hiba = true;
                    }
                    if (!hiba)
                    {
                        Atalakito(szam, tizszam);
                    }
                }
                else if (rb_2.Checked)
                {
                    int szam2 = 0;
                    bool hiba = false;
                    int i = 0;
                    while (i < szam.Length && (szam[i] == '1' || szam[i] == '0'))
                    {
                        i++;
                    }
                    if (i != szam.Length)
                    {
                        hiba = false;
                    }
                    if (!hiba)
                    {
                        for (int k = 0; k < szam.Length; k++)
                        {
                            if (szam[k] == '1')
                            {
                                szam2 += Convert.ToInt32(Math.Pow(2, szam.Length - k - 1));

                            }
                        }
                        Atalakito(szam2.ToString(), szam2);
                    }
                }


                else if (rb_16.Checked)
                {
                    int szam2 = 0;
                    bool hiba = false;
                    int i = 0;
                    while (i < szam.Length && (szam[i] == '0' || szam[i] == '1' || szam[i] == '2' || szam[i] == '3' || szam[i] == '4' || szam[i] == '5'
                        || szam[i] == '6' || szam[i] == '7' || szam[i] == '8' || szam[i] == '9' || szam[i] == 'A' || szam[i] == 'B' || szam[i] == 'C' || szam[i] == 'D' || szam[i] == 'E' || szam[i] == 'F'))
                    {
                        i++;
                    }
                    if (i != szam.Length)
                    {
                        hiba = false;
                    }
                    if (!hiba)
                    {
                        for (int k = 0; k < szam.Length; k++)
                        {
                            //if (szam[k] >= '0'&& szam[k] <= '9')
                            //{
                            //    szam2 += Convert.ToInt32(szam[k]) * Convert.ToInt32(Math.Pow(2, szam.Length - k - 1));

                            //}
                            switch (szam[k])
                            {
                                case 'A':
                                    szam2 += 10 * Convert.ToInt32(Math.Pow(16, szam.Length - k - 1));
                                    break;
                                case 'B':
                                    szam2 += 11 * Convert.ToInt32(Math.Pow(16, szam.Length - k - 1));
                                    break;
                                case 'C':
                                    szam2 += 12 * Convert.ToInt32(Math.Pow(16, szam.Length - k - 1));
                                    break;
                                case 'D':
                                    szam2 += 13 * Convert.ToInt32(Math.Pow(16, szam.Length - k - 1));
                                    break;
                                case 'E':
                                    szam2 += 14 * Convert.ToInt32(Math.Pow(16, szam.Length - k - 1));
                                    break;
                                case 'F':
                                    szam2 += 15 * Convert.ToInt32(Math.Pow(16, szam.Length - k - 1));
                                    break;

                                default:
                                    szam2 += Convert.ToInt32(szam[k].ToString()) * Convert.ToInt32(Math.Pow(16, szam.Length - k - 1));
                                    break;
                            }
                        }
                        Atalakito(szam2.ToString(), szam2);
                    }
                }
                else
                {
                    MessageBox.Show("Nem írtál be semmit!");
                }

            }
        }
        private int Atalakito(string szam, int tizszam)
        {
            while (tizszam / 2 != 0)
            {
                verem.Push(tizszam % 2);
                tizszam /= 2;
            }
            verem.Push(tizszam % 2);
            l_2.Text = "2:";
            while (verem.Count != 0)
            {
                l_2.Text += verem.Pop().ToString();

            }
            l_10.Text = "10: " + szam;



            tizszam = Convert.ToInt32(szam);
            while (tizszam / 16 != 0)
            {
                verem.Push(tizszam % 16);
                tizszam /= 16;
            }
            verem.Push(tizszam % 16);
            l_16.Text = "16: ";
            while (verem.Count != 0)
            {
                tizszam = verem.Pop();
                switch (tizszam)
                {
                    case 10:
                        l_16.Text += 'A';
                        break;
                    case 11:
                        l_16.Text += 'B';
                        break;
                    case 12:
                        l_16.Text += 'C';
                        break;
                    case 13:
                        l_16.Text += 'D';
                        break;
                    case 14:
                        l_16.Text += 'E';
                        break;
                    case 15:
                        l_16.Text += 'F';
                        break;
                    default:
                        l_16.Text += tizszam;
                        break;
                }

            }

            return tizszam;
        }
    }
}
