using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name, onto the Console: ");
            var expectedName = Console.ReadLine();
            Console.WriteLine($"Hello World {expectedName}");
        }
    }
}
