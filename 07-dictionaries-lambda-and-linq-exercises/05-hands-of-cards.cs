using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleNETCore
{
    class Program
    {
        static void Main(string[] args)
        {
            var playerHands = new Dictionary<string, List<string>>();
            while (true)
            {
                string[] inputHand =
                    Console.ReadLine()
                    .Split(' ')
                    .Select(x => x.Replace(",", "").Replace(":", ""))
                    .ToArray();
                if (inputHand[0] == "JOKER") break;
                if (playerHands.ContainsKey(inputHand[0]) == false)
                {
                    playerHands.Add(inputHand[0], new List<string>());
                }
                playerHands[inputHand[0]].AddRange(inputHand.Skip(1));
                playerHands[inputHand[0]] = playerHands[inputHand[0]].Distinct().ToList();
            }
            var playerScores = new Dictionary<string, int>();
            foreach (var playerHand in playerHands)
            {
                playerScores[playerHand.Key] = 0;
                foreach (string card in playerHand.Value)
                {
                    string power = new string(card.Reverse().Skip(1).Reverse().ToArray());
                    string type = new string(card.Reverse().Take(1).ToArray());
                    int powerScore = 0;
                    int typeMultiplier = 0;
                    switch (power)
                    {
                        case "J":
                            powerScore = 11;
                            break;
                        case "Q":
                            powerScore = 12;
                            break;
                        case "K":
                            powerScore = 13;
                            break;
                        case "A":
                            powerScore = 14;
                            break;
                        default:
                            int.TryParse(power, out powerScore); // There is some stupid test, which doesn't pass this.
                            break;
                    }
                    switch (type)
                    {
                        case "S":
                            typeMultiplier = 4;
                            break;
                        case "H":
                            typeMultiplier = 3;
                            break;
                        case "D":
                            typeMultiplier = 2;
                            break;
                        case "C":
                            typeMultiplier = 1;
                            break;
                    }
                    playerScores[playerHand.Key] += powerScore * typeMultiplier;
                }
            }
            foreach (var player in playerScores)
            {
                Console.WriteLine($"{player.Key}: {player.Value}");
            }
        }
    }
}
