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


namespace beadando_v1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();                 
        }
        public struct adatok
        {
            public string ea_cim;
            public string mufaj;
            public int kiadaseve;
            public int szavazat;
        }
        List<adatok> tablazat = new List<adatok>();
        List<adatok> valogatott = new List<adatok>();

         
        public struct mufajok
        {
            public string kategoriak;
        }
        List<mufajok> katok = new List<mufajok>();

        private void btn_beolvas_Click(object sender, EventArgs e)
        {
            try
            {

            
                if (ofd_olvas.ShowDialog().ToString() == "OK")
                {
                    StreamReader olvas = File.OpenText(ofd_olvas.FileName);
                    string[] darabolt;
                
                    while (!olvas.EndOfStream)
                    {
                        adatok seged;
                        darabolt = olvas.ReadLine().Split(' ');                    
                        seged.ea_cim = darabolt[0];
                        seged.mufaj = darabolt[1];
                        
                        try
                        {
                            try
                            {
                                seged.kiadaseve = int.Parse(darabolt[2]);
                                seged.szavazat = int.Parse(darabolt[3]);
                            }
                            catch (IndexOutOfRangeException)
                            {

                                MessageBox.Show("A bemeneti fájl nem megfelelő (formátumú) értékeket tartalmaz!");
                                throw;
                            }
                            
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("A bemeneti fájl nem megfelelő (formátumú) értékeket tartalmaz!");
                            throw;
                        }

                        tablazat.Add(seged);
                    
                    }
                    mufajok segito;
                    string abc = "";
                    try
                    {
                        segito.kategoriak = tablazat[1].mufaj;
                        katok.Add(segito);
                        abc = segito.kategoriak;
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        MessageBox.Show("A bemeneti fájl nem megfelelő (formátumú) értékeket tartalmaz!");
                    }

                    comboBox1.Items.Add(abc);
                    segito.kategoriak = tablazat[0].mufaj;
                    bool van = false;
                    for (int i = 0; i < tablazat.Count; i++)
                    {
                        van = false;
                        for (int j = 0; j < katok.Count; j++)
                        {                       
                                int comp = string.Compare(tablazat[i].mufaj, katok[j].kategoriak);        
                                if (comp == 0)
                                {
                                    van = true;
                                                                    
                                }
                        }
                        if (van==false)
                        {
                            segito.kategoriak = tablazat[i].mufaj;
                            katok.Add(segito);
                            abc = segito.kategoriak;
                            comboBox1.Items.Add(abc);
                        }
                        
                    }
                    olvas.Close();
                }
                
                comboBox1.Enabled = true;
                btn_kivalogat.Enabled = true;
                comboBox1.SelectedIndex = 0;
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("A bemeneti fájl nemtalálható");               
            }

        }

        private void btn_kivalogat_Click(object sender, EventArgs e)
        {
            string valasztott = comboBox1.SelectedItem.ToString();
            adatok valami;
            bool aze = false;
            string listaba = "";
            listBox1.Items.Clear();
            for (int i = 0; i < tablazat.Count; i++)
            {
                aze = tablazat[i].mufaj.CompareTo(valasztott)==0;
                if (aze==true)
                {
                    valami.ea_cim = tablazat[i].ea_cim;
                    valami.mufaj = tablazat[i].mufaj;
                    valami.kiadaseve = tablazat[i].kiadaseve;
                    valami.szavazat = tablazat[i].szavazat;
                    valogatott.Add(valami);
                                    
                    listaba = valami.ea_cim + " " + valami.mufaj + " " + valami.kiadaseve.ToString() + " " + valami.szavazat.ToString();
                    listBox1.Items.Add(listaba);
                }
            }
            btn_htmlbe.Enabled = true;

        }

        private void btn_htmlbe_Click(object sender, EventArgs e)
        {
            StreamWriter htmlbe = File.CreateText("index.html");
            string fejlec1, fejlec2, htmltag_k, htmltag_v, legszav, legkor;
            
            htmltag_k = "<!DOCTYPE html><html><head><link rel=\"stylesheet\" href=\"alap.css\"><meta http-equiv=\"Content-Type\" content=\"text/html; charset=UTF-8\"><title>Beadandó</title></head><body>";
            htmltag_v = "</body></html>";
            fejlec1 = "<tr id=\"tr1\">	<th>Előadó-Cím</th>	<th>Kiadás éve</th>	</tr>";
            fejlec2 = "<tr id=\"tr1\">	<th>Előadó-Cím</th>	<th>Kiadás éve</th>	<th>Szavazatok</th>	</tr>";

            int legszavi = 0, legkori = 3000;
            //legtöbb savazat
            for (int i = 0; i < valogatott.Count; i++)
            {
                if (valogatott[i].szavazat>legszavi)
                {
                    legszavi = i;
                }
            }
            legszav = valogatott[legszavi].ea_cim;
            //legrégebbi szám
            for (int i = 0; i < valogatott.Count; i++)
            {
                if (valogatott[i].kiadaseve<legkori)
                {
                    legkori = i;
                }
            }
            
            legkor = valogatott[legkori].ea_cim;
            //rendezés
            for (int i = 0; i < valogatott.Count-1; i++)
            {
                int min = i;
                for (int j = i+1; j < valogatott.Count; j++)
                {
                    if (valogatott[j].szavazat<valogatott[min].szavazat)
                    {
                        min = j;
                    }
                }
                adatok seged = valogatott[i];
                valogatott[i] = valogatott[min];
                valogatott[min] = seged;
            }

            //írás kezdet
            htmlbe.WriteLine(htmltag_k);
            htmlbe.WriteLine("<h1>Számok a toplistán</h1>");
            //táblázat 1 k
            htmlbe.WriteLine("<table id=\"table1\">");
            htmlbe.WriteLine(fejlec1);
            for (int i = 0; i < tablazat.Count; i++)
            {
                htmlbe.WriteLine("<tr>	<th>" + tablazat[i].ea_cim + "</th>	<th>" + tablazat[i].kiadaseve + "</th>	</tr>");
            }
            htmlbe.WriteLine("</table>");
            //táblázat 1 v
            htmlbe.WriteLine("<h1>A(z) " + comboBox1.SelectedItem.ToString() + " kategóriába tartózó számok:</h1>");
            htmlbe.WriteLine("<h2>(szavazatok szerint rendezve)</h2>");
            //táblázat 2 k
            htmlbe.WriteLine("<table>");
            htmlbe.WriteLine(fejlec2);
            for (int i = 0; i < valogatott.Count; i++)
            {
                htmlbe.WriteLine("<tr>	<th>" + valogatott[i].ea_cim + "</th>	<th>" + valogatott[i].kiadaseve + "</th>	<th>" + valogatott[i].szavazat + "</th>	</tr>" );
            }

            htmlbe.WriteLine("</table>");
            //táblázat 2 v
            htmlbe.WriteLine("<h3>Legtöbb szavazatot kapott szám:</h3>");
            htmlbe.WriteLine("<p>" + legszav + "</p>");
            htmlbe.WriteLine("<h3>Legrégebbi szám:</h3>");
            htmlbe.WriteLine("<p>" + legkor + "</p>");
            htmlbe.WriteLine(htmltag_v);
            MessageBox.Show("Kész!");
            htmlbe.Close();

            //css
            StreamWriter cssbe = File.CreateText("alap.css");
            cssbe.WriteLine("body{padding:50px;}");
            cssbe.WriteLine("h1{color: #001a4d;font-size: 32px; }");
            cssbe.WriteLine("h2{color: #002266;font-size: 24px; }");
            cssbe.WriteLine("h3{color: #003399;font-size: 19px; margin-left: 50px; }");
            cssbe.WriteLine("p{margin-left:100px;}");
            cssbe.WriteLine("#table1{border: 1px solid gray; margin-left:30px;margin-right:30px;border-collapse: collapse;}");
            cssbe.WriteLine("#tr1{background-color:black; font-size: 300;font-weight:bold; color:white;}");
            cssbe.WriteLine("tr{background-color:white;color:black;border: 1px solid gray;}");
            cssbe.WriteLine("#table1 th{width:200px;border: 1px solid gray;}");
            cssbe.WriteLine("table{margin-left:30px; margin-right:30px;} ");
            cssbe.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
