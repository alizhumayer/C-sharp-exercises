using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13_e_10_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random r = new Random();
            nm_elso.Value = r.Next(0, 256);
            nm_harmadik.Value = r.Next(0, 256);
            nm_masodik.Value = r.Next(0, 256);
            nm_negyedik.Value = r.Next(0, 256);
            nm_mask.Value = r.Next(1, 31);
            DGV.RowCount = 4;
            DGV.ColumnCount = 4;
        }

        static string kettesre(int szám)
        {
            string s = "";
            while (szám!=0)
            {
                s = (szám % 2).ToString() + s;
                szám /= 2;
            }
            while (s.Length!=8)
            {
                s = "0" + s;
            }
            return s;
        }

        static int tizesre(string s)
        {
            int szám = 0;
            for (int i = 0; i < 8; i++)
            {
                if (s[i] == '1')
                {
                    szám += (int)Math.Pow(2, 7 - i);
                }
            }
            return szám;
        }

        private void btn_számol_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(kettesre((int)nm_elso.Value));
            string ip = kettesre((int)nm_elso.Value) + kettesre((int)nm_masodik.Value)
                + kettesre((int)nm_harmadik.Value) + kettesre((int)nm_negyedik.Value);

            string na = "";
            for (int i = 0; i < nm_mask.Value; i++)
            {
                na += ip[i];
            }
            while (na.Length != 32)
            {
                na += '0';
            }
            lbl_na.Text = "Na: " + tizesre(na.Substring(0,8)).ToString()+"."
                + tizesre(na.Substring(8, 8)).ToString() + "."
                + tizesre(na.Substring(16, 8)).ToString() + "."
                + tizesre(na.Substring(24, 8)).ToString();

            DGV.Rows[0].Cells[0].Value = tizesre(na.Substring(0, 8));
            DGV.Rows[0].Cells[1].Value = tizesre(na.Substring(8, 8));
            DGV.Rows[0].Cells[2].Value = tizesre(na.Substring(16, 8));
            DGV.Rows[0].Cells[3].Value = tizesre(na.Substring(24, 8));

            lbl_first.Text="First: " + tizesre(na.Substring(0, 8)).ToString() + "."
                + tizesre(na.Substring(8, 8)).ToString() + "."
                + tizesre(na.Substring(16, 8)).ToString() + "."
                + (tizesre(na.Substring(24, 8))+1).ToString();
            string bc = "";
            for (int i = 0; i < nm_mask.Value; i++)
            {
                bc += ip[i];
            }
            while (bc.Length != 32)
            {
                bc += '1';
            }
            lbl_bc.Text = "BC: " + tizesre(bc.Substring(0, 8)).ToString() + "."
                + tizesre(bc.Substring(8, 8)).ToString() + "."
                + tizesre(bc.Substring(16, 8)).ToString() + "."
                + tizesre(bc.Substring(24, 8)).ToString();

            lbl_last.Text="Last: "+ tizesre(bc.Substring(0, 8)).ToString() + "."
                + tizesre(bc.Substring(8, 8)).ToString() + "."
                + tizesre(bc.Substring(16, 8)).ToString() + "."
                + (tizesre(bc.Substring(24, 8))-1).ToString();
        }
    }
}
