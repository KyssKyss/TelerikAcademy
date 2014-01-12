using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/* Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file. */

namespace SortFile
{
    class SortFile
    {
        static List<string> names = new List<string>();
        static void Main(string[] args)
        {
            try
            {
                Encoding cyr = Encoding.GetEncoding(1251);
                StreamReader stReader = new StreamReader("List.txt", cyr);
                StreamWriter stWriter = new StreamWriter(@"../../SortedList.txt", false, cyr);

                using (stReader)
                {
                    string line = stReader.ReadLine();
                    while (line != null)
                    {
                        names.Add(line);
                        line = stReader.ReadLine();
                    }
                }
                using (stWriter)
                {
                    names.Sort();
                    foreach (var item in names)
                    {
                        stWriter.WriteLine(item);
                    }
                    Console.WriteLine("Sorted complete!");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message); ;
            }
        }
    }
}
