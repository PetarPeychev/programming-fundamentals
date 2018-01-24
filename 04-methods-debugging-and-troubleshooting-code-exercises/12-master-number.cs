using System;

namespace ConsoleNETCore
{
    class Program
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());
            for (int i = 1; i <= range; i++)
            {
                if (IsPalindrome(i) && SumOfDigitsIsDivisibleBy7(i) && ContainsEvenDigit(i))
                    Console.WriteLine(i);
            }
        }

        static bool IsPalindrome(int input)
        {
            long number = input;
            long reversedNumber = 0;
            while (number != 0)
            {
                reversedNumber = reversedNumber * 10 + number % 10;
                number /= 10;
            }
            if (reversedNumber == input) return true;
            else return false;
        }

        static bool SumOfDigitsIsDivisibleBy7(int input)
        {
            int sum = 0;
            for (int i = 0; i < input.ToString().Length; i++)
            {
                sum += int.Parse(input.ToString()[i].ToString());
            }

            if (sum % 7 == 0) return true;
            else return false;
        }

        static bool ContainsEvenDigit(int input)
        {
            for (int i = 0; i < input.ToString().Length; i++)
            {
                if (int.Parse(input.ToString()[i].ToString()) % 2 == 0)
                    return true;
            }
            return false;
        }
    }
}
