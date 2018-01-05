using System;

namespace ConsoleNETCore
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            if (FitsInLong(input))
            {
                Console.WriteLine($"{input} can fit in:");
                if (FitsInSbyte(input)) Console.WriteLine($"* sbyte");
                if (FitsInByte(input)) Console.WriteLine($"* byte");
                if (FitsInShort(input)) Console.WriteLine($"* short");
                if (FitsInUshort(input)) Console.WriteLine($"* ushort");
                if (FitsInInt(input)) Console.WriteLine($"* int");
                if (FitsInUint(input)) Console.WriteLine($"* uint");
                Console.WriteLine("* long");
            }
            else
                Console.WriteLine($"{input} can't fit in any type");
        }        

        static bool FitsInSbyte(string input)
        {
            try
            {
                sbyte sbyteInt = sbyte.Parse(input);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        static bool FitsInByte(string input)
        {
            try
            {
                byte byteInt = byte.Parse(input);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        static bool FitsInShort(string input)
        {
            try
            {
                short shortInt = short.Parse(input);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        static bool FitsInUshort(string input)
        {
            try
            {
                ushort ushortInt = ushort.Parse(input);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        static bool FitsInInt(string input)
        {
            try
            {
                int intInt = int.Parse(input);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        static bool FitsInUint(string input)
        {
            try
            {
                uint uintInt = uint.Parse(input);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        static bool FitsInLong(string input)
        {
            try
            {
                long longInt = long.Parse(input);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}
