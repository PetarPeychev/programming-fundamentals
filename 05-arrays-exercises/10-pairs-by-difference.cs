using System;
using System.Linq;

namespace ConsoleNETCore
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int inputDifference = int.Parse(Console.ReadLine());
            int matchingPairs = 0;
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                for (int j = i + 1; j < inputArray.Length; j++)
                {
                    if (Math.Abs((inputArray[i] - inputArray[j])) == inputDifference)
                        matchingPairs++;
                }
            }
            Console.WriteLine(matchingPairs);
        }
    }
}
