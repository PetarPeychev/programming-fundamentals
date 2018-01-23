using System;

namespace ConsoleNETCore
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal inputNumber = decimal.Parse(Console.ReadLine());
            Console.WriteLine(ReverseDecimal(inputNumber));
        }

        static decimal ReverseDecimal(decimal input)
        {
            string stringRepresentation = input.ToString();
            string reversedString = "";
            for (int i = stringRepresentation.Length - 1; i >= 0; i--)
            {
                reversedString += stringRepresentation[i];
            }
            return decimal.Parse(reversedString);
        }
    }
}
