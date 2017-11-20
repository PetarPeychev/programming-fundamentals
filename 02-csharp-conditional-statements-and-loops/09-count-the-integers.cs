using System;

namespace Console_.NET_Core
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfIntegers = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out int result)) numberOfIntegers++;
                else break;
            }

            Console.WriteLine(numberOfIntegers);
        }
    }
}
