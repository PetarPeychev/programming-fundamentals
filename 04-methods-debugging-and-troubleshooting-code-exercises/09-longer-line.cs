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
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            string longerLine;

            if (DistanceBetweenPoints(x1, y1, x2, y2) >= DistanceBetweenPoints(x3, y3, x4, y4))
                longerLine = CloserToOrigin(x1, y1, x2, y2, true) + CloserToOrigin(x1, y1, x2, y2, false);
            else
                longerLine = CloserToOrigin(x3, y3, x4, y4, true) + CloserToOrigin(x3, y3, x4, y4, false);

            Console.WriteLine(longerLine);
        }

        static double DistanceBetweenPoints(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            return distance;
        }

        static string CloserToOrigin(double x1, double y1, double x2, double y2, bool isTrue)
        {
            double distanceToOrigin1 = DistanceBetweenPoints(x1, y1, 0, 0);
            double distanceToOrigin2 = DistanceBetweenPoints(x2, y2, 0, 0);

            if (isTrue)
            {
                if (distanceToOrigin1 <= distanceToOrigin2)
                    return $"({x1}, {y1})";
                else
                    return $"({x2}, {y2})";
            }
            else
            {
                if (distanceToOrigin1 > distanceToOrigin2)
                    return $"({x1}, {y1})";
                else
                    return $"({x2}, {y2})";
            }
        }
    }
}
