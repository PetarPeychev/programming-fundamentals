using System;

namespace ConsoleNETCore
{
    class Program
    {
        static void Main(string[] args)
        {
            int distanceMeters = int.Parse(Console.ReadLine());
            byte hours = byte.Parse(Console.ReadLine());
            byte minutes = byte.Parse(Console.ReadLine());
            byte seconds = byte.Parse(Console.ReadLine());
            int totalSeconds = (hours * 60 + minutes) * 60 + seconds;
            float metersPerSecond = (float)distanceMeters / totalSeconds;
            float kilometersPerHour = (distanceMeters / 1000f) / (totalSeconds / 3600f);
            float milesPerHour = (distanceMeters / 1609.0f) / (totalSeconds / 3600.0f);
            Console.WriteLine(metersPerSecond);
            Console.WriteLine(kilometersPerHour);
            Console.WriteLine(milesPerHour);
        }
    }
}
