using System;

namespace Console_.NET_Core
{
    class Program
    {
        static void Main(string[] args)
        {
            byte peshoDamage = byte.Parse(Console.ReadLine());
            byte goshoDamage = byte.Parse(Console.ReadLine());
            int peshoHealth = 100;
            int goshoHealth = 100;
            int currentRound = 0;

            while (true)
            {
                currentRound++;

                if (currentRound % 2 == 0 && peshoHealth <= goshoDamage)
                {
                    Console.WriteLine($"Gosho won in {currentRound}th round.");
                    break;
                }
                else if (currentRound % 2 == 1 && goshoHealth <= peshoDamage)
                {
                    Console.WriteLine($"Pesho won in {currentRound}th round.");
                    break;
                }
                else if (currentRound % 2 == 1)
                {
                    goshoHealth -= peshoDamage;
                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHealth} health.");
                }
                else if (currentRound % 2 == 0)
                {
                    peshoHealth -= goshoDamage;
                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHealth} health.");
                }

                if (currentRound % 3 == 0)
                {
                    peshoHealth += 10;
                    goshoHealth += 10;
                }
            }
        }
    }
}
