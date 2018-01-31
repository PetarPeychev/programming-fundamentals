using System;
using System.Linq;

namespace ConsoleNETCore
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int longestSequenceLength = 1;
            int longestSequenceStart = 0;
            int currentSequenceLength = 1;
            int currentSequenceStart = 0;
            for (int i = 1; i < inputArray.Length; i++)
            {
                if (inputArray[i] > inputArray[i - 1])
                {
                    currentSequenceLength++;
                    if (currentSequenceLength > longestSequenceLength)
                    {
                        longestSequenceLength = currentSequenceLength;
                        longestSequenceStart = currentSequenceStart;
                    }
                }
                else
                {
                    currentSequenceLength = 1;
                    currentSequenceStart = i;
                }
            }
            for (int i = longestSequenceStart; i < longestSequenceStart + longestSequenceLength; i++)
            {
                Console.Write($"{inputArray[i]} ");
            }
        }
    }
}
