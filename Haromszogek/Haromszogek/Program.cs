using System;

namespace Haromszogek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Háromszögek");

            Console.WriteLine("A háromszög 'a' oldala");
            int a = int.Parse(Console.ReadLine());
            
            Console.WriteLine("A háromszög 'b' oldala");
            int b = int.Parse(Console.ReadLine());
            
            Console.WriteLine("A háromszög 'c' oldala");
            int c = int.Parse(Console.ReadLine());

            if ((a + b > c) && (a + c > b) && (b + c > a)) Console.WriteLine("A háromszög szerkeszthető");
            else Console.WriteLine("A háromszög sajnos nem szerkeszthető");

            if (a == b && b == c && a == c) Console.WriteLine("A háromszög egyenlő oldalú.");
            else if (a == b || b == c || a == c) Console.WriteLine("A háromszög egyenlő szárú.");
            else Console.WriteLine("A háromszög nem egyenlő oldalú, és nem egyenlő szárú.");
        }
    }
}
