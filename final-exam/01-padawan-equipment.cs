using System;

namespace _01
{
    class Exercise01
    {
        static void Main()
        {
            // Input from console.
            decimal choMoney = decimal.Parse(Console.ReadLine());
            int studentCount = int.Parse(Console.ReadLine());
            decimal lightsaberPrice = decimal.Parse(Console.ReadLine());
            decimal robePrice = decimal.Parse(Console.ReadLine());
            decimal beltPrice = decimal.Parse(Console.ReadLine());

            int freeBeltCount = studentCount / 6;

            int lightsaberCount = (int)Math.Ceiling(studentCount * 1.1);
            if (studentCount == 0) lightsaberCount = 0;

            decimal totalCost =
                lightsaberCount * lightsaberPrice
                + studentCount * robePrice
                + (studentCount - freeBeltCount) * beltPrice;

            if (totalCost <= choMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {Math.Round(totalCost, 2)}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {Math.Round(totalCost - choMoney, 2)}lv more.");
            }
        }
    }
}
