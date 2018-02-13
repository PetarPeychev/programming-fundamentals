using System;
using System.Collections.Generic;

namespace ConsoleNETCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> emails = new Dictionary<string, string>();
            while (true)
            {
                string inputString = Console.ReadLine();
                if (inputString == "stop") break;
                else
                {
                    string inputEmail = Console.ReadLine();
                    emails.Add(inputString, inputEmail);
                }
            }
            foreach (var email in emails)
            {
                if ((email.Value.ToUpper().EndsWith("US") || email.Value.ToUpper().EndsWith("UK")) == false)
                    Console.WriteLine($"{email.Key} -> {email.Value}");
            }
        }
    }
}
