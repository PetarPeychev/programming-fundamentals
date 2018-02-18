using System;
using System.Text.RegularExpressions;

namespace ConsoleNETCore
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();
            string emailPattern = @"(^|(?<=\s))(([a-zA-Z0-9]+)([\.\-_]?)([A-Za-z0-9]+)(@)([a-zA-Z]+([\.\-_][A-Za-z]+)+))(\b|(?=\s))";
            Regex email = new Regex(emailPattern);
            MatchCollection matches = email.Matches(inputText);
            foreach (Match match in matches)
            {
                Console.WriteLine(match.ToString().Trim());
            }
        }
    }
}
