using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleNETCore
{
    class Program
    {
        static void Main(string[] args)
        {
            var pokemonDict = new Dictionary<string, List<Evolution>>();
            var pokemonList = new List<string>();
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "wubbalubbadubdub") break;
                else
                {
                    string[] inputArray = input.Split(' ').ToArray();
                    if (inputArray.Length == 1 && pokemonList.Contains(inputArray[0]))
                    {
                        Console.WriteLine($"# {inputArray[0]}");
                        foreach (var evolution in pokemonDict[inputArray[0]])
                        {
                            Console.WriteLine($"{evolution.Type} <-> {evolution.Index}");
                        }
                    }
                    else
                    {
                        if (pokemonList.Contains(inputArray[0]) == false)
                        {
                            pokemonList.Add(inputArray[0]);
                            pokemonDict.Add(inputArray[0], new List<Evolution>());
                        }
                        pokemonDict[inputArray[0]].Add(new Evolution(inputArray[2], long.Parse(inputArray[4])));
                    }
                }
            }
            foreach (var pokemon in pokemonList)
            {
                Console.WriteLine($"# {pokemon}");
                var evolutions = pokemonDict[pokemon].OrderByDescending(i => i.Index);
                foreach (var pokemonEvolution in evolutions)
                {
                    Console.WriteLine($"{pokemonEvolution.Type} <-> {pokemonEvolution.Index}");
                }
            }
        }

        class Evolution
        {
            public string Type { get; set; }
            public long Index { get; set; }

            public Evolution(string inputType, long inputIndex)
            {
                Type = inputType;
                Index = inputIndex;
            }
        }
    }
}
