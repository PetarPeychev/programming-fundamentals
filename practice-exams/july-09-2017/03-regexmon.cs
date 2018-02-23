using System;
using System.Text.RegularExpressions;

namespace ConsoleNETCore
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            string patternBojo = @"([a-zA-Z]+-[a-zA-Z]+)";
            Regex regexBojo = new Regex(patternBojo); 
            string patternDidi = @"([^a-zA-Z-]+)";
            Regex regexDidi = new Regex(patternDidi);
            sbyte switcher = -1;
            int startAtCounter = 0;
            while (true)
            {
                if (switcher == -1)
                {
                    Match matchDidi = regexDidi.Match(inputString, startAtCounter);
                    if (matchDidi.Value == string.Empty) break;
                    startAtCounter = matchDidi.Index + matchDidi.Length - 1;
                    Console.WriteLine(matchDidi.Groups[0]);
                }
                else
                {
                    Match matchBojo = regexBojo.Match(inputString, startAtCounter);
                    if (matchBojo.Value == string.Empty) break;
                    startAtCounter = matchBojo.Index + matchBojo.Length - 1;
                    Console.WriteLine(matchBojo.Groups[0]);
                }
                switcher *= -1;
            }
        }
    }
}
