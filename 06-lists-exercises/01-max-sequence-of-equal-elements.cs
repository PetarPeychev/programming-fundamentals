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
            int currentSequenceStart = 0;
            int currentSequenceLength = 1;
            List<int> longestSequence = input.GetRange(0, 1);
            for (int i = 1; i < input.Count; i++)
            {
                if (input[i] == input[i - 1])
                {
                    currentSequenceLength++;
                    if (currentSequenceLength > longestSequence.Count)
                    {
                        longestSequence.Clear();
                        longestSequence.AddRange(input.GetRange(currentSequenceStart, currentSequenceLength));
                    }
                }
                else
                {
                    currentSequenceLength = 1;
                    currentSequenceStart = i;
                }
            }
            Console.WriteLine(String.Join(" ", longestSequence));
        }
    }
}
