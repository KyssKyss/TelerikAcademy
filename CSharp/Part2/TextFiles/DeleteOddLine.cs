using System;
using System.Text;
using System.Data;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.IO;

/* Write a program that deletes from given text file all odd lines. The result should be in the same file. */

namespace PrintOddLines
{
    class PrintOddLines
    {
        static List<string> temp = new List<string>();
        static Encoding encodingCyr = Encoding.GetEncoding(1251);
        static void Main(string[] args)
        {
            try
            {
                StreamReader streamReader = new StreamReader("SomeText.txt", encodingCyr);
                using (streamReader) 
                {
                    string line = streamReader.ReadLine();
                    int lineCounter = 1;
                    while (line != null)
                    {
                        if (lineCounter % 2 == 1)
                        {
                            temp.Add(line);
                        }
                        lineCounter++;
                        line = streamReader.ReadLine();
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            } 
            try
            {
                StreamWriter stWriter = new StreamWriter(@"../../SomeText.txt", false, encodingCyr);
                using (stWriter)
                {
                    foreach (var item in temp)
                    {
                        stWriter.WriteLine(item);
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
