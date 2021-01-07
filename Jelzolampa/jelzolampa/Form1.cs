using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jelzolampa
{
    public partial class Form1 : Form
    {
        public int allapot = 1;
        public Form1()
        {
            InitializeComponent();

            l_zold.Visible=true;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (allapot==1)
            //{
            //    l_zold.BackColor = Color.White;
            //    l_sarga.BackColor = Color.Yellow;
            //    allapot = 2;
            //}
            //else if(allapot==2)
            //{
            //    l_sarga.BackColor = Color.White;
            //    l_piros.BackColor = Color.Red;                
            //    allapot = 3;
            //}
            //else if(allapot==3)
            //{
            //    l_piros.BackColor = Color.Red;
            //    l_sarga.BackColor = Color.Yellow;
            //    allapot = 4;                
            //}
            //else if(allapot==4)
            //{
            //    l_sarga.BackColor = Color.White;
            //    l_piros.BackColor = Color.White;
            //    l_zold.BackColor = Color.Green;
            //    allapot = 1;
            //}

            if (allapot == 1)
            {
                l_zold.Visible = false;
                l_sarga.Visible = true;
                allapot = 2;

            }
            else if (allapot == 2)
            {
                l_sarga.Visible = false;
                l_piros.Visible = true;                
                allapot = 3;
            }
            else if (allapot == 3)
            {
                l_piros.Visible = true;
                l_sarga.Visible = true;
                allapot = 4;
            }
            else if(allapot==4)
            {
                l_sarga.Visible = false;
                l_piros.Visible = false;
                l_zold.Visible = true;
                allapot = 1;
            }
        }
    }
}
