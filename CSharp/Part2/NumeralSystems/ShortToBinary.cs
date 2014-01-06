using System;

/* Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short). */

namespace ShortToBinary
{
    class ShortToBinary
    {
        static void Main(string[] args)
        {
            short shortNumber = 23423;
            string binNumber = "";
            while (shortNumber != 0)
            {
                binNumber += shortNumber % 2;
                shortNumber /= 2;
            }
            string result = string.Join(" ", ReverseString(binNumber));
            Console.WriteLine("The number in binary: \n{0}", result);
        }
        private static char[] ReverseString(string s)
        {
            char[] str = s.ToCharArray();
            Array.Reverse(str);

            return str;
        }
    }
}
