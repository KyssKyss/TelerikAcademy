using System;

/* Write a program that shows the internal binary representation of given 32-bit signed floating-point number in IEEE 754 format
 * (the C# type float). Example: -27,25  sign = 1, exponent = 10000011, mantissa = 10110100000000000000000. */

namespace FloatToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Set the first bit if == 1 -> '-'
            // TODO: Next 8 bits of exponent (10000001 => 2^0 + 2^7 + 128) = number, p = number - 127
            // TODO: Mantisa  M = 1 + bit^-i
            // TODO: R = M * 2^p
            string str = "";
        }
    }
}
