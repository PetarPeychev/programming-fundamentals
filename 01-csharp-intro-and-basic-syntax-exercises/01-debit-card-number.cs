using System;

namespace Console_.NET_Core
{
    class Program
    {
        static void Main(string[] args)
        {
            int digitOne = int.Parse(Console.ReadLine());
            int digitTwo = int.Parse(Console.ReadLine());
            int digitThree = int.Parse(Console.ReadLine());
            int digitFour = int.Parse(Console.ReadLine());

            Console.WriteLine("{0:D4} {1:D4} {2:D4} {3:D4}", digitOne, digitTwo, digitThree, digitFour);
        }
    }
}
