using System;

namespace game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("This is in C#.");

            Console.WriteLine("What is your favorite color? ");
            string color = Console.ReadLine();
            Console.WriteLine($"Your favorite color is {color}");
        }
    }
}