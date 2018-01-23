using System;
using System.Collections.Generic;

namespace ConsoleNETCore
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());
            List<int> primesList = FindPrimesInRange(startNum, endNum);
            int index = 0;
            foreach (int prime in primesList)
            {
                if(index > 0) Console.Write(", ");
                Console.Write($"{prime}");
                index++;
            }
        }

        static List<int> FindPrimesInRange(int startNum, int endNum)
        {
            List<int> primesList = new List<int>();
            for (int i = startNum; i <= endNum; i++)
            {
                if (IsPrime(i)) primesList.Add(i);
            }
            return primesList;
        }

        static bool IsPrime(int inputNumber)
        {
            if (inputNumber == 0 || inputNumber == 1) return false;
            else
            {
                bool isPrime = true;
                for (int i = 2; i <= Math.Sqrt(inputNumber); i++)
                {
                    if (inputNumber % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                return isPrime;
            }
        }
    }
}
