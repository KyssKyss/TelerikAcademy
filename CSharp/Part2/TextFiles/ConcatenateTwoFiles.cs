using System;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/* Write a program that concatenates two text files into another text file. */

namespace ConcatenateTwoFiles
{
    class ConcatenateTwoFiles
    {
        static void Main(string[] args)
        {
            Encoding cyr = Encoding.GetEncoding(1251);
            StreamReader stReader1 = new StreamReader("TextFile1.txt",cyr);
            StreamReader stReader2 = new StreamReader("TextFile2.txt", cyr);
            StreamWriter stWriter = new StreamWriter("../../resultFile.txt",false,cyr);

            try
            {
                string readOne = stReader1.ReadToEnd();
                string readTwo = stReader2.ReadToEnd();
                try
                {
                    stWriter.Write(readOne);
                    stWriter.Write("\r\n"); // new line
                    stWriter.Write(readTwo);
                    Console.WriteLine("Concatenate succesful!");
                }
                finally
                {
                    stReader1.Close();
                    stReader2.Close();
                    stWriter.Close();
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex); ;
            }
        }
    }
}
