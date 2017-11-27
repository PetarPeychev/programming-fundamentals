using System;

namespace Console_.NET_Core
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            float drinkPrice;
            switch (profession)
            {
                case "Athlete": drinkPrice = 0.70f; break;
                case "Businessman": 
                case "Businesswoman": drinkPrice = 1.00f; break;
                case "SoftUni Student": drinkPrice = 1.70f; break;
                default: drinkPrice = 1.20f; break;
            }
            float totalPrice = drinkPrice * quantity;
            Console.WriteLine($"The {profession} has to pay {totalPrice:f2}.");
        }
    }
}
