using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/* 10. Write a program that extracts from given XML file all the text without the tags. */

namespace ExtractFromXML
{
    class ExtractFromXML
    {
        static List<string> temp = new List<string>();
        static Encoding encodingCyr = Encoding.GetEncoding(1251);
        static string path = @"../../Text.xml";
        static void Main()
        {
            try
            {
                StreamReader stReader = new StreamReader(path, encodingCyr);
                using (stReader)
                {
                    string lineString = "";
                    bool letter = false;
                    int line = stReader.Read();
                    while (line != -1)
                    {
                        if (line == '>')
                        {
                            letter = true;
                        }
                        if (line == '<')
                        {
                            letter = false;
                        }
                        if (letter && line != '>' && line != '\r' && line != '\n')
                        {
                            lineString += ((char)(line)).ToString();
                        }
                        line = stReader.Read();
                    }
                    foreach (var item in lineString)
                    {
                        Console.Write("{0}",item);
                    }
                    Console.WriteLine();
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file could not be found!");
            }
        }
    }
}
