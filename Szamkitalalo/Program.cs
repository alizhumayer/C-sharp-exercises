using System;

namespace feladat_szamkitalalo
{
    class Program
    {
        static void Main(string[] args)
        {
            int also = 0;
            int felso = 0;
            try
            {
                Console.WriteLine("Szám kitaláló Program");
                Console.WriteLine();
                Console.Write("A gondolt szám alsó intevalluma: ");
                also = Convert.ToInt32(Console.ReadLine());
                Console.Write("A gondolt szám felső intevalluma: ");
                felso = Convert.ToInt32(Console.ReadLine());

                int probalkozasok = 1;
                Random r = new Random();
                while(true)
                {
                    var probalkozas = r.Next(also + 1, felso - 1);
                    var lehetosegek = felso - also;
                    Console.WriteLine("A gondolt számod Kissebb, mint {0} vagy ez a számod?", probalkozas);
                    Console.Write("Válaszolj! (K vagy v = kissebb), (N vagy n => nagyobb) (E vag e => ez a számom): ");
                    var valasz = Console.ReadLine()[0];

                    if (valasz == 'k' || valasz == 'k') felso = probalkozas;
                    else if (valasz == 'E' || valasz == 'e')
                    {
                        Console.WriteLine("Az általad gondolt szám: {0}", probalkozas);
                        Console.WriteLine("A számodat {0} próbálkozásból találtam ki.", probalkozasok);
                        break;
                    }
                    else also = probalkozas;
                    ++probalkozasok;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Hiba történt: {0}", ex.Message);
            }
            Console.ReadKey();
        }
    }
}
