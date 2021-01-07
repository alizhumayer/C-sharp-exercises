using System;

namespace Homersekletvalto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Celsius - Kelvin átváltás");

            Console.WriteLine("Adj meg egy hőmérséklet-értéket: ");
            double h = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Válassz (1): Celsius - Kelvin, (2): Kelvin - Celsius ");
            byte b = byte.Parse(Console.ReadLine());

            switch (b)
            {
                case 1:
                    Console.WriteLine("{0} C° = {1} K°", h, h + 273);
                    break;
                case 2:
                    Console.WriteLine("{0} K° = {1} C°", h, h - 273);
                    break;
            }
        }
    }
}
