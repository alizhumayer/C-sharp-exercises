using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adatb
{
    public partial class Form1 : Form
    {
        DBConnect kapcsolat;
        public Form1()
        {
            InitializeComponent();
            kapcsolat = new DBConnect();
        }

        private void Run_Click(object sender, EventArgs e)
        {
            L_box_tolt(kapcsolat.Select());
        }
        public void L_box_tolt(List<string>[] a)
        {
            String seged;
            for (int i = 0; i < a[0].Count; i++)
            {
                seged = "";
                for(int j=0;j<a.Length;j++)
                {
                    seged += a[j][i] + " ";
                }
                Eredmeny_box.Items.Add(seged);
            }
        }

        private void Insert_btn_Click(object sender, EventArgs e)
        {
            int a = kapcsolat.Select()[0].Count() + 1;
            MessageBox.Show(a.ToString());
            kapcsolat.Insert(a.ToString(), textBox1.Text);
        }
    }
}
