using System;

namespace Console_.NET_Core
{
    class Program
    {
        static void Main(string[] args)
        {
            float width = float.Parse(Console.ReadLine());
            float height = float.Parse(Console.ReadLine());

            float rectangleArea = width * height;

            Console.WriteLine("{0:f2}", rectangleArea);
        }
    }
}
