using System;

namespace ConsoleNETCore
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double difference = Math.Abs(firstNumber - secondNumber);
            double eps = 0.000001;
            if (difference < eps) Console.WriteLine("True");
            else Console.WriteLine("False");
        }
    }
}
