using System;

namespace ConsoleNETCore
{
    class Program
    {
        static void Main(string[] args)
        {
            char input = char.Parse(Console.ReadLine());
            bool isDigit = false;
            for (int i = '0'; i <= '9'; i++)
            {
                if (input == i) isDigit = true;
            }
            bool isVowel = false;
            switch (input.ToString().ToUpper())
            {
                case "A":
                case "E":
                case "I":
                case "O":
                case "U":
                case "Y": isVowel = true; break;
            }
            if (isDigit) Console.WriteLine("digit");
            if (isVowel) Console.WriteLine("vowel");
            if (!isDigit && !isVowel) Console.WriteLine("other");
        }
    }
}
