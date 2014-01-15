using System;
using System.Threading.Tasks;

/* 1. Write a program that reads an integer number and calculates and prints its square root. If the number 
is invalid or negative, print "Invalid number". In all cases finally print "Good bye". Use try-catch-finally. */

namespace SquareOfNumber
{
    class SquareOfNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a number: ");
            try
            {
                int number = int.Parse(Console.ReadLine());
                if (number < 0)
                {
                    throw new FormatException();
                }
                double result = Math.Sqrt(number);
                Console.WriteLine("The square root of number {0} is {1}.",number,result);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye!");
            }
        }
    }
}
