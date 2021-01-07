using System;

namespace feladat_udvozles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kérlek add meg a nevedet: ");
            var neve = Console.ReadLine();
            Console.WriteLine("Szia {0}!", neve);
            Console.ReadKey();
        }
    }
}
