using System;
using System.Linq;

namespace ConsoleNETCore
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] firstArray = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] secondArray = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            bool FirstArrayIsSmaller;
            if (firstArray.Length <= secondArray.Length)
                FirstArrayIsSmaller = true;
            else
                FirstArrayIsSmaller = false;
            for (int i = 0; i < Math.Min(firstArray.Length, secondArray.Length); i++)
            {
                int firstChar = Convert.ToChar(firstArray[i].ToString().ToLower());
                int secondChar = Convert.ToChar(secondArray[i].ToString().ToLower());
                if (firstChar > secondChar)
                    FirstArrayIsSmaller = false;
            }
            if (FirstArrayIsSmaller)
            {
                Console.WriteLine(string.Join("", firstArray));
                Console.WriteLine(string.Join("", secondArray));
            }
            else
            {
                Console.WriteLine(string.Join("", secondArray));
                Console.WriteLine(string.Join("", firstArray));
            }
        }
    }
}
