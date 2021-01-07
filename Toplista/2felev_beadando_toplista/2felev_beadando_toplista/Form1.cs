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

namespace _2felev_beadando_toplista
{
    public partial class Form1_toplista : Form
    {
        public Form1_toplista()
        {
            InitializeComponent();
        }

        public struct zene
        {
            public string eloado_szamcim;
            public string stilus;
            public int ev;
            public int szavazat;
        }
        List<zene> teljes_lista = new List<zene>();
        List<zene> valogatott_lista = new List<zene>();

        public struct zenei_stilus
        {
            public string zenei_stilusok;
        }
        List<zenei_stilus> zenei_stilus_lista = new List<zenei_stilus>();

        private void button1_betoltes_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog().ToString()== "OK")
                {
                    StreamReader f = File.OpenText(openFileDialog1.FileName);
                    
                
                    while (!f.EndOfStream)
                    {
                            string[] darabolt = f.ReadLine().Split(' ');
                            zene seged;
                        try
                        {
                            seged.eloado_szamcim = darabolt[0];
                            seged.stilus = darabolt[1];
                            seged.ev = int.Parse(darabolt[2]);
                            seged.szavazat = int.Parse(darabolt[3]);
                            teljes_lista.Add(seged);
                        }
                        catch (IndexOutOfRangeException)
                        {
                            MessageBox.Show("A fájlban lévő adatok nem megfelelő formátumban vannak megadva!");
                            
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("A fájlban lévő adatok nem megfelelő formátumban vannak megadva!");
                            
                        }
                        
                    }

                    zenei_stilus s_stilus;
                    string stil = "";
                    /*
                    int db = 0;
                    for (int i = 1; i < teljes_lista.Count; i++)
                    {
                        if (valogatott_lista[i].stilus != teljes_lista[i].stilus)
                        {
                            s_stilus.zenei_stilusok = teljes_lista[i].stilus;
                            zenei_stilus_lista.Add(s_stilus);
                            stil = s_stilus.zenei_stilusok;
                            comboBox1_stilus.Items.Add(stil);
                            i++;
                        }
                    }*/
                    
                    s_stilus.zenei_stilusok = teljes_lista[1].stilus;
                    zenei_stilus_lista.Add(s_stilus);
                    stil = s_stilus.zenei_stilusok;


                    

                    comboBox1_stilus.Items.Add(stil);
                    s_stilus.zenei_stilusok = teljes_lista[0].stilus;
                    

                    bool van = false;
                    for (int i = 0; i < teljes_lista.Count; i++)
                    {
                        van = false;
                        for (int j = 0; j < valogatott_lista.Count; j++)
                        {
                            
                                int hasonlit = string.Compare(teljes_lista[i].stilus, valogatott_lista[j].stilus);
                                if (hasonlit == 0)
                                {
                                    van = true;
                                }
                            
                        }
                        if (van == false)
                        {
                            s_stilus.zenei_stilusok = teljes_lista[i].stilus;
                            zenei_stilus_lista.Add(s_stilus);
                            stil = s_stilus.zenei_stilusok;
                            comboBox1_stilus.Items.Add(stil);
                            
                        }
                    }   
                    f.Close();
                }
                comboBox1_stilus.Enabled = true;
                button1_valasztas.Enabled = true;
                comboBox1_stilus.SelectedIndex = 0;
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("A Zeneszámok fájl nem található!");
                throw;
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Nem választott ki fájlt!");
                
            }
        }

        private void button1_valasztas_Click(object sender, EventArgs e)
        {
            listBox1_lista.Items.Clear();
            string kivalasztott = comboBox1_stilus.SelectedItem.ToString();
            string listaba = "";
            zene s;
            bool stilus_e = false;
            for (int i = 0; i < teljes_lista.Count; i++)
            {
                stilus_e = teljes_lista[i].stilus.CompareTo(kivalasztott) == 0;
                if (stilus_e == true)
                {
                    s.eloado_szamcim = teljes_lista[i].eloado_szamcim;
                    s.stilus = teljes_lista[i].stilus;
                    s.ev = teljes_lista[i].ev;
                    s.szavazat = teljes_lista[i].szavazat;
                    valogatott_lista.Add(s);
                    listaba = s.eloado_szamcim + " " + s.stilus + " " + s.ev + " " + s.szavazat.ToString();
                    listBox1_lista.Items.Add(listaba);

                }
            }
            button1_html.Enabled = true;
        }

        private void button1_html_Click(object sender, EventArgs e)
        {
            StreamWriter f = File.CreateText("index.html");
            int legtobb_szavazat = 0;
            int szavazat_s = 0;
            for (int i = 0; i < valogatott_lista.Count; i++)
            {
                if (valogatott_lista[i].szavazat > legtobb_szavazat)
                {
                legtobb_szavazat = valogatott_lista[i].szavazat;
                szavazat_s = i;

                }
            }
            string legtobb_szav = valogatott_lista[szavazat_s].eloado_szamcim;

            int legregebbi = 2000;
            int legregebbi_s = 0;
            for (int i = 0; i < valogatott_lista.Count; i++)
            {
                if (valogatott_lista[i].ev < legregebbi)
                {
                    legregebbi = valogatott_lista[i].ev;
                    legregebbi_s = i;
                }
            }
            string legreg = valogatott_lista[legregebbi_s].eloado_szamcim;

            for (int i = 0; i < valogatott_lista.Count - 1; i++)
            {
                int min = i;
                for (int j = i+1; j < valogatott_lista.Count; j++)
                {
                    if (valogatott_lista[j].szavazat < valogatott_lista[min].szavazat)
                    {
                        min = j;
                    }

                }
                zene s = valogatott_lista[i];
                valogatott_lista[i] = valogatott_lista[min];
                valogatott_lista[min] = s;
            }

            f.WriteLine("<!DOCTYPE html><html><head><link rel=\"stylesheet\" href=\"alap.css\"><meta http-equiv=\"Content-Type\" content=\"text/html; charset=UTF-8\"><title>Toplista</title></head><body>");
            f.WriteLine("<h1>Számok a toplistán</h1>");
            f.WriteLine("<table id=\"table1\">");
            f.WriteLine("<tr id=\"tr1\">	<th>Előadó-Cím</th>	<th>Kiadás éve</th>	</tr>");
            for (int i= 0; i < teljes_lista.Count; i++)
            {
                f.WriteLine("<tr>	<th>" + teljes_lista[i].eloado_szamcim + "</th>	<th>" + teljes_lista[i].ev + "</th>	</tr>");
            }
            f.WriteLine("</table>");
            f.WriteLine("<h1>A(z) " + comboBox1_stilus.SelectedItem.ToString() + " kategóriába tartozó számok:</h1>");
            f.WriteLine("<h2>(szavazatok szerint rendezve)</h2>");
            f.WriteLine("<table>");
            f.WriteLine("<tr id=\"tr1\">	<th>Előadó-Cím</th>	<th>Kiadás éve</th>	<th>Szavazatok</th>	</tr>");
            for (int i = 0; i < valogatott_lista.Count; i++)
            {
                f.WriteLine("<tr>	<th>" + valogatott_lista[i].eloado_szamcim + "</th>	<th>" + valogatott_lista[i].ev + "</th>	<th>" + valogatott_lista[i].szavazat + "</th>	</tr>");
            }
            f.WriteLine("</table>");
            f.WriteLine("<h3>Legtöbb szavazatot kapott szám:</h3>");
            f.WriteLine("<p>" + legtobb_szav + "</p>");
            f.WriteLine("<h3>Legrégebbi szám:</h3>");
            f.WriteLine("<p>" + legreg + "</p>");
            f.WriteLine("</body></html>");
            MessageBox.Show("A HTML állomány kiírásra került.");
            f.Close();
        }
    }
}
