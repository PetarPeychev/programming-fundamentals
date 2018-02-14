using System;
using System.Linq;
using System.Numerics;

namespace ConsoleNETCore
{
    class Program
    {
        static void Main(string[] args)
        {
            byte numberOfWebsites = byte.Parse(Console.ReadLine());
            byte securityKey = byte.Parse(Console.ReadLine());

            Website[] affectedWebsites = new Website[numberOfWebsites];
            decimal totalLoss = 0M;

            for (int i = 0; i < numberOfWebsites; i++)
            {
                string[] websiteData =
                    Console.ReadLine()
                    .Split(' ')
                    .ToArray();

                affectedWebsites[i] = new Website()
                {
                    Name = websiteData[0],
                    Visits = long.Parse(websiteData[1]),
                    PricePerVisit = decimal.Parse(websiteData[2])
                 };
                
                totalLoss += affectedWebsites[i].Visits * affectedWebsites[i].PricePerVisit;

                Console.WriteLine(affectedWebsites[i].Name);
            }

            BigInteger securityToken = BigInteger.Pow(securityKey, numberOfWebsites);

            Console.WriteLine($"Total Loss: {totalLoss:F20}");
            Console.WriteLine($"Security Token: {securityToken}");
        }
    }

    class Website
    {
        public string Name { get; set; }
        public long Visits { get; set; }
        public decimal PricePerVisit { get; set; }
    }
}
