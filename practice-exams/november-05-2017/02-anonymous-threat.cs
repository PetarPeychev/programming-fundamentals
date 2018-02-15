using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleNETCore
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the input data and write it to a string list.
            List<string> inputList =
                Console.ReadLine()
                .Split(' ')
                .ToList();

            // Loop through, reading commands and executing them until the end command is written.
            while (true)
            {
                string[] commandArray =
                    Console.ReadLine()
                    .Split(' ')
                    .ToArray();

                if (commandArray[0] == "3:1") break;
                else if (commandArray[0] == "merge") 
                {
                    MergePartitions(inputList, int.Parse(commandArray[1]), int.Parse(commandArray[2]));
                }
                else if (commandArray[0] == "divide")
                {
                    DividePartitions(inputList, int.Parse(commandArray[1]), int.Parse(commandArray[2]));
                }
            }

            // Print the resulting data on a single console line, seperated by whitespace.
            Console.WriteLine(string.Join(" ", inputList));
        }

        static void MergePartitions(List<string> inputList, int startIndex, int endIndex)
        {
            // Fix out of range indices.
            if (startIndex < 0) startIndex = 0;
            else if (startIndex > inputList.Count - 1) return;
            if (endIndex > inputList.Count - 1) endIndex = inputList.Count - 1;
            if (startIndex > endIndex) return;

            // Take the specified range, merge it and put it back to the original list.
            List<string> outputList = new List<string>(inputList.GetRange(startIndex, endIndex - startIndex + 1));
            inputList.RemoveRange(startIndex, endIndex - startIndex + 1);
            inputList.Insert(startIndex, string.Join("", outputList));
        }

        static void DividePartitions(List<string> inputList, int index, int partitions)
        {
            // Convert the selected element to a string.
            string element = inputList[index];

            // Calculate the remainder of our partitions, which we leave appended to the last partition.
            int partitionRemainder = element.Length % partitions;

            // Calculate how many elements we will have in each partition.
            int elementsPerPartition = (element.Length - partitionRemainder) / partitions;

            // Run a loop, which adds whitespaces to our element at the required indices.
            int counter = 0;
            for (int i = elementsPerPartition; i < element.Length - partitionRemainder - counter; i += elementsPerPartition)
            {
                element = element.Insert(i + counter, " ");
                counter++; // The Counter is here to account for the change in element.Length as we add more whitespaces.
            }

            // Remove the old index and add the new seperated list in its place.
            inputList.RemoveAt(index);
            inputList.InsertRange(index, element.Split(' ').ToList());
        }
    }
}
