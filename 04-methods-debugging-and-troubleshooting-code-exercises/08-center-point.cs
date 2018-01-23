using System;

namespace ConsoleNETCore
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            Console.WriteLine(CloserToOrigin(x1, y1, x2, y2));
        }

        static string CloserToOrigin(double x1, double y1, double x2, double y2)
        {
            double squareOfDistanceFromOriginToFirstPoint = x1 * x1 + y1 * y1;
            double squareOfDistanceFromOriginToSecondPoint = x2 * x2 + y2 * y2;

            if (squareOfDistanceFromOriginToFirstPoint <= squareOfDistanceFromOriginToSecondPoint) return $"({x1}, {y1})";
            else return $"({x2}, {y2})";
        }
    }
}
