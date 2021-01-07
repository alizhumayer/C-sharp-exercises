using System;

namespace elso_konzolos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jó estét!");

            Console.WriteLine("Vizsgáljuk meg a víz halmazállapotát!");
            char c='i';

            while (c == 'i')
            {                           
                Console.WriteLine("Add meg a víz hőmérsékletét: ");
                double t = Convert.ToDouble(Console.ReadLine());

                if (t > 0)
                {
                    if (t > 100)
                    {
                        Console.WriteLine("ez gőz");
                    }
                    else Console.WriteLine("ez a víz folyékony");
                }
                else Console.WriteLine("ez jég");

                Console.WriteLine("Szeretnél új adatot megadni? i/n: ");
                c = Convert.ToChar(Console.ReadLine());
            }
        }
    }
}
