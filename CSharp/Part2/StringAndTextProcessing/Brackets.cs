using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Write a program to check if in a given expression the brackets are put correctly.
 * Example of correct expression: ((a+b)/5-d).
 * Example of incorrect expression: )(a+b)).    */

namespace Brackets
{
    class Brackets
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a expression:");
            string expression = Console.ReadLine();
            int leftCounter = 0;
            int rightCounter = 0;
            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    leftCounter++;
                }
                if (expression[i] == ')')
                {
                    rightCounter++;
                }
            }
            if (leftCounter != rightCounter)
            {
                Console.WriteLine("Wrong number of brackets in the expression!");
            }
            else
            {
                Console.WriteLine("Correct!");
            }
        }
    }
}
