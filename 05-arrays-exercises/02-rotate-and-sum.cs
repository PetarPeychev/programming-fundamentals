using System;
using System.Linq;

namespace ConsoleNETCore
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int numberOfRotations = int.Parse(Console.ReadLine());

            foreach (int item in SumRotations(inputArray, numberOfRotations))
            {
                Console.Write(item + " ");
            }
        }

        static int[] RotateArray(int[] array, int rotations)
        {
            int[] rotatedArray = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                rotatedArray[(i + rotations) % array.Length] = array[i]; 
            }
            return rotatedArray;
        }

        static int[] SumRotations(int[] array, int rotations)
        {
            int[] sumArray = new int[array.Length];
            for (int i = 1; i <= rotations; i++)
            {
                int[] rotatedArray = RotateArray(array, i);
                for (int j = 0; j < array.Length; j++)
                {
                    sumArray[j] += rotatedArray[j];
                }
            }
            return sumArray;
        }
    }
}
