using System;

namespace Console_.NET_Core
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0;; i++)
            {
                string input = Console.ReadLine();
                if (input == "Bake!")
                {
                    Console.WriteLine($"Preparing cake with {i} ingredients.");
                    break;
                }
                else
                {
                    Console.WriteLine($"Adding ingredient {input}.");
                }
            }
        }
    }
}
