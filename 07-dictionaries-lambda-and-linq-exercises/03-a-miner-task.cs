using System;
using System.Collections.Generic;

namespace ConsoleNETCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, long> resources = new Dictionary<string, long>();
            while (true)
            {
                string inputString = Console.ReadLine();
                if (inputString == "stop") break;
                else
                {
                    int inputQuantity = int.Parse(Console.ReadLine());
                    if (resources.ContainsKey(inputString) == false)
                    {
                        resources.Add(inputString, 0);
                    }
                    resources[inputString] += inputQuantity;
                }
            }
            foreach (var resource in resources)
            {
                Console.WriteLine($"{resource.Key} -> {resource.Value}");
            }
        }
    }
}
