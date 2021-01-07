using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_inf_17maj
{
    class Fuggvenyek
    {
        #region Struktúrák, definiálások
        internal struct TESZT
        {
            public string szaz;
            public String valaszok;
        }

        internal struct PONTSZAMOK
        {
            public String szaz;
            public int pont;
        }
        #endregion

        #region Függvények
        internal static void Feltoltes(out List<TESZT> tvalaszok, out String helyesvalasz, String fileName)
        {
            List<TESZT> valaszok = new List<TESZT>();
            String[] strin = File.ReadAllLines(fileName);
            helyesvalasz = strin[0];
            for (int i = 1; i < strin.Length; i++)
            {
                if (strin[i].Length > 0)
                {
                    TESZT item = new TESZT();
                    item.szaz = strin[i].Split(' ')[0];
                    item.valaszok = strin[i].Split(' ')[1];
                    valaszok.Add(item);
                }
            }
            tvalaszok = valaszok;
        }

        internal static void Kiiras(List<TESZT> tvalaszok)
        {
            for (int i = 0; i < tvalaszok.Count; i++)
            {
                Console.WriteLine("{0} {1}", tvalaszok[i].szaz, Convert.ToString(tvalaszok[i].valaszok));
            }
        }

        internal static String val_hely(String valaszok, String helyes)
        {
            String str = "";
            for (int i = 0; i < valaszok.Length; i++)
            {
                if (valaszok[i] == helyes[i])
                    str += "+";
                else str += " ";
            }
            return str;
        }

        internal static String ver_valaszok(List<TESZT> lst, String szaz)
        {
            String str = "";
            for (int i = 0; i < lst.Count; i++)
                if (lst[i].szaz == szaz) return lst[i].valaszok.ToString();
            return null;
        }

        internal static int helyesfo(List<TESZT> vek, string helyes, int sorsz)
        {
            int db = 0;
            for (int i = 0; i < vek.Count; i++)
            {
                if (vek[i].valaszok[sorsz - 1] == helyes[sorsz - 1]) db++;
            }
            return db;
        }

        internal static int val_hely_sulyozott(String valaszok, String helyes)
        {
            int pontsz = 0;
            for (int i = 0; i < valaszok.Length; i++)
            {
                if (valaszok[i] == helyes[i])
                {
                    switch (i + 1)
                    {
                        case 1:
                        case 2:
                        case 3:
                        case 4:
                        case 5:
                            pontsz += 3;
                            break;
                        case 6:
                        case 7:
                        case 8:
                        case 9:
                        case 10:
                            pontsz += 4;
                            break;
                        case 11:
                        case 12:
                        case 13:
                            pontsz += 5;
                            break;
                        case 14:
                            pontsz += 6;
                            break;
                    }
                }
            }
            return pontsz;
        }

        internal static List<String> Kiirat(List<PONTSZAMOK> lst)
        {
            List<String> outstr = new List<string>();

            for (int i = 0; i < lst.Count; i++)
            {
                outstr.Add(lst[i].szaz + " " + lst[i].pont);
            }

            return outstr;
        }
        #endregion

    }
}
