using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace halmaz
{
    public partial class Form1 : Form
    {
        public List<int> halmaz_A = new List<int>();
        public List<int> halmaz_B = new List<int>();
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        public bool benne(List<int> halmaz, int s)
        {
            int i = 0;
            while (i < halmaz.Count() && halmaz[i] != s)
            {
                i++;
            }
            return i < halmaz.Count();
        }
        public int veletlen_egyedi(List<int> halmaz)
        {
            int seged;
            do
            {
                seged = rnd.Next(1, 100);
            } while (benne(halmaz, seged));
            return seged;
        }
        public List<int> feltolt(int db)
        {
            List<int> S_List = new List<int>();
            for (int i = 0; i < db; i++)
            {
                S_List.Add(veletlen_egyedi(S_List));
            }
            return S_List;
        }
        public void feltolt_listbox(List<int> halmaz, ListBox box)
        {
            if (halmaz.Count > 0)
            {
                foreach (int item in halmaz)
                {
                    box.Items.Add(item.ToString());
                }
            }

        }
        public List<int> unio(List<int> A, List<int> B)
        {
            List<int> S_List = new List<int>();
            foreach (int item in A)
            {
                S_List.Add(item);
            }
            foreach (int item in B)
            {
                if (!benne(S_List, item))
                {
                    S_List.Add(item);
                }
            }
            return S_List;
        }
        public List<int> metszet(List<int> A, List<int> B)
        {
            List<int> S_List = new List<int>();
            foreach (var item in A)
            {
                if(benne(B,item))
                {
                    S_List.Add(item);
                }
            }
            return S_List;
        }
        public List<int> kulonbseg(List<int> A, List<int> B)
        {
            List<int> S_List = new List<int>();
            foreach (var item in A)
            {
                if(!benne(B,item))
                {
                    S_List.Add(item);
                }
            }
            return S_List;
        }
        private void general_button_Click(object sender, EventArgs e)
        {
            halmaz_A = feltolt(Convert.ToInt32(A_db_textbox.Text));
            halmaz_B = feltolt(Convert.ToInt32(B_db_textbox.Text));
            feltolt_listbox(halmaz_A, halmaz_A_listbox);
            feltolt_listbox(halmaz_B, halmaz_B_listbox);
            feltolt_listbox(unio(halmaz_A, halmaz_B), halmaz_unio_listbox);
            feltolt_listbox(metszet(halmaz_A, halmaz_B), halmaz_metszet_listbox);
            feltolt_listbox(kulonbseg(halmaz_A, halmaz_B), halmaz_kul_listbox);
        }
    }
}
