using System;

namespace ConsoleNETCore
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabetCharacters= new char[26];
            for (int i = 0; i < alphabetCharacters.Length; i++)
            {
                alphabetCharacters[i] = (char)(97 + i);
            }
            string inputWord = Console.ReadLine();
            for (int i = 0; i < inputWord.Length; i++)
            {
                for (int j = 0; j < alphabetCharacters.Length; j++)
                {
                    if (inputWord[i] == alphabetCharacters[j])
                    {
                        Console.WriteLine($"{inputWord[i]} -> {j}");
                    }
                }
            }
        }
    }
}
