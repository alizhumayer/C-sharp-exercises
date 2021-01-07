using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szamologep
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            Queue<string> sor = new Queue<string>();

            //muvelet == "(76+4)*8"
            
            
            string temporalmutant = "";
            for (int i = 0; i < tb_screen.Text.Length; i++)
            {
                if (i < tb_screen.Text.Length - 1)
                {
                    if (tb_screen.Text[i].Equals('-') && tb_screen.Text[i + 1].Equals('-') ||
                        tb_screen.Text[i].Equals('+') && tb_screen.Text[i + 1].Equals('+')
                        )
                    {
                        temporalmutant += '+';
                        i++;
                    }
                    else if ((tb_screen.Text[i].Equals('+') && tb_screen.Text[i + 1].Equals('-')) ||
                            (tb_screen.Text[i].Equals('-') && tb_screen.Text[i + 1].Equals('+'))
                        ) 
                    {
                        temporalmutant += '-';
                        i++;
                    }
                    else
                    {
                        temporalmutant += tb_screen.Text[i];
                    }
                }
                else
                {
                    temporalmutant += tb_screen.Text[i];
                }
                
            }

            //debug
            //MessageBox.Show(temporalmutant);

            string muvelet = temporalmutant;
            string szam = "";

            for (int i = 0; i < muvelet.Length; i++)
            {
                if (muvelet[i] == '-')
                {
                    if (muvelet[i - 1] != '+' &&                        
                        muvelet[i - 1] != '*' &&
                        muvelet[i - 1] != '/' &&
                        muvelet[i - 1] != '^' &&
                        muvelet[i - 1] != '(' &&
                        muvelet[i - 1] != ')'
                        )
                    {
                        sor.Enqueue(muvelet[i].ToString());
                    }
                    else
                    {
                        int tmp = 0;
                        int j = i + 1;
                        while (j < muvelet.Length &&
                            int.TryParse(muvelet[j].ToString(), out tmp))
                        {
                            szam += muvelet[j];
                            j++;
                        }                        
                        szam = Convert.ToString(Convert.ToInt32(szam) * -1);
                        sor.Enqueue(szam);
                        szam = "";
                        i = j - 1;
                    }                    
                }
                else if (
                    muvelet[i] == '+' ||
                    //muvelet[i] == '-' ||
                    muvelet[i] == '*' ||
                    muvelet[i] == '/' ||
                    muvelet[i] == '^' ||
                    muvelet[i] == '(' ||
                    muvelet[i] == ')'
                    )
                {
                    sor.Enqueue(muvelet[i].ToString());
                }
                else
                {
                    int tmp = 0;
                    int j = i;
                    while (j < muvelet.Length &&
                        int.TryParse(muvelet[j].ToString(), out tmp))
                    {
                        szam += muvelet[j];
                        j++;
                    }
                    sor.Enqueue(szam);
                    szam = "";
                    i = j - 1;
                }
            }

            /*
            //kiíratás
            string[] temp = sor.ToArray();
            string tempo = "";
            for (int i = 0; i < temp.Length; i++)
            {
                tempo += temp[i];
            }
            MessageBox.Show(tempo);
            //kiíratás      
            */      

            Stack<string> v = new Stack<string>();
            Queue<string> pof = new Queue<string>();

            while (sor.Count != 0)
            {
                string le = sor.Dequeue();
                if (le[0] >= '0' && le[0] <= '9')
                {
                    pof.Enqueue(le);
                }
                else if (le == "(")
                {
                    v.Push(le);
                }
                else if (le == ")")
                {
                    while (v.Peek() != "(")
                    {
                        pof.Enqueue(v.Pop());
                    }
                    v.Pop();
                }
                else
                {
                    while (v.Count != 0 && Prec(le[0]) <= Prec(v.Peek()[0]))
                    {
                        pof.Enqueue(v.Pop());
                    }
                    v.Push(le);
                }
            }
            while (v.Count != 0)
            {
                pof.Enqueue(v.Pop());
            }


            /*
            //kiíratás
            string temp = "";
            while (pof.Count != 0)
            {
                temp += pof.Dequeue();
            }
            MessageBox.Show(temp);
            //kiíratás
            */

            Stack<double> v2 = new Stack<double>();
            while (pof.Count != 0)
            {
                szam = pof.Dequeue();
                double tmp;
                if (double.TryParse(szam, out tmp))
                {
                    v2.Push(tmp);
                }
                else
                {
                    double x1;
                    double x2;
                    x1 = v2.Pop();
                    x2 = v2.Pop();     
                    
                    double ertek = 0.0;

                    switch (szam[0])
                    {
                        case '+':
                            ertek = x1 + x2;
                            break;
                        case '-':
                            ertek = x2 - x1;
                            break;
                        case '*':
                            ertek = x1 * x2;
                            break;
                        case '/':
                            if (x1==0)
                            {
                                tb_screen.Text = "0-val nem tudok osztani";
                            }
                            else
                            {
                                ertek = x2 / x1;
                            }   
                            break;
                        case '^':
                            ertek = Math.Pow(x2, x1);
                            break;
                    }
                    v2.Push(ertek);
                }
            }
            if (tb_screen.Text == "0-val nem tudok osztani")
            {

            }
            else
            {
                tb_screen.Text += " = " + v2.Pop().ToString();
            }
           

        }

        private int Prec(char p)
        {
            int x = 0;
            switch (p)
            {
                case '(':
                case ')':
                    x = 1;
                    break;
                case '+':
                case '-':
                    x = 2;
                    break;
                case '*':
                case '/':
                    x = 3;
                    break;
                case '^':
                    x = 4;
                    break;
            }
            return x;
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            tb_screen.Text += '0';
            enable();
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            tb_screen.Text += '1';
            enable();
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            tb_screen.Text += '2';
            enable();
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            tb_screen.Text += '3';
            enable();
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            tb_screen.Text += '4';
            enable();
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            tb_screen.Text += '5';
            enable();
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            tb_screen.Text += '6';
            enable();
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            tb_screen.Text += '7';
            enable();
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            tb_screen.Text += '8';
            enable();
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            tb_screen.Text += '9';
            enable();
        }

        private void btn_zo_Click(object sender, EventArgs e)
        {
            tb_screen.Text += '(';
            enable();
        }

        private void btn_zc_Click(object sender, EventArgs e)
        {
            tb_screen.Text += ')';
        }

        private void btn_p_Click(object sender, EventArgs e)
        {
            tb_screen.Text += '+';
        }

        private void btn_m_Click(object sender, EventArgs e)
        {
            tb_screen.Text += '-';
        }

        private void btn_sz_Click(object sender, EventArgs e)
        {
            tb_screen.Text += '*';
        }

        private void btn_osz_Click(object sender, EventArgs e)
        {
            tb_screen.Text += '/';
        }

        private void btn_pow_Click(object sender, EventArgs e)
        {
            tb_screen.Text += '^';
        }


        private void enable()
        {
            btn_zc.Enabled = true;
            btn_p.Enabled = true;
            btn_m.Enabled = true;
            btn_sz.Enabled = true;
            btn_osz.Enabled = true;
            btn_pow.Enabled = true;
            btn_ok.Enabled = true;

        }

        private void btn_ce_Click(object sender, EventArgs e)
        {
            tb_screen.Text = "";
        }

        private void btn_bs_Click(object sender, EventArgs e)
        {
            if (tb_screen.Text!="")
            {
                tb_screen.Text = tb_screen.Text.Remove(tb_screen.Text.Length - 1);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("132754154.gif");
        }
    }
}
