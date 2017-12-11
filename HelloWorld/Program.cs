using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);

            Console.WriteLine("\nWhat is your name ? (Creepy)");
            var name = Console.ReadLine();
            var date = DateTime.Now;
            Console.WriteLine("\nHello {0}, on {1:d} at {1:t}", name, date);

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);

        }
    }
}
