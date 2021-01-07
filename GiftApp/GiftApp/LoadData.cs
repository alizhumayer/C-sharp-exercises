using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiftApp
{
    class LoadData
    {
        public List<SearchStruct> AdatLista = new List<SearchStruct>();
        public void AdatBeolvas(string Param)
        {
            StreamReader Sr = new StreamReader(Param);
            while (!Sr.EndOfStream)
            {
                SearchStruct Sorok = new SearchStruct();
                string Nev= Sr.ReadLine();
                string  Ajandek= Sr.ReadLine();
                int Ar = Int32.Parse(Sr.ReadLine());
                Sorok.Name = Nev;
                Sorok.Gift = Ajandek;
                Sorok.Price = Ar;
                AdatLista.Add(Sorok);
            }
        }

        public void SearchNameMethod(string NameParam, ListBox DataAddedLb)
        {
            bool Talalt = false;
            
            foreach (SearchStruct item in AdatLista)
            {
                if (item.Name.Equals(NameParam))
                {
                    DataAddedLb.Items.Add("Az ajándékot kérő gyerek neve: " + NameParam);
                    DataAddedLb.Items.Add("A kért ajándék: " + item.Gift);
                    Talalt = true;
                }
            }
            if (Talalt == false)
            {
                DataAddedLb.Items.Add("A keresett értékre nincs találat!");
            }

        }
    }
}
