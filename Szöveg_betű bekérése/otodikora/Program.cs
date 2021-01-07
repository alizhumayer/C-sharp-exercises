using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otodikora
{
    class Program
    {
        static void Main(string[] args)
        {

            // lecke:

            string sz = "";
            Console.WriteLine("Kérem a szövegét");
            sz = Console.ReadLine();
            /*
                        // minden 2. karaktert kiír
                        //1. mego 
                        int i = 0;
                        for (i = 1; i < sz.Length; i+=2)
                        {
                            Console.Write(sz[i]);
                        }

                        //2.mego
                        Console.WriteLine();
                        Console.WriteLine();

                        for (i = 0; i < sz.Length; i++)
                        {
                            if (i % 2 != 0)
                            {

                                Console.Write(sz[i]);
                            }
                        }

                        //minden 5.
                        Console.WriteLine();
                        Console.WriteLine();


                        for (i = 4; i < sz.Length; i += 5)
                        {
                            Console.Write(sz[i]);
                        }
                        //minden 5. 2
                        Console.WriteLine();
                        Console.WriteLine();


                        for (i = 0; i < sz.Length; i++)
                        {
                            if ((i+1)%5==0)
                            {
                                Console.Write(sz[i]);
                            }

                        }


                        //hátulról az utosló 5
                        Console.WriteLine();
                        Console.WriteLine();


                        for ( i = sz.Length-5; i < sz.Length; i++)
                        {
                                   Console.Write(sz[i]);
                        }

                        // fordított sorrend
                        Console.WriteLine();
                        Console.WriteLine();


                        for ( i = sz.Length -1; i >=0; i--)
                        {
                            Console.Write(sz[i]);
                        }


                        //szavak betűit fordított sorrendben
                        Console.WriteLine();
                        Console.WriteLine();


                        for (i = sz.Length - 1; i >= 0; i--)
                        {
                            if(sz[i] != ' ')
                            {
                                Console.Write(sz[i]);
                            }
                
                        }
                        // -||- 2.
                        Console.WriteLine();
                        Console.WriteLine();


                        string szo = Console.ReadLine();
                        string ford = "";
                        int j = 0, ind = 0;
                        {
                            if (szo[i] == ' ')
                            {
                                for (j = i - 1; j >= ind; j-- )
                                {
                                    ford += szo[i];
                                }
                                ford += ' ';
                                ind = i + 1;
                            }
                            else if (i == szo.Length -1)
                            {
                                for (j = i; j >= ind; j-- )
                                {
                                    ford += szo[j];
                                }

                            }
                            i++;
                        }
                        Console.WriteLine(ford);
                        // van e 't'
                        Console.WriteLine();
                        Console.WriteLine();



                        bool b1 = false;
                        for (i = 0; i < sz.Length;i++ )
                        {

                            if(sz[i] == 't')
                            {
                                b1 = true;
                            }

                            if (b1 == false)
                            {
                                Console.WriteLine("Nincs");

                            }
                            else
                            {
                                Console.WriteLine("Van");
                            }
                        }

                        //
                        Console.WriteLine();
                        Console.WriteLine();
                        //eldöntés tétellel 
                        bool van = false;
                        while(i<sz.Length && sz[i] != 't')
                        {
                            i++;
                        }
                        van = i < sz.Length;
                        Console.WriteLine(van);


                        //van e 'fa' 
                        Console.WriteLine();
                        Console.WriteLine();
            
                       // i-1 és i vizsgálata

                       // int i = 1;
                        // bool van = false;
                        while (i < sz.Length && (sz[i-1] != 'f' && sz[i] != 'a'))
                        {
                            i++;
                        }
                        van = i < sz.Length;
                        Console.WriteLine(van);






                    }
             */
            // magánhangzók száma

            //string mh = "aáeéiíoóuúüű";
            //int db = 0;
            //for (int i = 0; i < sz.Length; i++)
            //    {
            //     for (int j = 0; j < mh.Length; j++)
            //    {
            //     if (sz[i] == mh[j])
            //    }

            //         db++;
            //    }
            //    Console.WriteLine("{}",db);


            //mh2

            //char[] mh = new char[] { 'a','á' };


            //int db = 0;
            //for (int i = 0; i < sz.Length; i++)
            //{
            //    for (int j = 0; j < mh.Length; j++)
            //    {
            //        if (sz[i] == mh[j])
            //        {

            //            db++;
            //        }
            //    }

            //}
            //Console.WriteLine("{0}", db);


            //Console.ReadKey();


            /* hf : be: 2es szamrendszerű számot átvált 10-esbe 
             
             több féle képpen, 1 esével tömb
             
             
             
             
             
             */

            





            Console.ReadKey();
             
        }
    }
}

