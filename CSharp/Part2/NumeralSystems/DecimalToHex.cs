using System;

/* Write a program to convert decimal numbers to their hexadecimal representation. */

namespace DecimalToHex
{
    class DecimalToHex
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a number:");
            int number = int.Parse(Console.ReadLine());
            string result = "";
            //// using .net methods
            //string hexNumber = Convert.ToString(number, 16);
            //Console.WriteLine("It representive hexadecimal form is: {0}", hexNumber);
            while (number != 0)
            {
                int reminder = number % 16;
                if (reminder > 9)
                {
                    result += HexadecimalReminder(reminder, result);
                }
                else
                {
                    result += reminder;
                }
                number /= 16;
            }
            result = ReverseString(result);
            Console.WriteLine("It representive hexadecimal form is: {0}", result);
        }
        private static string HexadecimalReminder(int reminder, string result)
        {
            switch (reminder)
            {
                case 10:
                    result = "A";
                    break;
                case 11:
                    result = "B";
                    break;
                case 12:
                    result = "C";
                    break;
                case 13:
                    result = "D";
                    break;
                case 14:
                    result = "E";
                    break;
                case 15:
                    result = "F";
                    break;
                default:
                    break;
            }

            return result;
        }
        private static string ReverseString(string result)
        {
            char[] revString = result.ToCharArray();
            Array.Reverse(revString);

            return new string(revString);
        }
    }
}
