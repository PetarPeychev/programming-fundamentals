using System;

namespace Console_.NET_Core
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int magicalNumber = int.Parse(Console.ReadLine());
            int numberOfCombinations = 0;
            int firstMagicalNumber = 0;
            int secondMagicalNumber = 0;
            bool thereIsAMatch = false;

            for (int i = firstNumber; i <= secondNumber; i++)
            {
                for (int j = firstNumber; j <= secondNumber; j++)
                {
                    numberOfCombinations++;

                    if (i + j == magicalNumber)
                    {
                        thereIsAMatch = true;
                        firstMagicalNumber = i;
                        secondMagicalNumber = j;
                    }
                }
            }

            if (thereIsAMatch)
                Console.WriteLine($"Number found! {firstMagicalNumber} + {secondMagicalNumber} = {magicalNumber}");
            else
                Console.WriteLine($"{numberOfCombinations} combinations - neither equals {magicalNumber}");
        }
    }
}
