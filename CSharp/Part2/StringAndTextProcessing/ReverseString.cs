using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Write a program that reads a string, reverses it and prints the result at the console.
 *              Example: "sample" -> "elpmas".          */

namespace ReversString
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a word:");
            string word = Console.ReadLine();
            StringBuilder reverse = new StringBuilder();
            for (int i = word.Length - 1; i >= 0; i--)
            {
                reverse.Append(word[i]);
            }
            Console.WriteLine("The reverse word is:\n{0}",reverse);
        }
    }
}
