using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeralConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose convert FROM system:");
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter convert TO system:");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine("Write a number");
            string number = Console.ReadLine();

            if (s == 2 && d == 10)
            {
                //BinToDecimal
            }
            if (s == 2 && d == 16)
            {
                BinToHex(number);
            }
            if (s == 10 && d == 2)
            {
                int n = int.Parse(number);
                DecToBin(n);
            }
            if (s == 10 && d == 16)
            {
               int n = int.Parse(number); 
               string result = BinToHex(DecToBin(n));
               Console.WriteLine(result);
            }
            if (s == 16 && d == 2)
            {
                //HexToBin();
            }
            if (s == 16 && d == 10)
            {
                //HexToDecimal
            }
        }
        private static string HexToBin(string hexNumber)
        {
            //Console.WriteLine("Write the hexidecimal number:");
            //Console.Write("0x");
            //hexNumber = Console.ReadLine();
            string binNumber = "";
            foreach (var item in hexNumber)
            {
                binNumber += ToBinary(item.ToString());
            }
            //Console.WriteLine("Number in binary format: {0}",binNumber);

            return binNumber;
        }
        private static string ToBinary(string s)
        {
            string bin = "";
            switch (s)
            {
                case "0":
                    bin = "0000";
                    break;
                case "1":
                    bin = "0001";
                    break;
                case "2":
                    bin = "0010";
                    break;
                case "3":
                    bin = "0011";
                    break;
                case "4":
                    bin = "0100";
                    break;
                case "5":
                    bin = "0101";
                    break;
                case "6":
                    bin = "0110";
                    break;
                case "7":
                    bin = "0111";
                    break;
                case "8":
                    bin = "1000";
                    break;
                case "9":
                    bin = "1001";
                    break;
                case "A":
                    bin = "1010";
                    break;
                case "B":
                    bin = "1011";
                    break;
                case "C":
                    bin = "1100";
                    break;
                case "D":
                    bin = "1101";
                    break;
                case "E":
                    bin = "1110";
                    break;
                case "F":
                    bin = "1111";
                    break;
                default:
                    break;
            }

            return bin;
        }
        private static string BinToHex(string binary)
        {
            //Console.WriteLine("Write a number in binary form:");
            //string binary = Console.ReadLine();
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
                if (ToHex(item) != "0")
                {
                   result += ToHex(item); 
                }                
            }
            //Console.WriteLine("The number in hexadecimal form is 0x{0}", result);

            return result;
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
        private static string DecToBin(int number)
        {
            //Console.WriteLine("Write a number :");
            //int number = int.Parse(Console.ReadLine());
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
                     toArray = string.Join("", binaryNumber);
                }
                else if (number > 0)
                {
                    binaryNumber[i] = number % 2;
                    toArray = string.Join("", binaryNumber);
                }
                number /= 2;
            }            
            //Console.WriteLine("Its representive binary form is: \n{0}",toArray);

            return toArray;
        }
        private static void BinToDec(string s)
        {
            //TODO Copy the method
        }
    }
}
