using System;

namespace ConsoleNETCore
{
    class Program
    {
        static void Main(string[] args)
        {
            string hexadecimal = Console.ReadLine();
            int integer = Convert.ToInt32(hexadecimal, 16);
            Console.WriteLine(integer);
        }
    }
}
