using System;
using System.Linq;

namespace ConsoleNETCore
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            bool[] primes = new bool[input + 1];
            for (int i = 0; i < primes.Length; i++)
            {
                primes[i] = true;
            }
            for (int i = 2; i <= Math.Sqrt(input); i++)
            {
                if (primes[i] == true)
                {
                    for (int j = i * i; j <= input; j+=i)
                    {
                        primes[j] = false;
                    }
                }
            }
            for (int i = 2; i <= input; i++)
            {
                if (primes[i] == true) Console.Write($"{i} ");
            }
        }
    }
}
