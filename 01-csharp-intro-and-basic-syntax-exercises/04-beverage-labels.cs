using System;

namespace Console_.NET_Core
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energyContentPer100ml = int.Parse(Console.ReadLine());
            int sugarContentPer100ml = int.Parse(Console.ReadLine());

            double energyContent = energyContentPer100ml / 100.0 * volume;
            double sugarContent = sugarContentPer100ml / 100.0 * volume;

            Console.WriteLine("{0}ml {1}:", volume, name);
            Console.WriteLine("{0}kcal, {1}g sugars", energyContent, sugarContent);
        }
    }
}
