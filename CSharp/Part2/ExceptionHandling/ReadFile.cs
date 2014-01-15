using System;
using System.Threading.Tasks;
using System.IO;

/* Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its
 * contents and prints it on the console. Find in MSDN how to use System.IO.File.ReadAllText(…).
 * Be sure to catch all possible exceptions and print user-friendly error messages. */

namespace ReadFile
{
    class ReadFile
    {
        static string path;
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Write a file path:");
                path = Console.ReadLine();
                string content = File.ReadAllText(path);
                Console.WriteLine(content);
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("The path format is not in correct!");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file on dir: {0} could not be found!", path);
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("The input path was too long to be handle by your OS!");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("You dont have access to this file, or its unsupported by your OS!");
            }
            catch (IOException)
            {
                Console.WriteLine("Couldn't connect, possible I/O error!");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Path string content space or invalid characters like (@,!,-,$)!");
            }
        }
    }
}
