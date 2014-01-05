using System;

/* Write a program to convert decimal numbers to their binary representation. */

namespace DecimalToBinary
{
    class DecimalToBinary
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a number :");
            int number = int.Parse(Console.ReadLine());
            //// using .net methods
            //Console.Write("Its representive binary form is: ");
            //Console.WriteLine(Convert.ToString(number,2).PadLeft(32,'0'));
            int[] binaryNumber = new int[32];
            if (number < 0)
            {
                for (int i = 0; i < binaryNumber.Length; i++)
                {
                    binaryNumber[i] = 1;
                }
            }
            string toArray = "";
            for (int i = binaryNumber.Length - 1; i >= 0; i--)
            {
                if (number < 0) // if the number is negative reverse the numbers in the array except last bit
                {
                    if (number % 2 != -1 || i == binaryNumber.Length - 1) 
	                {
		                binaryNumber[i] = 1;
	                }
                    else
                    {
                        binaryNumber[i] = 0;
                    }                     
                     toArray = string.Join(" ", binaryNumber);
                }
                else if (number > 0)
                {
                    binaryNumber[i] = number % 2;
                    toArray = string.Join(" ", binaryNumber);
                }
                number /= 2;
            }            
            Console.WriteLine("Its representive binary form is: \n{0}",toArray);
        }
    }
}
