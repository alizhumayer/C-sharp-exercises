using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oszthato
{
    public partial class Form1 : Form
    {
        szamok szamok = new szamok();
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
                if (benne(B, item))
                {
                    S_List.Add(item);
                }
            }
            return S_List;
        }
        public List<int> iranyit()
        {
            List<int> S_List = new List<int>();
            if(es.Checked)
            {
                S_List = szamok.get();
                if (chk_list_box.CheckedIndices.Contains(0))
                {
                    S_List = metszet(szamok.oszthato(2),S_List);
                }
                if (chk_list_box.CheckedIndices.Contains(1))
                {
                    
                }
                if (chk_list_box.CheckedIndices.Contains(2))
                {
                    S_List = metszet(szamok.oszthato(3), S_List);
                }
                if (chk_list_box.CheckedIndices.Contains(3))
                {
                    S_List = metszet(szamok.oszthato(5), S_List);
                }
                if (chk_list_box.CheckedIndices.Contains(4))
                {
                    S_List = metszet(szamok.oszthato(7), S_List);
                }
                if (chk_list_box.CheckedIndices.Contains(5))
                {
                    S_List = metszet(szamok.negyzetszam(), S_List);
                }
                if (chk_list_box.CheckedIndices.Contains(6))
                {
                    S_List = metszet(szamok.primek(), S_List);
                }
            }
            else if(vagy.Checked)
            {
                if (chk_list_box.CheckedIndices.Contains(0))
                {
                    S_List = unio(szamok.oszthato(2), S_List);
                }
                if (chk_list_box.CheckedIndices.Contains(1))
                {

                }
                if (chk_list_box.CheckedIndices.Contains(2))
                {
                    S_List = unio(szamok.oszthato(3), S_List);
                }
                if (chk_list_box.CheckedIndices.Contains(3))
                {
                    S_List = unio(szamok.oszthato(5), S_List);
                }
                if (chk_list_box.CheckedIndices.Contains(4))
                {
                    S_List = unio(szamok.oszthato(7), S_List);
                }
                if (chk_list_box.CheckedIndices.Contains(5))
                {
                    S_List = unio(szamok.negyzetszam(), S_List);
                }
                if (chk_list_box.CheckedIndices.Contains(6))
                {
                    S_List = unio(szamok.primek(), S_List);
                }
            }
            return S_List;
        }
        private void general_button_Click(object sender, EventArgs e)
        {
            list_box_gener.Items.Clear();
            szamok.lecserel(feltolt(10));
            feltolt_listbox(szamok.get(), list_box_gener);
        }

        private void mutat_button_Click(object sender, EventArgs e)
        {
            list_box_eredmeny.Items.Clear();
            feltolt_listbox(iranyit(), list_box_eredmeny);
        }
    }
}
