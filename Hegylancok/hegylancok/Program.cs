using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace hegylancok
{
    
    class Hegylanc
    {       
        public byte[] terep = new byte[81];
        static string hexasor = "";

        public void general()
        {
            
            int magas_gener;
            byte magassag;
            Random vs = new Random();
                  
            for (int i = 0; i <= 80; i++)
            {
                if (i < 3 || i > 77) 
                {
                    terep[i] = 0;
                }
                else
                {
                    magas_gener = vs.Next(0, 16);
                    if (magas_gener%2==0)
                    {
                        magas_gener = 0;
                    }                  
                    magassag = Convert.ToByte(magas_gener);
                    terep[i] = magassag;
                }          
            }
        }



        public void Hexa()
        {
            string hexa_ki = "";
            for (int i = 0; i < terep.Length; i++)
            {
                    switch (terep[i])
                    {
                        case 10:
                            hexa_ki += "A";
                            break;
                        case 11:
                            hexa_ki += "B";
                            break;
                        case 12:
                            hexa_ki += "C";
                            break;
                        case 13:
                            hexa_ki += "D";
                            break;
                        case 14:
                            hexa_ki += "E";
                            break;
                        case 15:
                            hexa_ki += "F";
                            break;
                    default:
                            hexa_ki += terep[i];
                            break;
                    }            
            }
            Console.WriteLine("4.Feladat: \n{0}", hexa_ki);
            hexasor += hexa_ki;            
        }

    
        public void Hegyek()
        {
            int hegyek_szama = 0;
            for (int i = 0; i <= terep.Length-3; i++)
            {
                if (terep[i] == 0 && terep[i+2]==0 && terep[i+1] != 0)
                {
                    hegyek_szama++;
                }               
            }
            Console.WriteLine("5.Feladat: \n A hegyek száma: {0} db", hegyek_szama);
        }

        public void HegyekSzinezve()
        {
            Console.WriteLine("6.Feladat(normál): Hegyek kék színnel:");
            for (int i = 1; i <= terep.Length - 2; i++)
            {
                if (terep[i-1] == 0 && terep[i + 1] == 0 && terep[i] != 0)
                {
                    //hiba
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(terep[i]);
                }
                else
                {
                    Console.ResetColor();
                    Console.Write(terep[i]);
                }
            }
        }
        public void HexaSzinezve()
        {
            Console.WriteLine("\n6.Feladat(hexa): Hegyek kék színnel:");

            for (int i = 1; i <= hexasor.Length - 2; i++)
            {
                if (hexasor[i - 1] == '0' && hexasor[i + 1] == '0' && hexasor[i] != '0')
                {

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(hexasor[i]);
                }
                else
                {
                    Console.ResetColor();
                    Console.Write(hexasor[i]);
                }
            }
        }


        public void Hegylancok()
        {
            //nem kész 7-es feladat
            int hegylancok_szama = 0;
            int top_hossz = 0;
            int now_hossz = 0;
            int now_szam = 0;
            int top_szam = 0;
            double atlag;


            for (int i = 1; i <= terep.Length - 1; i++)
            {
                if (terep[i-1] == 0 && terep[i] != 0 && terep[i + 1] != 0)
                {
                    hegylancok_szama++;                    
                }              
            }

            for (int i = 1; i < terep.Length-1; i++)
            {
                if (terep[i-1]==0 && terep[i] != 0 && terep[i+1] != 0) //első
                {
                    now_hossz = 1;
                    now_szam += Convert.ToInt32(terep[i]);
                    
                }
                else if (terep[i-0] != 0 && terep[i] != 0 && terep[i+1] != 0) //belső
                {
                    now_hossz++;
                    now_szam += Convert.ToInt32(terep[i]);
                }
                else if (terep[i-1] != 0 && terep[i] != 0 && terep[i+1] == 0) //külső
                {
                    now_hossz++;
                    now_szam += Convert.ToInt32(terep[i]);
                    if (now_hossz > top_hossz)
                    {
                        top_hossz = now_hossz;
                        top_szam = now_szam;
                    }                
                    now_hossz = 0;
                    now_szam = 0;        
                }
                
            }
            atlag = top_szam / top_hossz;
            Console.WriteLine("\n7. Feladat: \nHegyláncok száma: {0} db \nLeghosszabb hegylánc hossza: {1} karakter \nAz átlagos magassága: {2:0.00}",hegylancok_szama,top_hossz,atlag);
            
        }

        public void Eredeti()
        {

            Console.WriteLine("\nEredeti adatsor ('|' elválasztással):");
            for (int i = 0; i < 80; i++)
            {
                Console.Write(terep[i] + "|");
            }

        }
        public void Kiir()
        {
            StreamWriter kiiro = File.CreateText("hegylancok.txt");
            kiiro.WriteLine(hexasor);
            kiiro.Close();        
            Console.WriteLine("\n\nhegylancok.txt mentve!");
        }


    }

    class Program
    {
        static void Main(string[] args)
        {

            Hegylanc meresek = new Hegylanc();
            meresek.general();
            meresek.Hexa();
            meresek.Hegyek();
            //meresek.HegyekSzinezve();
            meresek.HexaSzinezve();
            meresek.Hegylancok();
            //meresek.Eredeti();
            meresek.Kiir();
            Console.ReadKey();

        }
    }
}
