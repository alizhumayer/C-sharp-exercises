using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using belepteto; //hozzáadni a DBConnect projektnevét

namespace _4felev_1207
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DBConnect kapcs = new DBConnect();

        private void button_hozzaad_Click(object sender, EventArgs e)
        {
            kapcs.Insert(Convert.ToString(numericUpDown_azonosito.Value), 
                        textBox_nev.Text, 
                        Convert.ToString(numericUpDown_szulev.Value), 
                        Convert.ToString(numericUpDown_irszam.Value), 
                        textBox_orszag.Text);
            listBox1.Items.Clear();
            L_box_tolt(kapcs.Select());
        }

        private void button_adatlekero_Click(object sender, EventArgs e)
        {
            L_box_tolt(kapcs.Select());
        }

        public void L_box_tolt(List<string>[] a)
        {
            String seged;
            for (int i = 0; i < a[0].Count; i++)
            {
                seged = "";
                for (int j = 0; j < a.Length; j++)
                {
                    seged += a[j][i] + "|";
                }
                listBox1.Items.Add(seged);
            }
        }

        private void button_torol_Click(object sender, EventArgs e)
        {
            string seged = listBox1.GetItemText(listBox1.SelectedItem);
            string[] darabolt = seged.Split('|');
            kapcs.Delete(darabolt[1]);
            listBox1.Items.Clear();
            L_box_tolt(kapcs.Select());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_befizet_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            //dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            //MessageBox.Show(dateTimePicker1.Value.Year.ToString()+"-"+ dateTimePicker1.Value.Month.ToString()+"-"+ dateTimePicker1.Value.Day.ToString());
            kapcs.Insert(Convert.ToString(numericUpDown_azon.Value),
                        Convert.ToString(dateTimePicker1.Value.Year.ToString() + "-" + dateTimePicker1.Value.Month.ToString() + "-" + dateTimePicker1.Value.Day.ToString()),
                        Convert.ToString(numericUpDown_osszeg.Value));                        ;
        }

        private void listBox1_Click(object sender, EventArgs e)
        {

            string[] temp = listBox1.SelectedItem.ToString().Split('|');
            numericUpDown_azon.Value = Convert.ToInt32(temp[0]);

        }
    }
}
