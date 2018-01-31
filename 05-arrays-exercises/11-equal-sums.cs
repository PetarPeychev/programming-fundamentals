using System;
using System.Linq;

namespace ConsoleNETCore
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            long leftSum = 0;
            long rightSum = inputArray.Sum();
            for (int i = 0; i < inputArray.Length; i++)
            {
                rightSum -= inputArray[i];
                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }
                leftSum += inputArray[i];
            }
            Console.WriteLine("no");
        }
    }
}
