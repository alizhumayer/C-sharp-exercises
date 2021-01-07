using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiftApp
{
    public partial class Form1 : Form
    {
        LoadData BetoltAdat = new LoadData();
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadFromFileBtn_Click(object sender, EventArgs e)
        {
                       
            
         //gombnyomásra beolvasunk egy file-t.
            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            betoltdialog.InitialDirectory = mydocpath;
            betoltdialog.Filter = "XLS files (*.xls)|*.xls|XLSX files (*.xlsx)|*.xlsx|CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            //openFileDialog1.FilterIndex = 3;
            betoltdialog.FileName = "adatok.csv";
            if (betoltdialog.ShowDialog() == DialogResult.OK)
            {
                string aktfile = betoltdialog.FileName;
                if (File.Exists(aktfile))
                {
                    BetoltAdat.AdatBeolvas(aktfile);
                    foreach (SearchStruct item in BetoltAdat.AdatLista)
                    {
                        LoadedDataLb.Items.Add("Név: " + item.Name);
                        LoadedDataLb.Items.Add("Kért ajándék: " + item.Gift);
                        LoadedDataLb.Items.Add("Kért ajándék ára: " + item.Price);
                    }
                }
            }
        }

        //private void SaveBtn_Click(object sender, EventArgs e)
        /*{
            if (Csvradio.Checked)
            {
                MessageBox.Show("A file CSV kiterjesztésként mentve!");
            }
            else if (TxtRadio.Checked)
            {
                MessageBox.Show("a File TXT kiterjesztésként mentve!");

            }
        }*/

        private void AddToLbBtn_Click(object sender, EventArgs e)
        {
            //AddedDataLb.Items.Add(DataAddTb.Text);
            if (!String.IsNullOrEmpty(DataAddTb.Text))
            {
                //AddedDataLb.Items.Add(DataAddTb.Text);
                BetoltAdat.SearchNameMethod(DataAddTb.Text, AddedDataLb);
            }
            else
            {
                MessageBox.Show("Üres a TextBox!");
            }
        }
    }
}
