using System;

namespace ConsoleNETCore
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool boolean = Convert.ToBoolean(input);
            if (boolean) Console.WriteLine("Yes");
            else if (!boolean) Console.WriteLine("No");
        }
    }
}
