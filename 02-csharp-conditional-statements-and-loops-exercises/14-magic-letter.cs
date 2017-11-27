using System;

namespace Console_.NET_Core
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstLetter = char.Parse(Console.ReadLine());
            char secondLetter = char.Parse(Console.ReadLine());
            char exceptionLetter = char.Parse(Console.ReadLine());

            for (int i = firstLetter; i <= secondLetter; i++)
            {
                for (int j = firstLetter; j <= secondLetter; j++)
                {
                    for (int k = firstLetter; k <= secondLetter; k++)
                    {
                        if (i == exceptionLetter || j == exceptionLetter || k == exceptionLetter);
                        else
                            Console.Write($"{(char)i}{(char)j}{(char)k} ");
                    }
                }
            }
        }
    }
}
