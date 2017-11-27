using System;

namespace Console_.NET_Core
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine());

            int studioPrice = 0;
            int doublePrice = 0;
            int suitePrice = 0;
            int studioDiscountPercentage = 0;
            int doubleDiscountPercentage = 0;
            int suiteDiscountPercentage = 0;

            if (month == "May" || month == "October")
            {
                studioPrice = 50;
                doublePrice = 65;
                suitePrice = 75;

                if (nightsCount > 7) studioDiscountPercentage = 5;
            }
            else if (month == "June" || month == "September")
            {
                studioPrice = 60;
                doublePrice = 72;
                suitePrice = 82;

                if (nightsCount > 14) doubleDiscountPercentage = 10;
            }
            else if (month == "July" || month == "August" || month == "December")
            {
                studioPrice = 68;
                doublePrice = 77;
                suitePrice = 89;

                if (nightsCount > 14) suiteDiscountPercentage = 15;
            }

            int studioNightsCount = nightsCount;
            if (nightsCount > 7 && (month == "September" || month == "October"))
                studioNightsCount--;

            double studioDiscountPerNight = studioDiscountPercentage / 100.0 * studioPrice;
            double doubleDiscountPerNight = doubleDiscountPercentage / 100.0 * doublePrice;
            double suiteDiscountPerNight = suiteDiscountPercentage / 100.0 * suitePrice;

            double studioPriceForTheStay = studioPrice * studioNightsCount - studioDiscountPerNight * studioNightsCount;
            double doublePriceForTheStay = doublePrice * nightsCount - doubleDiscountPerNight * nightsCount;
            double suitePriceForTheStay = suitePrice * nightsCount - suiteDiscountPerNight * nightsCount;

            Console.WriteLine($"Studio: {studioPriceForTheStay:f2} lv.");
            Console.WriteLine($"Double: {doublePriceForTheStay:f2} lv.");
            Console.WriteLine($"Suite: {suitePriceForTheStay:f2} lv.");
        }
    }
}
