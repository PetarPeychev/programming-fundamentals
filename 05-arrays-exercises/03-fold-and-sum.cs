using System;
using System.Linq;

namespace ConsoleNETCore
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] outputArray = new int[inputArray.Length / 2];
            for (int i = 0; i < outputArray.Length; i++)
            {
                outputArray[i] += inputArray[inputArray.Length / 4 + i];
                if (i < inputArray.Length / 4)
                    outputArray[i] += inputArray[inputArray.Length / 4 - 1 - i];
                else
                    outputArray[i] += inputArray[inputArray.Length - i + inputArray.Length / 4 - 1];
            }
            Console.WriteLine(String.Join(" ", outputArray));
        }
    }
}
