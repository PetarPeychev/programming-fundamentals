using System;
using System.Linq;

namespace _02
{
    class Exercise02
    {
        static void Main(string[] args)
        {
            int sequenceLength = int.Parse(Console.ReadLine());

            int[] bestSequence = new int[sequenceLength];
            int bestSequenceLength = -1;
            int bestSequenceSum = -1;
            int bestSequenceIndex = -1;
            int bestSequenceNumber = -1;
            int counter = 0;
            while (true)
            {
                counter++;
                string input = Console.ReadLine();
                if (input == "Clone them!") break;
                int[] sequence = input.Split('!', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int sequenceSum = sequence.Sum(); 
                int longestSubsequenceIndex = -1;
                int longestSubsequenceLength = 0;
                int subsequenceLength = 0;
                int subsequenceIndex = 0;
                for (int i = 0; i < sequence.Length; i++)
                {
                    if (sequence[i] == 1)
                    {
                        subsequenceLength++;
                        if (subsequenceLength > longestSubsequenceLength)
                        {
                            longestSubsequenceLength = subsequenceLength;
                            longestSubsequenceIndex = subsequenceIndex;
                        }
                    }
                    else
                    {
                        subsequenceIndex = i + 1;
                        subsequenceLength = 0;
                    }
                }


                if (longestSubsequenceLength > bestSequenceLength)
                {
                    bestSequence = sequence;
                    bestSequenceNumber = counter;
                    bestSequenceLength = longestSubsequenceLength;
                    bestSequenceSum = sequenceSum;
                    bestSequenceIndex = longestSubsequenceIndex;
                }
                else if (longestSubsequenceLength == bestSequenceLength)
                {
                    if (longestSubsequenceIndex < bestSequenceIndex)
                    {
                        bestSequence = sequence;
                        bestSequenceNumber = counter;
                        bestSequenceLength = longestSubsequenceLength;
                        bestSequenceSum = sequenceSum;
                        bestSequenceIndex = longestSubsequenceIndex;
                    }
                    else if (sequenceSum > bestSequenceSum)
                    {
                        bestSequence = sequence;
                        bestSequenceNumber = counter;
                        bestSequenceLength = longestSubsequenceLength;
                        bestSequenceSum = sequenceSum;
                        bestSequenceIndex = longestSubsequenceIndex;
                    }
                }
            }

            Console.WriteLine($"Best DNA sample {bestSequenceNumber} with sum: {bestSequenceSum}.");
            Console.WriteLine(string.Join(' ', bestSequence));
        }
    }
}
