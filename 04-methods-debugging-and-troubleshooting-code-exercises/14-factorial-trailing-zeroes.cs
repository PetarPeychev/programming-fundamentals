using System;
using System.Numerics;

namespace ConsoleNETCore
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(NumberOfZeroes(Factorial(input)));
        }

        static BigInteger Factorial(int input)
        {
            BigInteger output = 1;
            for (int i = 1; i <= input; i++)
            {
                output *= i;
            }
            return output;
        }

        static int NumberOfZeroes(BigInteger input)
        {
            int numberOfZeroes = 0;
            for (int i = input.ToString().Length - 1; i > 0; i--)
            {
                if (int.Parse(input.ToString()[i].ToString()) == 0)
                    numberOfZeroes++;
                else break;
            }
            return numberOfZeroes;
        }
    }
}
