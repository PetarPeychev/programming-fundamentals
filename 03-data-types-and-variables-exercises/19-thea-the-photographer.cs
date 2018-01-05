using System;

namespace ConsoleNETCore
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalPicturesTaken = int.Parse(Console.ReadLine());
            int filterTimeSeconds = int.Parse(Console.ReadLine());
            int filterFactor = int.Parse(Console.ReadLine());
            int uploadTimeSeconds = int.Parse(Console.ReadLine());
            int filteredPictures = (int)Math.Ceiling(((double)totalPicturesTaken * filterFactor) / 100);
            long totalFilterTimeSeconds = (long)totalPicturesTaken * filterTimeSeconds;
            long totalUploadTimeSeconds = (long)filteredPictures * uploadTimeSeconds;
            TimeSpan totalTime = TimeSpan.FromSeconds(totalUploadTimeSeconds + totalFilterTimeSeconds);
            string totalTimeFormatted = totalTime.ToString(@"d\:hh\:mm\:ss");
            Console.WriteLine(totalTimeFormatted);
        }        
    }
}
