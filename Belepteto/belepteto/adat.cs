using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace belepteto
{
    
    public class adat
    {
        public string name;
        public string password;
        public string vezeteknev;
        public string keresztnev;
        public string becenev;
        public string szuldat;
        public string szigsz;
        public adat(string name, string password, string vezeteknev, string keresztnev, string becenev, string szuldat, string szigsz)
        {
            this.name = name;
            this.password = password;
            this.vezeteknev = vezeteknev;
            this.keresztnev = keresztnev;
            this.becenev = becenev;
            this.szuldat = szuldat;
            this.szigsz = szigsz;
        }
        public adat(adat a)
        {
            this.name = a.name;
            this.password = a.password;
            this.vezeteknev = a.vezeteknev;
            this.keresztnev = a.keresztnev;
            this.becenev = a.becenev;
            this.szuldat = a.szuldat;
            this.szigsz = a.szigsz;
        } 

    }
}
