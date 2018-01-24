using System;

namespace ConsoleNETCore
{
    class Program
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine();
            switch (figureType)
            {
                case "triangle":
                    double triangleSide = double.Parse(Console.ReadLine());
                    double triangleHeight = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{TriangleArea(triangleSide, triangleHeight):f2}");
                    break;
                case "square":
                    double squareSide = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{SquareArea(squareSide):f2}");
                    break;
                case "rectangle":
                    double rectangleWidth = double.Parse(Console.ReadLine());
                    double rectangleHeight = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{RectangleArea(rectangleWidth, rectangleHeight):f2}");
                    break;
                case "circle":
                    double circleRadius = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{CircleArea(circleRadius):f2}");
                    break;
                default: Console.WriteLine("Error: Invalid figure type!");
                    break;
            }
        }

        static double TriangleArea(double side, double height)
        {
            double area = side * height / 2;
            return area;
        }

        static double SquareArea(double side)
        {
            double area = side * side;
            return area;
        }

        static double RectangleArea(double width, double height)
        {
            double area = width * height;
            return area;
        }

        static double CircleArea(double radius)
        {
            double area = Math.PI * radius * radius;
            return area;
        }
    }
}
