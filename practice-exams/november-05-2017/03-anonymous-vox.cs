using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace ConsoleNETCore
{
    class Program
    {
        static void Main(string[] args)
        {
            string encodedText = Console.ReadLine();
            string[] placeholders = 
                Console.ReadLine()
                .Split('{', '}')
                .Where(x => x.Length > 0)
                .ToArray();
            string pattern = @"([A-Za-z]+)(.+)(\1)";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(encodedText);
            for (int i = 0; i < matches.Count; i++)
            {
                encodedText = ReplaceFirst(encodedText, matches[i].Groups[2].ToString(), placeholders[i]);
            }
            Console.WriteLine(encodedText);
        }

        static string ReplaceFirst(string text, string oldValue, string newValue)
        {
            string substringWithOldValue = text.Substring(0, text.IndexOf(oldValue) + oldValue.Length);

            string substringWithNewValue = substringWithOldValue.Replace(oldValue, newValue);

            return substringWithNewValue + text.Substring(substringWithOldValue.Length);
        }
    }
}
