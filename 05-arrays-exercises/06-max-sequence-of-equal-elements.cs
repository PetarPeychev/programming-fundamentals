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
            int longestSequenceNumber = inputArray[1];
            int currentSequenceLength = 1;
            int currentSequenceNumber = inputArray[1];
            for (int i = 1; i < inputArray.Length; i++)
            {
                currentSequenceNumber = inputArray[i];
                if (inputArray[i] == inputArray[i - 1])
                {
                    currentSequenceLength++;
                    if (currentSequenceLength > longestSequenceLength)
                    {
                        longestSequenceLength = currentSequenceLength;
                        longestSequenceNumber = currentSequenceNumber;
                    }
                }
                else currentSequenceLength = 1;
            }
            for (int i = 0; i < longestSequenceLength; i++)
            {
                Console.Write($"{longestSequenceNumber} ");
            }
        }
    }
}
