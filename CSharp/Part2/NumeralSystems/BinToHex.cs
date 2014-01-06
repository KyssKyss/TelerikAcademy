using System;

/* Write a program to convert binary numbers to hexadecimal numbers (directly). */

namespace BinToHex
{
    class BinToHex
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a number in binary form:");
            string binary = Console.ReadLine();
            string[] tempArr = new string[binary.Length];
            string result = "";
            for (int i = 0; i < binary.Length; i += 4)
            {
                for (int j = i; j < i + 4; j++)
                {
                    tempArr[i] += binary[j];
                }
            }
            foreach (var item in tempArr)
            {
                result += ToHex(item);
            }
            Console.WriteLine("The number in hexadecimal form is 0x{0}", result);
        }
        private static string ToHex(string s)
        {
            string hex = "";
            switch (s)
            {
                case "0000":
                    hex = "0";
                    break;
                case "0001":
                    hex = "1";
                    break;
                case "0010":
                    hex = "2";
                    break;
                case "0011":
                    hex = "3";
                    break;
                case "0100":
                    hex = "4";
                    break;
                case "0101":
                    hex = "5";
                    break;
                case "0110":
                    hex = "6";
                    break;
                case "0111":
                    hex = "7";
                    break;
                case "1000":
                    hex = "8";
                    break;
                case "1001":
                    hex = "9";
                    break;
                case "1010":
                    hex = "A";
                    break;
                case "1011":
                    hex = "B";
                    break;
                case "1100":
                    hex = "C";
                    break;
                case "1101":
                    hex = "D";
                    break;
                case "1110":
                    hex = "E";
                    break;
                case "1111":
                    hex = "F";
                    break;
                default:
                    break;
            }

            return hex;
        }
    }
}

