using System;

namespace ConsoleNETCore
{
    class Program
    {
        static void Main(string[] args)
        {
            long pokePower = long.Parse(Console.ReadLine());
            long distanceBetweentargets = long.Parse(Console.ReadLine());
            long exhaustionFactor = long.Parse(Console.ReadLine());
            decimal halfPower = pokePower * 0.5m;
            long targetCounter = 0;
            while (pokePower >= distanceBetweentargets)
            {
                pokePower -= distanceBetweentargets;
                targetCounter++;

                if (pokePower == halfPower && exhaustionFactor != 0)
                {
                    pokePower /= exhaustionFactor;
                }
            }
            Console.WriteLine(pokePower);
            Console.WriteLine(targetCounter);
        }
    }
}
