using System;

namespace Console_.NET_Core
{
    class Program
    {
        static void Main(string[] args)
        {
            string noun = Console.ReadLine();
            int nounLength = noun.Length;
            string plural;

            if (noun.EndsWith("y"))
            {
                plural = noun.Remove(nounLength - 1);
                plural = plural + "ies";
            }
            else if (noun.EndsWith("o") ||
                noun.EndsWith("ch") ||
                noun.EndsWith("s") ||
                noun.EndsWith("sh") ||
                noun.EndsWith("x") ||
                noun.EndsWith("z"))
            {
                plural = noun + "es";
            }
            else
            {
                plural = noun + "s";
            }

            Console.WriteLine(plural);
        }
    }
}
