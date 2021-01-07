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

namespace Reg2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            alapAllapot();
        }
        private void alapAllapot()
        {
            label3.Visible = false;
            label4.Visible = false;
            tb_passWord2.Visible = false;
            tb_pwEmlek.Visible = false;
            string filename = "database.txt";
            firstProgramStart(filename);

            label5.Visible = true;
            label6.Visible = false;
            tb_remUser.Visible = true;
            tb_remText.Visible = false;

            btn_regLap.Text = "Regisztráció";

            tb_userName.Text = "";
            tb_passWord.Text = "";
            tb_passWord2.Text = "";
            tb_pwEmlek.Text = "";

            tb_remUser.Text = "";
            tb_remText.Text = "";

        }
        bool regLapOn = false;
        private void btn_enter_Click(object sender, EventArgs e)
        {
            StreamReader olvas = File.OpenText("database.txt");
            string felhNev, passW;
            felhNev = tb_userName.Text;
            passW = tb_passWord.Text;
            passW = coding(passW);
            bool megvan = false;
            string[] darabolt;
           
            while (!olvas.EndOfStream)
            {
                darabolt = olvas.ReadLine().Split(' ');
                if (darabolt[0] == felhNev && darabolt[1] == passW)
                {
                    megvan = true;
                }
            }
            olvas.Close();
            if (!megvan)
            {
                MessageBox.Show("Nem található fiók ilyen Felhasználó név/Jelszó párosítással");
            }
            else
            {
                MessageBox.Show("Sikeres Belépés!");
                alapAllapot();
            }

        }

        private void btn_regLap_Click(object sender, EventArgs e)
        {
            if(!regLapOn)
            {
                label3.Visible = true;
                label4.Visible = true;
                tb_passWord2.Visible = true;
                tb_pwEmlek.Visible = true;
                btn_regLap.Text = "Regisztrálok";
                regLapOn = true;
                tb_userName.Text = "";
                tb_passWord.Text = "";
            }
            else
            {
                if ( tb_userName.Text=="" || tb_passWord.Text=="" || tb_passWord2.Text=="" || tb_pwEmlek.Text=="")
                {
                    MessageBox.Show("Minden mezőt ki kell töltened!");
                }
                else
                {
                    if (tb_passWord.Text.CompareTo(tb_passWord2.Text) != 0)
                    {
                        MessageBox.Show("A 2 jelszónak azonosnak kell lennie!");
                    }
                    else
                    {
                        if (tb_passWord.Text.CompareTo(tb_pwEmlek.Text) == 0)
                        {
                            MessageBox.Show("A jelszó és az emlékeztető nem lehet azonos!");
                        }
                        else
                        {
                            string felhNev, passW, reminder;
                            bool elerheto = true;
                            string[] darabolt;
                            StreamReader checker = File.OpenText("database.txt");
                            felhNev = tb_userName.Text;
                            passW = tb_passWord.Text;
                            reminder = tb_pwEmlek.Text;
                            while (!checker.EndOfStream)
                            {
                                darabolt = checker.ReadLine().Split(' ');
                                if (darabolt[0] == felhNev)
                                {
                                    elerheto = false;
                                    MessageBox.Show("A felhasználónév már foglalt!");
                                }
                            }
                            checker.Close();
                            if (elerheto)
                            {
                                StreamWriter ment = new StreamWriter("database.txt", true);
                                passW = coding(passW);
                                ment.WriteLine(felhNev + " " + passW + " " + reminder);
                                ment.Close();
                                MessageBox.Show("Sikeres regisztráció!");

                                alapAllapot();
                                regLapOn = false;

                            }
                        }

                       

                    }




                }






            }
        }

        private void firstProgramStart(string filename)
        {         
            if (File.Exists(filename) != true)
            {
                StreamWriter dbFile = File.CreateText("database.txt");
                dbFile.Close();
            }
        }

        private void btn_pwHelp_Click(object sender, EventArgs e)
        {
            StreamReader checker = File.OpenText("database.txt");
            string[] darabolt;
            bool van = false;
            string keresettNev;
            string emlekezteto = "";
            keresettNev = tb_remUser.Text;
            while (!checker.EndOfStream)
            {
                darabolt = checker.ReadLine().Split(' ');
                if (darabolt[0] == keresettNev)
                {
                    van = true;
                    emlekezteto = darabolt[2];                  
                }
            }
            if (!van)
            {
                MessageBox.Show("Nem található ilyen felhasználó!");
            }
            else
            {
                label6.Visible = true;
                tb_remText.Visible = true;
                tb_remText.Text = emlekezteto.ToString();
            }


        }

        private void tb_remUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_pwHelp.PerformClick();
            }
        }

        private void tb_userName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tb_userName.Text != "" && tb_passWord.Text != "")
                {
                    btn_enter.PerformClick();
                }
            }
            
        }

        private void tb_passWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tb_userName.Text != "" && tb_passWord.Text != "")
                {
                    btn_enter.PerformClick();
                }
            }

            
        }
        public string coding(string kod)
        {
            byte[] coded = Encoding.ASCII.GetBytes(kod);
            string ki = "";
            for (int i = 0; i < coded.Length; i++)
            {
                ki += coded[i] + ".";
            }

            return ki;
        }
       

    }
    
}
