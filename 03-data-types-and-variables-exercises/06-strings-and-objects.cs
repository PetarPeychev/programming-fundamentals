using System;

namespace ConsoleNETCore
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstString = "Hello";
            string secondString = "World";
            object obj = firstString + " " + secondString;
            Console.WriteLine((string)obj);
        }
    }
}
