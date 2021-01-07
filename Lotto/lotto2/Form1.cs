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

namespace lotto2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_feltoltes_Click(object sender, EventArgs e)
        {
            if (be.ShowDialog().ToString() == "OK")
            {
                StreamReader olvas = File.OpenText(be.FileName);
                string[] darabolt;
                int conv_darabolt = 0;
                darabolt = olvas.ReadLine().Split('\t');
                double s = 0;
                for (int i = 0; i < darabolt.Length; i++)
                {
                    conv_darabolt = Convert.ToInt32(darabolt[4]);
                    if (conv_darabolt > s) 
                    {
                        s = conv_darabolt;
                    }
                }
                label1.Text = Convert.ToString(s);
                Close();
            }



        }
    }
}
