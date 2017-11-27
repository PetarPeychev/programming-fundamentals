using System;

namespace Console_.NET_Core
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int maximumSum = int.Parse(Console.ReadLine());
            int numberOfCombinations = 0;
            int totalSum = 0;
            bool doesCurrentSumExceedMaxSum = false;

            for (int i = firstNumber; i >= 1 ; i--)
            {
                for (int j = 1; j <= secondNumber; j++)
                {
                    int currentValue = i * j * 3;
                    totalSum += currentValue;
                    numberOfCombinations++;

                    if (totalSum >= maximumSum)
                    {
                        doesCurrentSumExceedMaxSum = true;
                        break;
                    }
                }
                if (doesCurrentSumExceedMaxSum) break;
            }

            Console.WriteLine($"{numberOfCombinations} combinations");
            if (doesCurrentSumExceedMaxSum)
                Console.WriteLine($"Sum: {totalSum} >= {maximumSum}");
            else
                Console.WriteLine($"Sum: {totalSum}");
        }
    }
}
