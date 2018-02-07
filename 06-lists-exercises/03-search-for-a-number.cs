using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleNETCore
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] searchArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            inputList.RemoveRange(0, searchArray[1]);
            if (inputList.Contains(searchArray[2])) Console.WriteLine("YES!");
            else Console.WriteLine("NO!");
        }
    }
}
