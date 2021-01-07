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

namespace _13e_11_30
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Stack<int> verem=new Stack<int>();

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_számol_Click(object sender, EventArgs e)
        {
            string szám=Interaction.InputBox("Add meg számot! ","átváltás","101",100,100);
            if (szám!="")
            {
                //10-es-e
                if (rb_10.Checked == true)
                {
                    int szám2 = 0;
                    bool hiba = false;
                    try
                    {
                        szám2 = int.Parse(szám);

                    }
                    catch
                    {
                        MessageBox.Show("Nem 10-es számrendszerbe...");
                        hiba = true;

                    }
                    if (!hiba)
                    {
                        átalakit(szám, szám2);
                    }
                }
                else if (rb_2.Checked)
                {
                    int szám2 = 0;
                    bool hiba = false;
                    int i = 0;
                    while (i < szám.Length && (szám[i] == '1' || szám[i] == '0'))
                    {
                        i++;
                    }
                    if (i != szám.Length)
                    {
                        hiba = true;
                    }
                    if (!hiba)
                    {
                        for (int k = 0; k < szám.Length; k++)
                        {
                            if (szám[k] == '1')
                            {
                                szám2 += Convert.ToInt32(Math.Pow(2, szám.Length - k - 1));
                            }
                        }
                        átalakit(szám2.ToString(), szám2);
                    }
                }
                else if (rb_16.Checked)
                {
                    int szám2 = 0;
                    bool hiba = false;
                    int i = 0;
                    while (i < szám.Length && (szám[i] == '1' || szám[i] == '0'||
                       szám[i] == '2' || szám[i] == '3'|| szám[i] == '4' || szám[i] == '5'
                            ||szám[i] == '6' || szám[i] == '7' || szám[i] == '8' || szám[i] == '9'
                            || szám[i] == 'A' || szám[i] == 'B' || szám[i] == 'C' 
                            || szám[i] == 'D' || szám[i] == 'E' || szám[i] == 'F'))
                    {
                        i++;
                    }
                    if (i != szám.Length)
                    {
                        hiba = true;
                    }
                    if (!hiba)
                    {
                        for (int k = 0; k < szám.Length; k++)
                        {
                            /*if (szám[k] >= '0' && szám[k] <= '9')
                            {
                                szám2 += Convert.ToInt32( szám[k])*Convert.ToInt32(Math.Pow(2, szám.Length - k - 1));
                            }*/
                            switch (szám[k])
                            {
                                case 'A':
                                    szám2 += 10 * Convert.ToInt32(Math.Pow(16, szám.Length - k - 1));
                                    break;
                                case 'B':
                                    szám2 += 11 * Convert.ToInt32(Math.Pow(16, szám.Length - k - 1));
                                    break;
                                case 'C':
                                    szám2 += 12 * Convert.ToInt32(Math.Pow(16, szám.Length - k - 1));
                                    break;
                                case 'D':
                                    szám2 += 13 * Convert.ToInt32(Math.Pow(16, szám.Length - k - 1));
                                    break;
                                case 'E':
                                    szám2 += 14 * Convert.ToInt32(Math.Pow(16, szám.Length - k - 1));
                                    break;
                                case 'F':
                                    szám2 += 15 * Convert.ToInt32(Math.Pow(16, szám.Length - k - 1));
                                    break;

                                default: szám2 += Convert.ToInt32(szám[k].ToString()) * Convert.ToInt32(Math.Pow(16, szám.Length - k - 1));
                                    break;
                            }
                        }
                        átalakit(szám2.ToString(), szám2);
                    }
                }
            }
            else
            {
                MessageBox.Show("nem adtál meg semmit");
            }
        }

        private int átalakit(string szám, int szám2)
        {
            while (szám2 / 2 != 0)
            {
                verem.Push(szám2 % 2);
                szám2 /= 2;
            }
            verem.Push(szám2 % 2);
            lbl_2.Text = "2: ";
            while (verem.Count != 0)
            {
                lbl_2.Text += verem.Pop().ToString();
            }

            lbl_10.Text = "10: " + szám;

            szám2 = int.Parse(szám);
            while (szám2 / 16 != 0)
            {
                verem.Push(szám2 % 16);
                szám2 /= 16;
            }
            verem.Push(szám2 % 16);
            lbl_16.Text = "16: ";
            while (verem.Count != 0)
            {
                //lbl_2.Text += verem.Pop().ToString();

                szám2 = verem.Pop();
                switch (szám2)
                {
                    case 10:
                        lbl_16.Text += 'A';
                        break;
                    case 11:
                        lbl_16.Text += 'B';
                        break;
                    case 12:
                        lbl_16.Text += 'C';
                        break;
                    case 13:
                        lbl_16.Text += 'D';
                        break;
                    case 14:
                        lbl_16.Text += 'E';
                        break;
                    case 15:
                        lbl_16.Text += 'F';
                        break;
                    default:
                        lbl_16.Text += szám2;
                        break;
                }
            }

            return szám2;
        }
    }
}
