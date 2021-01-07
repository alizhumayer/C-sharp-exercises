using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elso
{
    class adat
    {
        public string nev;
        public int kor;
        public adat()
        {

        }
        public adat(string a, int b)
        {
            nev = a;
            kor = b;
        }
        public int kora(int ev)
        {
            return ev-kor;
        }
    }
}
