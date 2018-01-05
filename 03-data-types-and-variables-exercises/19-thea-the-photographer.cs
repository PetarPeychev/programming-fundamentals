using System;

namespace ConsoleNETCore
{
    class Program
    {
        static void Main(string[] args)
        {
            // Only 70/100 points. No idea what's going wrong.
            
            int totalPicturesTaken = int.Parse(Console.ReadLine());
            int filterTimeSeconds = int.Parse(Console.ReadLine());
            byte filterFactor = byte.Parse(Console.ReadLine());
            int uploadTimeSeconds = int.Parse(Console.ReadLine());
            int filteredPictures = (int)Math.Ceiling(((double)totalPicturesTaken * filterFactor) / 100);
            int totalFilterTimeSeconds = totalPicturesTaken * filterTimeSeconds;
            int totalUploadTimeSeconds = filteredPictures * uploadTimeSeconds;
            TimeSpan totalTime = TimeSpan.FromSeconds(totalUploadTimeSeconds + totalFilterTimeSeconds);
            string totalTimeFormatted = totalTime.ToString(@"d\:hh\:mm\:ss");
            Console.WriteLine(totalTimeFormatted);
        }        
    }
}
