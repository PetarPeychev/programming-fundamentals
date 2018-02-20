using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace ConsoleNETCore
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize a dictionary, containing all data sets by name, with their dictionaries of elements as values.
            var dataSets = new Dictionary<string, Dictionary<string, int>>();

            // Initialize a cache, containing all data, not belonging to a specific set.
            var cache = new Dictionary<string, Dictionary<string, int>>();

            // Initialize a dictionary of the total dataSet sizes.
            var dataSetDict = new SortedDictionary<string, BigInteger>();

            // Here we store the biggest dataSet.
            string maxDataSetName = "";
            BigInteger maxDataSetValue = -1;

            while (true)
            {
                // Read the command from the console.
                string input = Console.ReadLine();

                // Check input for termination command.
                if (input == "thetinggoesskrra") break;

                // Check input for "dataKey -> dataSize | dataSet" command.
                else if (input.Contains("->"))
                {
                    string[] inputArray = input.Split(' ').ToArray();
                    if (dataSets.ContainsKey(inputArray[4]))
                    {
                        // If the dataSet exists, add the data.
                        dataSets[inputArray[4]].Add(inputArray[0], int.Parse(inputArray[2]));
                        dataSetDict[inputArray[4]] += int.Parse(inputArray[2]);

                        // Check for the dataSet being bigger than the max dataSet.
                        if (dataSetDict[inputArray[4]] > maxDataSetValue)
                        {
                            maxDataSetValue = dataSetDict[inputArray[4]];
                            maxDataSetName = inputArray[4];
                        }
                    }
                    else
                    {
                        // If the dataSet does not exist, add the data to cache.
                        if (cache.ContainsKey(inputArray[4]))
                            cache[inputArray[4]].Add(inputArray[0], int.Parse(inputArray[2]));
                        else
                        {
                            cache.Add(inputArray[4], new Dictionary<string, int>());
                            cache[inputArray[4]].Add(inputArray[0], int.Parse(inputArray[2]));
                        }
                    }
                }

                // Input is "dataSet" command.
                else
                {
                    // Add the new dataSet.
                    dataSets.Add(input, new Dictionary<string, int>());
                    dataSetDict.Add(input, 0);

                    // Check cache for any data from this dataSet and add it.
                    if (cache.ContainsKey(input))
                    {
                        foreach (var item in cache[input])
                        {
                            dataSets[input].Add(item.Key, item.Value);
                            dataSetDict[input] += item.Value;
                        }

                        // Check for the dataSet being bigger than the max dataSet.
                        if (dataSetDict[input] > maxDataSetValue)
                        {
                            maxDataSetValue = dataSetDict[input];
                            maxDataSetName = input;
                        }
                    }
                }
            }

            // If there are any dataSets, print the output.
            if ((maxDataSetValue == -1) == false)
            {
                Console.WriteLine($"Data Set: {maxDataSetName}, Total Size: {maxDataSetValue}");
                foreach (var item in dataSets[maxDataSetName])
                {
                    Console.WriteLine($"$.{item.Key}");
                }
            }
        }
    }
}
