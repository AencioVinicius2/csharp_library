using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args) { 

            DateTime d1 = DateTime.Now;

            DateTime d2 = new DateTime(2018, 11, 25);

            DateTime d3 = new DateTime(2022, 05, 03, 20, 45, 11);

            DateTime d4 = DateTime.Today;

            DateTime d5 = DateTime.UtcNow;

            DateTime d6 = DateTime.Parse("2000-08-15");

            DateTime d7 = DateTime.Parse("2000-08-15 13:05:58");

            DateTime d8 = DateTime.Parse("15/05/08 13:05:58");

            DateTime d9 = DateTime.ParseExact("2000-08-15,", "yyyy-MM-dd", CultureInfo.InvariantCulture);

            DateTime d10 = DateTime.ParseExact("15/08/2000 13:05:02", "MM-dd-yyyy HH:mm:ss", CultureInfo.InvariantCulture);


            Console.WriteLine(d1);
            Console.WriteLine(d1.Ticks);

            


        }
    }
}