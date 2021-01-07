using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace belepteto
{
    public partial class Form1 : Form
    {
        DBConnect kapcsolat = new DBConnect();
        public Form1()
        {
            InitializeComponent();
        }

        private void belep_btn_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(kapcsolat.Select_pw(textBox1.Text)+" "+ sha256_hash(textBox2.Text));

            if (!kapcsolat.Select_pw(textBox1.Text).Equals("warning") && sha256_hash(textBox2.Text).Equals(kapcsolat.Select_pw(textBox1.Text)))
            {
                MessageBox.Show("Siker!");
                reg reg = new reg(kapcsolat.Select_id(textBox1.Text));
                reg.ShowDialog();
                reg.Activate();
                //Form1.ActiveForm.Close();
                textBox1.Text = "";
                textBox2.Text = "";
            }
            else
            {
                MessageBox.Show("Nem sikeres!");
            }
        }

        private void reg_btn_Click(object sender, EventArgs e)
        {
            if(kapcsolat.Count_nev(textBox1.Text)>0)
            {
                MessageBox.Show("Ilyen felhasználónév már van");
            }
            else if(kapcsolat.Count_nev(textBox1.Text) == 0)
            {
                kapcsolat.Insert(textBox1.Text, sha256_hash(textBox2.Text));
                MessageBox.Show("Regisztráció sikerült!");
                textBox1.Text = "";
                textBox2.Text = "";
            }
            else
            {
                MessageBox.Show("Kapcsolati hiba!");
            }
        }
        public static String sha256_hash(String value)
        {
            StringBuilder Sb = new StringBuilder();

            using (SHA256 hash = SHA256Managed.Create())
            {
                Encoding enc = Encoding.UTF8;
                Byte[] result = hash.ComputeHash(enc.GetBytes(value));

                foreach (Byte b in result)
                    Sb.Append(b.ToString("x2"));
            }

            return Sb.ToString();
        }

    }
}
