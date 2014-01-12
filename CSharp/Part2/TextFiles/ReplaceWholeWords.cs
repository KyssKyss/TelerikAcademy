using System;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/* Modify the solution of the previous problem to replace only whole words (not substrings). */


namespace ReplaceWords
{
    class ReplaceWords
    {
        static string fileName = @"sample.txt";
        static string resultFile = @"../../Result.txt";

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the replacing word:");
            string word = Console.ReadLine();
            Console.WriteLine("Enter the word that will be replaced:");
            string replaced = Console.ReadLine();
            Replace(word, replaced);
        }
        private static void Replace(string word, string replaced)
        {
            try
            {
                StreamReader stReader = new StreamReader(fileName);
                StreamWriter stWriter = new StreamWriter(resultFile);
                string result = "";
                try
                {
                    string line = stReader.ReadLine(); // we use ReadLine() to ensure we can read files bigger than 100MB
                    while (line != null)
                    {
                        int startIndex = line.IndexOf(word);
                        string replacedFrom = line.Substring(0, startIndex);
                        string replacedTo = line.Substring(startIndex + word.Length);
                        if (replacedTo[0] == ' ')
	                    {
		                    result = replacedFrom + replaced + replacedTo;
                            stWriter.WriteLine(result);
	                    }
                        else
                        {
                            stWriter.WriteLine(line);
                        }    
                        line = stReader.ReadLine();
                    }
                    Console.WriteLine("Complete!");
                }
                finally
                {
                    stReader.Close();
                    stWriter.Close();
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
