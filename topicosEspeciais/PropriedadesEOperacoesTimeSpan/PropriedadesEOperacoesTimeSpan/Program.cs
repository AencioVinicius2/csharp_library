using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);
            TimeSpan t2 = new TimeSpan(1, 30, 10);
            TimeSpan t3 = new TimeSpan(0, 10, 5);

            TimeSpan sum = t2 + t3;

            TimeSpan mult = sum.Multiply(2);
            
            TimeSpan div = mult.Divide(2);

            Console.WriteLine(t);

            Console.WriteLine("Days: " + t.Days);
            Console.WriteLine("Hours: " + t.Hours);
            Console.WriteLine("Minutes: " + t.Minutes);
            Console.WriteLine("Milliseconds: " + t.Milliseconds);
            Console.WriteLine("Seconds: " + t.Seconds);
            Console.WriteLine("Ticks: " + t.Ticks);

            Console.WriteLine();

            Console.WriteLine("Total Days: " + t.TotalDays);
            Console.WriteLine("Total Hours: " + t.TotalHours);
            Console.WriteLine("Total Minutes: " + t.TotalMinutes);
            Console.WriteLine("Total Seconds: " + t.TotalSeconds);
            Console.WriteLine("Total Milliseconds: " + t.TotalMilliseconds);

            Console.WriteLine();

            Console.WriteLine(sum);

        }
    }
}