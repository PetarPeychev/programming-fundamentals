using System;

namespace ConsoleNETCore
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong input = ulong.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(input));
        }

        static bool IsPrime(ulong inputNumber)
        {
            if (inputNumber == 0 || inputNumber == 1) return false;
            else
            {
                bool isPrime = true;
                for (ulong i = 2; i <= Math.Sqrt(inputNumber); i++)
                {
                    if (inputNumber % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                return isPrime;
            }
        }
    }
}
