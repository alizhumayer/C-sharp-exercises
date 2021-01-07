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

namespace MagyarOldalak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        public bool letezik(string file)
        {
            bool vane = false;
            if (File.Exists(file))
            {
                vane = true;
            }
            return vane;
        }
        private void feluliras(string oname)
        {
            StreamWriter felulir = File.CreateText(oname);
            int i = 0;
            while (i < cb_link.Items.Count)
            {
                felulir.WriteLine(cb_link.Items[i]);
                i++;
            }
            felulir.Close();
        }
        private void mogeiras(string oname)
        {
            StreamWriter mogeir = new StreamWriter(oname, true);
            int i = 0;
            while (i < cb_link.Items.Count)
            {
                mogeir.WriteLine(cb_link.Items[i]);
                i++;
            }
            mogeir.Close();
        }
        private bool bennevan(string data)
        {
            bool bennev = false;
            for (int i = 0; i < cb_link.Items.Count - 1; i++)
            {
                if (cb_link.Items[i].ToString().Equals(data))
                {
                    bennev = true;
                }
                else if (cb_link.Items[i].ToString().Equals(data.Substring(4)))
                {
                    bennev = true;
                }
            }
            return bennev;
        }

        private void tolt()
        {
            if (cb_link.Text.Contains(".hu"))
            {
                if (cb_link.Text.Contains("google") || cb_link.Text.Contains("bing") || cb_link.Text.Contains("yahoo") || cb_link.Text.Contains("ask.com"))
                {
                    MessageBox.Show("Ez az oldal sajnos nem látogatható!");
                }
                else
                {
                    if (!this.bennevan(cb_link.Text))
                    {
                        cb_link.Items.Add(cb_link.Text);
                    }
                    webBrowser1.Navigate(cb_link.Text);
                }
            }
            else
            {
                MessageBox.Show("Csak .hu domainek látogathatóak!");
            }

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            tolt();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cb_link.Items.Add("www.index.hu");
            cb_link.Items.Add("www.sg.hu");
            cb_ie.Items.Add("Abc sorrend");
            cb_ie.Items.Add("Import");
            cb_ie.Items.Add("Export");
            

            cb_ie.SelectedIndex = 0;
        }

        private void btn_kj_Click(object sender, EventArgs e)
        {
            if (cb_ie.SelectedIndex==1)
            {
                try
                {
                    if (ofd_import.ShowDialog().ToString() == "OK")
                    {
                        StreamReader import = File.OpenText(ofd_import.FileName);
                        string sor;
                        while (!import.EndOfStream)
                        {
                            sor = import.ReadLine();
                            if (!this.bennevan(sor))
                            {
                                cb_link.Items.Add(sor);
                            }
                           
                        }
                        import.Close();
                    }
                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show("Nemtalálható bemeneti fájl!");
                    throw;
                }
            }
            else if(cb_ie.SelectedIndex == 2)
            {
                string now = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString();
                string outname = "bookmark" + now + ".txt";
                if (!this.letezik(outname))
                {
                    this.feluliras(outname);
                    MessageBox.Show("Kész!");
                }
                else
                {
                    
                    DialogResult valasz = MessageBox.Show("A fájl már létezik, felül akarod írni?", "Felülírás", MessageBoxButtons.YesNo);
                    if (valasz == DialogResult.Yes)
                    {
                        this.feluliras(outname);
                        MessageBox.Show("Kész!");
                    }
                    else
                    {
                        DialogResult valasz2 = MessageBox.Show("Folytassuk a már lézető fájlt?", "Mögéírás", MessageBoxButtons.YesNo);
                        if (valasz2 == DialogResult.Yes)
                        {
                            this.mogeiras(outname);
                            MessageBox.Show("Kész!");
                        }
                        else
                        {
                            if (sfd_export.ShowDialog().ToString() == "OK") 
                            {      
                                this.feluliras(sfd_export.FileName);
                                MessageBox.Show("Kész!");
                            }    
                        }
                    }
                }
                
            }
            else if (cb_ie.SelectedIndex == 0)
            {
                cb_link.Sorted = true;
                cb_link.Sorted = false;
            }

        }

        private void cb_link_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                tolt();
            }
        }
    }
}
