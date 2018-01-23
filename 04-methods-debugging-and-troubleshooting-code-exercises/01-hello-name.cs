using System;

namespace ConsoleNETCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Hello(Console.ReadLine());
        }

        static void Hello(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
