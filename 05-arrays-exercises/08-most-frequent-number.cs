using System;
using System.Linq;

namespace ConsoleNETCore
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort[] inputArray = Console.ReadLine().Split(' ').Select(ushort.Parse).ToArray();
            int highestNumberOccurences = 0;
            ushort mostFrequentNumber = inputArray[0];
            for (ushort i = 0; i < inputArray.Length; i++)
            {
                int currentNumberOccurences = 0;
                for (int j = 0; j < inputArray.Length; j++)
                {
                    if (inputArray[j] == inputArray[i]) currentNumberOccurences++;
                }
                if (currentNumberOccurences > highestNumberOccurences)
                {
                    highestNumberOccurences = currentNumberOccurences;
                    mostFrequentNumber = inputArray[i];
                }
                currentNumberOccurences = 0;
            }
            Console.WriteLine(mostFrequentNumber);
        }
    }
}
