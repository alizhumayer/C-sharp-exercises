using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oszthato
{
    class szamok
    {
        List<int> numbers = new List<int>();
        public void hozzaad_egy(int szam)
        {
            numbers.Add(szam);
        }
        public void hozzaad_lista(List<int> L)
        {
            foreach (var item in L)
            {
                numbers.Add(item);
            }
        }
        public void lecserel(List<int> L)
        {
            numbers = new List<int>();
            foreach (var item in L)
            {
                numbers.Add(item);
            }
        }
        public List<int> oszthato(int param)
        {
            List<int> S_List = new List<int>();
            foreach (var item in numbers)
            {
                if(item % param == 0)
                {
                    S_List.Add(item);
                }
            }
            return S_List;
        }
        public List<int> get()
        {
            return numbers;
        }
        private bool prim_e(int szam)
        {
            int i = 2;
            while(i<(szam/2) && szam % i != 0)
            {
                i++;
            }
            return i>=szam/2;
        }
        public List<int> primek()
        {
            List<int> S_List = new List<int>();
            foreach (var item in numbers)
            {
                if(prim_e(item))
                {
                    S_List.Add(item);
                }
            }
            return S_List;
        }
        public List<int> negyzetszam()
        {
            List<int> S_List = new List<int>();
            foreach (var item in numbers)
            {
                if(Math.Pow((int)(Math.Sqrt(item)),2) == item)
                {
                    S_List.Add(item);
                }
            }
            return S_List;
        }

    }
}
