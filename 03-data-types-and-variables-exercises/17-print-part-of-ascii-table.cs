using System;

namespace ConsoleNETCore
{
    class Program
    {
        static void Main(string[] args)
        {
            byte startIndex = byte.Parse(Console.ReadLine());
            byte endIndex = byte.Parse(Console.ReadLine());
            for (byte i = startIndex; i <= endIndex; i++)
            {
                Console.Write($"{(char)i} ");
            }
            Console.WriteLine();
        }
    }
}
