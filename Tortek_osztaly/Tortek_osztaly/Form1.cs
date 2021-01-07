using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tortek_osztaly
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Tortek elso, masodik;

        private void btn_bevitel_Click(object sender, EventArgs e)
        {
            tolt();
            btn_szamol.Enabled = true;
        }
        bool elso_jo, masodik_jo;

        private void btn_szamol_Click(object sender, EventArgs e)
        {
            int legkkt = elso.legk_tobbsz(elso, masodik);
            dgv_megj.Rows.Clear();
            dgv_megj.Rows.Add(
                elso.getSzamlalo, elso.getNevezo, elso.tizedes(),
                masodik.getSzamlalo, masodik.getNevezo, masodik.tizedes(),
                elso.osszead(elso.getSzamlalo, masodik.getSzamlalo, legkkt),
                elso.kivon(elso.getSzamlalo, masodik.getSzamlalo, legkkt),
                elso.oszt(elso, masodik),
                elso.szoroz(elso,masodik)
                );
            
        }

        private void tolt()
        {
            elso_jo = false;
            masodik_jo = false;
            if (cb_szaml1.Text == "" || cb_nev1.Text == "")
            {
                elso = new Tortek();
                elso_jo = true;
            }
            else if (szame(cb_szaml1.Text) && szame(cb_nev1.Text))
            {
                elso = new Tortek(int.Parse(cb_szaml1.Text), int.Parse(cb_nev1.Text));
                elso_jo = true;
            }
            if (cb_szaml2.Text == "" || cb_nev2.Text == "")
            {
                masodik = new Tortek();
                masodik_jo = true;
            }
            else if (szame(cb_szaml2.Text) && szame(cb_nev2.Text))
            {
                masodik = new Tortek(int.Parse(cb_szaml2.Text), int.Parse(cb_nev2.Text));
                masodik_jo = true;
            }
            dgv_megj.Rows.Clear();
            if (elso_jo && !masodik_jo)
            {
                dgv_megj.Rows.Add(elso.getSzamlalo, elso.getNevezo);
            }
            else if (masodik_jo && !elso_jo)
            {
                dgv_megj.Rows.Add(masodik.getSzamlalo, masodik.getNevezo);
            }
            else
            {
                dgv_megj.Rows.Add(elso.getSzamlalo, elso.getNevezo,"" , masodik.getSzamlalo, masodik.getNevezo);
            }
            
            
        }
        private bool szame(string text)
        {
            int szam;
            bool jo = false;
            try
            {
                szam = Convert.ToInt32(text);
                jo = true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Pozitív egész számokat kell megadni!", "Valahol rossz értéket adtál meg");
                
            }
            return jo;
        }
    }
}
