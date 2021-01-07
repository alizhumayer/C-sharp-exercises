using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace belepteto
{
    public partial class reg : Form
    {
        DBConnect kapcs = new DBConnect();
        private int userid;
        public reg(int id)
        {
            InitializeComponent();
            userid = id;
            adat seged = new adat(kapcs.Select_id(id));
            name_reg.Text = seged.name;
            vezeteknev_reg.Text = seged.vezeteknev;
            keresztnev_reg.Text = seged.keresztnev;
            becenev_reg.Text = seged.becenev;
            if(seged.szuldat.Equals(""))
            {
                szul_reg.Value = DateTime.Now;
            }
            else
            {
                MessageBox.Show(seged.szuldat.Substring(0, 13));
                szul_reg.Value = new DateTime(int.Parse(seged.szuldat.Substring(0, 4)), int.Parse(seged.szuldat.Substring(6, 2)), int.Parse(seged.szuldat.Substring(10, 2)));
            }
            szigsz_reg.Text = seged.szigsz;
        }

        private void mentes_btn_Click(object sender, EventArgs e)
        {
            if(kapcs.Count_nev_id(name_reg.Text,userid.ToString())==0)
            {
                kapcs.Update(name_reg.Text, vezeteknev_reg.Text, keresztnev_reg.Text, becenev_reg.Text, szul_reg.Value.Year + "-" + szul_reg.Value.Month + "-" + szul_reg.Value.Day, szigsz_reg.Text, userid.ToString());
            }
        }

        private void zar_btn_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Activate();
            reg.ActiveForm.Close();            
        }
    }
}
