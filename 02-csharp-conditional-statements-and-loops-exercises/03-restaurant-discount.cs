using System;

namespace Console_.NET_Core
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string packageType = Console.ReadLine();
            string hallType = null;
            int hallPrice = 0;
            if (groupSize <= 50)
            {
                hallType = "Small Hall";
                hallPrice = 2500;
            }
            else if (groupSize <= 100 && groupSize > 50)
            {
                hallType = "Terrace";
                hallPrice = 5000;
            }
            else if (groupSize <= 120 && groupSize > 100)
            {
                hallType = "Great Hall";
                hallPrice = 7500;
            }

            int discount = 0;
            int packagePrice = 0;
            if (packageType == "Normal")
            {
                packagePrice = 500;
                discount = 5;
            }
            else if (packageType == "Gold")
            {
                packagePrice = 750;
                discount = 10;
            }
            else if (packageType == "Platinum")
            {
                packagePrice = 1000;
                discount = 15;
            }
      
            if (hallPrice != 0)
            {
                int totalPrice = hallPrice + packagePrice;
                double totalDiscount = totalPrice / 100.0 * discount;
                double pricePerPerson = (totalPrice - totalDiscount) / groupSize;
                Console.WriteLine($"We can offer you the {hallType}");
                Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
            }
            else Console.WriteLine("We do not have an appropriate hall.");
        }
    }
}
