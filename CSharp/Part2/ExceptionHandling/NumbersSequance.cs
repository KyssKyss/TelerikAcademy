using System;
using System.Threading.Tasks;

/* Write a method ReadNumber(int start, int end) that enters an integer number in given
range [start…end]. If an invalid number or non-number text is entered, the method should throw an 
exception. Using this method write a program that enters 10 numbers:
a1, a2, … a10, such that 1 < a1 < … < a10 < 100 */

namespace NumberSequance
{
    class NumbersSequance
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Write the starting number:");
                int start = int.Parse(Console.ReadLine());
                Console.WriteLine("Write the ending number:");
                int end = int.Parse(Console.ReadLine());
                Console.WriteLine("Write 10 numbers in the range of {0} - {1}", start, end);
                for (int i = 0; i < 10; i++)
                {
                    ReadNumber(start, end);
                }                
            }
            catch (FormatException)
            {

                Console.WriteLine("Non-number or invalid number!");
            }
            
        }
        static void ReadNumber(int start, int end)
        {
            try
            {
                int number = int.Parse(Console.ReadLine());
                if (number < start && number > end  || number < start || number > end)
                {
                    throw new FormatException();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Non-number or invalid number!");
            }            
        }
    }
}
