using System;

namespace ConsoleNETCore
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string outputParameter = Console.ReadLine();
            switch (outputParameter)
            {
                case "face": Console.WriteLine($"{CubeFaceDiagonal(side):F2}");
                    break;
                case "space":
                    Console.WriteLine($"{CubeSpaceDiagonal(side):F2}");
                    break;
                case "volume":
                    Console.WriteLine($"{CubeVolume(side):F2}");
                    break;
                case "area":
                    Console.WriteLine($"{CubeArea(side):F2}");
                    break;
            }
        }

        static double CubeFaceDiagonal(double side)
        {
            double diagonal = Math.Sqrt(2 * side * side);
            return diagonal;
        }

        static double CubeSpaceDiagonal(double side)
        {
            double diagonal = Math.Sqrt(3 * side * side);
            return diagonal;
        }

        static double CubeVolume(double side)
        {
            double volume = side * side * side;
            return volume;
        }

        static double CubeArea(double side)
        {
            double area = 6 * side * side;
            return area;
        }
    }
}
