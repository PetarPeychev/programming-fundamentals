namespace _07.BombNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] bombAndRange = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int theBomb = bombAndRange[0];
            int bombRange = bombAndRange[1];

            while (numbers.Contains(theBomb))
            {
                var countToBomb = 0;
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i]!=theBomb)
                    {
                        countToBomb++;
                    }
                    else
                    {
                        break;
                    }
                }

                var rightRange = countToBomb+bombRange;
                if (countToBomb+bombRange>numbers.Count)
                {
                    rightRange = numbers.Count-1;
                }
                for (int i = countToBomb; i <=rightRange; i++)
                {
                    numbers.RemoveAt(countToBomb);
                }

                var leftRange = countToBomb - bombRange;
                if (countToBomb - bombRange < 0)
                {
                    leftRange = 0;
                }
                for (int i = countToBomb-1; i >= leftRange; i--)
                {
                    numbers.RemoveAt(i);
                }
            }
            Console.WriteLine(numbers.Sum());
        }
    }
}
