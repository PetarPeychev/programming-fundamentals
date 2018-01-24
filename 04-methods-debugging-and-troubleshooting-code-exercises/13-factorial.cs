using System;
using System.Numerics;

namespace ConsoleNETCore
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(Factorial(input));
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
    }
}
