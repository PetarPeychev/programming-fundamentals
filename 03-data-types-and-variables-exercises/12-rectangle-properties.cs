using System;

namespace ConsoleNETCore
{
    class Program
    {
        static void Main(string[] args)
        {
            double height = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double perimeter = height * 2 + width * 2;
            double area = height * width;
            double diagonal = Math.Sqrt(height * height + width * width);
            Console.WriteLine(perimeter);
            Console.WriteLine(area);
            Console.WriteLine(diagonal);
        }
    }
}
