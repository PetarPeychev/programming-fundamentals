using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleNETCore
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();
            while (true)
            {
                List<string> input = 
                    Console.ReadLine()
                    .Split(' ')
                    .ToList();
                if (input[0] == "A")
                {
                    phonebook[input[1]] = input[2];
                }
                else if (input[0] == "S")
                {
                    if (phonebook.ContainsKey(input[1]))
                        Console.WriteLine($"{input[1]} -> {phonebook[input[1]]}");
                    else
                        Console.WriteLine($"Contact {input[1]} does not exist.");
                }
                else if (input[0] == "ListAll")
                {
                    foreach (var entry in phonebook)
                    {
                        Console.WriteLine($"{entry.Key} -> {entry.Value}");
                    }
                }
                else if (input[0] == "END")
                {
                    break;
                }
            }
        }
    }
}
