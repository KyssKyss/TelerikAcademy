using System;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/* Write a program that reads a text file and inserts line numbers in front of each of its lines.
 * The result should be written to another text file. */

namespace LineNumbers
{
    class LineNumbers
    {
        static void Main(string[] args)
        {
            Encoding cyr = Encoding.GetEncoding(1251);
            StreamReader stReader = new StreamReader("File.txt",cyr);
            StreamWriter stWriter = new StreamWriter(@"../../result.txt", false, cyr);
            try
            {
                string line = stReader.ReadLine();
                string result = "";
                int lineCounter = 0;
                try
                {
                    while (line != null)
                    {
                        lineCounter++;
                        result = lineCounter + ". " + line;
                        stWriter.WriteLine(result);
                        line = stReader.ReadLine();

                    }
                }
                finally
                {
                    Console.WriteLine("Complеte!");
                    stReader.Close();
                    stWriter.Close();
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }
        }
    }
}
