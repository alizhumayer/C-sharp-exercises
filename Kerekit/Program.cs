using System;

namespace feladat_kerekit
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Kérem adjon meg egy számot: ");
                var szam = Convert.ToInt32(Console.ReadLine());

                var utolsojegy = szam % 10;
                var kerekites = 0;
                switch (utolsojegy)
                {
                    case 1:
                    case 2:
                        kerekites = -utolsojegy;
                        break;
                    case 3:
                    case 4:
                        kerekites = 5 - utolsojegy;
                        break;
                    case 6:
                    case 7:
                        kerekites = -(utolsojegy - 5);
                        break;
                    case 8:
                    case 9:
                        kerekites = 10 - utolsojegy;
                        break;
                }
                var kerekitett = szam + kerekites;
                Console.WriteLine("A legközelebbi forintokkal kifizethető összeg: {0:C}", kerekitett);

            }
            catch (FormatException)
            {
                Console.WriteLine("Nem jó a bementi szám formátuma");
            }
            Console.ReadKey();
        }
    }
}
