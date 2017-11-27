using System;

namespace Console_.NET_Core
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int startPoint = Math.Min(firstNumber, secondNumber);
            int endPoint = Math.Max(firstNumber, secondNumber);

            for (int i = startPoint; i <= endPoint; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
