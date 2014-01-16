using System;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.ComponentModel;

/* Write a program that downloads a file from Internet (e.g. http://www.devbg.org/img/Logo-BASD.jpg) 
 * and stores it the current directory. Find in Google how to download files in C#. Be sure to catch all
 * exceptions and to free any used resources in the finally block. */

namespace DownloadFile
{
    class DownloadFile
    {
        static string path = @"../../Downloads/Logo_BASD.jpg";
        static string url = "";
        static void Main(string[] args)
        {   
            WebClient webClient = new WebClient();
            Console.WriteLine("Please enter a url:");
            try
            {
                string url = Console.ReadLine();
                webClient.DownloadFile(new Uri(url), path);
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Please enter some URL");
            }
            catch (WebException)
            {
                Console.WriteLine("Invalid address or empty file!");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("The method has been called simultaneously on multiple threads.");
            }
            catch (UriFormatException)
            {
                Console.WriteLine("The URL is not valid or contains not allowed symbols: #$%^&* !");
            }
            finally
            {
                webClient.Dispose();
            }
           
        }
    }
}
