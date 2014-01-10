using System;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/* Write a program that reads a text file and prints on the console its odd lines. */

namespace PrintOddLines
{
    class PrintOddLines
    {
        static void Main(string[] args)
        {
            try
            {
                Encoding encodingCyr = Encoding.GetEncoding(1251);
                StreamReader streamReader = new StreamReader("someText.txt", encodingCyr);                
                try
                {
                    string line = streamReader.ReadLine();
                    int lineCounter = 1;
                    while (line != null)
                    {                        
                        if (lineCounter % 2 == 1)
                        {
                            Console.WriteLine(line);
                        }
                        lineCounter++;
                        line = streamReader.ReadLine();
                    }
                }
                finally
                {
                    streamReader.Close();
                }
            }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }         
        }
    }
}
