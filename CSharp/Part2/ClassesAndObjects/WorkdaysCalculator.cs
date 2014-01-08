using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkdaysCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;
            DateTime futureDay = new DateTime(2014, 01, 12);
            int count = 0;
            while (today < futureDay)
            {
                if (today.DayOfWeek == DayOfWeek.Saturday || today.DayOfWeek == DayOfWeek.Sunday || today.Day == 10)
                {
                    count++;
                }
                today = today.AddDays(1);
            }
            today = DateTime.Now;
            int result  = (int)((futureDay - today).TotalDays) - count;
            Console.WriteLine(result);
        }
        private static int Holydays()
        {
        }
    }
}
