using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03
{
    class Exercise03
    {
        static void Main(string[] args)
        {
            int messageCount = int.Parse(Console.ReadLine());
            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();
            for (int i = 0; i < messageCount; i++)
            {
                string input = Console.ReadLine();
                int starCounter = 0;
                foreach (var character in input)
                {
                    if (character == 'S' ||
                        character == 'T' ||
                        character == 'A' ||
                        character == 'R' ||
                        character == 's' ||
                        character == 't' ||
                        character == 'a' ||
                        character == 'r')
                    {
                        starCounter++;
                    }
                }

                string decodedInput = new string(input.Select(x => (char)(x - starCounter)).ToArray());

                string pattern = @"@([a-zA-z]+)[^@,\-!:>]*:([0-9]+)[^@,\-!:>]*!([AD])![^@,\-!:>]*->([0-9]+)";
                Regex reg = new Regex(pattern);

                if (reg.IsMatch(decodedInput))
                {
                    string planetName = reg.Match(decodedInput).Groups[1].ToString();
                    if (reg.Match(decodedInput).Groups[3].ToString() == "A")
                    {
                        attackedPlanets.Add(planetName);
                    }
                    else if (reg.Match(decodedInput).Groups[3].ToString() == "D")
                    {
                        destroyedPlanets.Add(planetName);
                    }
                }
            }

            attackedPlanets = attackedPlanets.OrderBy(x => x).ToList();
            destroyedPlanets = destroyedPlanets.OrderBy(x => x).ToList();

            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            foreach (var planet in attackedPlanets)
            {
                Console.WriteLine($"-> {planet}");
            }
            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            foreach (var planet in destroyedPlanets)
            {
                Console.WriteLine($"-> {planet}");
            }
        }
    }
}
