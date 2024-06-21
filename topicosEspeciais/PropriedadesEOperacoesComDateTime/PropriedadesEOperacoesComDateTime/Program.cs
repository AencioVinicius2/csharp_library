using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d = new DateTime(2002, 12, 01, 20, 30, 43, 123);

            Console.WriteLine(d);
            Console.WriteLine("1) Date: " + d.Date);
            Console.WriteLine("2) Day: " + d.Day);
            Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
            Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
            Console.WriteLine("5) Hour: " + d.Hour);
            Console.WriteLine("6) Kind: " + d.Kind);
            Console.WriteLine("7) Millisecond: " + d.Millisecond);
            Console.WriteLine("8) Minute: " + d.Minute);
            Console.WriteLine("9) Month: " + d.Month);
            Console.WriteLine("10) Second: " + d.Second);
            Console.WriteLine("11) Ticks: " + d.Ticks);
            Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
            Console.WriteLine("13) Year: " + d.Year);

            string d1 = d.ToLongDateString();

            string d2 = d.ToLongDateString();

            string d3 = d.ToString("yyyy-MM-dd HH:mm:ss:fff");

            string d4 = d.ToString();

            DateTime d5 = d.AddHours(2);

            DateTime d6 = new DateTime(2000, 10, 18);

            DateTime d7 = new DateTime(2000, 10, 21);

            TimeSpan interval = d7.Subtract(d6);

            Console.WriteLine(d1);
            Console.WriteLine(interval);
        }
    }
}