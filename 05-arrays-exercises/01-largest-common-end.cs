using System;

namespace ConsoleNETCore
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split(' ');
            string[] secondArray = Console.ReadLine().Split(' ');

            int leftCommonWordCount = 0;
            for (int i = 0; i < Math.Min(firstArray.Length, secondArray.Length); i++)
            {
                if (firstArray[i] == secondArray[i])
                    leftCommonWordCount++;
                else break;
            }

            int rightCommonWordCount = 0;
            for (int i = 0; i < Math.Min(firstArray.Length, secondArray.Length); i++)
            {
                if (firstArray[firstArray.Length - i - 1] == secondArray[secondArray.Length - i - 1])
                    rightCommonWordCount++;
                else break;
            }

            Console.WriteLine(Math.Max(leftCommonWordCount, rightCommonWordCount));
        }
    }
}
