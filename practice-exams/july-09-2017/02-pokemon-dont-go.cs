using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleNETCore
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> inputList =
                Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToList();

            long removedSum = 0;
            while (inputList.Count > 0)
            {
                int currentIndex = int.Parse(Console.ReadLine());
                long currentIndexElement = 0;
                if (currentIndex < 0)
                {
                    currentIndexElement = inputList[0];
                    inputList[0] = inputList[inputList.Count - 1];
                }
                else if (currentIndex >= inputList.Count)
                {
                    currentIndexElement = inputList[inputList.Count - 1];
                    inputList[inputList.Count - 1] = inputList[0];
                }
                else
                {
                    currentIndexElement = inputList[currentIndex];
                    inputList.RemoveAt(currentIndex); 
                }
                removedSum += currentIndexElement;
                for (int i = 0; i < inputList.Count; i++)
                {
                    if (inputList[i] <= currentIndexElement)
                    {
                        inputList[i] += currentIndexElement;
                    }
                    else
                    {
                        inputList[i] -= currentIndexElement;
                    }
                }
            }
            Console.WriteLine(removedSum);
        }
    }
}
