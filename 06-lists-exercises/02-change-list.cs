using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleNETCore
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            while (true)
            {
                List<string> inputCommand = Console.ReadLine().Split(' ').ToList();
                switch (inputCommand[0])
                {
                    case "Delete":
                        input.RemoveAll(i => i == int.Parse(inputCommand[1]));
                        break;
                    case "Insert":
                        input.Insert(int.Parse(inputCommand[2]), int.Parse(inputCommand[1]));
                        break;
                    case "Odd":
                        foreach (int integer in input)
                            if (integer % 2 != 0) Console.Write($"{integer} ");
                        return;
                    case "Even":
                        foreach (int integer in input)
                            if (integer % 2 == 0) Console.Write($"{integer} ");
                        return;
                }
            }
        }
    }
}
