using System;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/* Write a program that reads a text file containing a square matrix of numbers and finds in the matrix
 * an area of size 2 x 2 with a maximal sum of its elements. The first line in the input file contains the size of matrix N. 
 * Each of the next N lines contain N numbers separated by space. The output should be a single number in a separate text file. */

namespace SumInMatrix
{
    class SumInMatrix
    {
        static void Main(string[] args)
        {
            try
            {
                StreamReader stReader = new StreamReader("Matrix.txt");
                StreamWriter stWriter = new StreamWriter(@"../../Result.txt");
                int maxSum = 0;
                using (stReader)
                {
                    string lineNumber = stReader.ReadLine();
                    int n = int.Parse(lineNumber);
                    int[,] matrix = new int[n, n];
                    string line = stReader.ReadLine();
                    // populate the matrix
                    while (line != null)
                    {
                        for (int row = 0; row < n; row++)
                        {
                            string[] rows = line.Split(' ');
                            for (int col = 0; col < n; col++)
                            {
                                matrix[row, col] = int.Parse(rows[col]); 
                            }
                            line = stReader.ReadLine();
                        }
                    }
                    // find max sum                    
                    for (int row = 0; row < n - 1; row++)
                    {
                        for (int col = 0; col < n - 1; col++)
                        {
                            int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                            if (maxSum < sum)
                            {
                                maxSum = sum;
                            }
                        }
                    }
                }
                // write result in the new file
                using (stWriter)
                {
                    stWriter.WriteLine(maxSum);
                    Console.WriteLine("Complete!");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message); ;
            }
        }
    }
}
