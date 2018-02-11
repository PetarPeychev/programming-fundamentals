using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string[] comands = Console.ReadLine().Split(' ').ToArray();

            while (comands[0] != "print")
            {
                if (comands[0] == "add")
                {
                    int index = int.Parse(comands[1]);
                    int element = int.Parse(comands[2]);

                    numbers.Insert(index, element);
                }
                else if (comands[0] == "addMany")
                {
                    int index = int.Parse(comands[1]);
                    List<int> elements = comands.Skip(2).Select(int.Parse).ToList();
                    
                    numbers.InsertRange(index, elements);
                }
                else if (comands[0] == "contains")
                {
                    int num = int.Parse(comands[1]);
                    int index = numbers.IndexOf(num);
                    Console.WriteLine(index);
                }
                else if (comands[0] == "remove")
                {
                    int index = int.Parse(comands[1]);
                    numbers.RemoveAt(index);

                }
                else if (comands[0] == "shift")
                {
                    int positions = int.Parse(comands[1]);
                    
                    for (int i = 0; i < positions; i++)
                    {
                        int firstElent = numbers.First();
                        numbers.RemoveAt(0);
                        numbers.Add(firstElent);
                    }

                }
                else if (comands[0] == "sumPairs")
                {
                    for (int i = 0; i < numbers.Count() - 1; i++)
                    {
                        numbers[i] = numbers[i] + numbers[i + 1];
                        numbers.RemoveAt(i + 1);
                    }
                }
                comands = Console.ReadLine().Split(' ').ToArray();
            }
            Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }
    }
}
