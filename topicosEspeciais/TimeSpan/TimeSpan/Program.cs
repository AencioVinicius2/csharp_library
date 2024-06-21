using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {                             // HH, MM, SS
            TimeSpan t1 = new TimeSpan(0, 1, 30);

            TimeSpan t2 = new TimeSpan(9000000000L);

            TimeSpan t3 = new TimeSpan(2, 11, 21);

            TimeSpan t4 = new TimeSpan(1, 2, 11, 21);

            TimeSpan t5 = TimeSpan.FromDays(1.5);

            TimeSpan t6 = TimeSpan.FromHours(1.5);

            TimeSpan t7 = TimeSpan.FromMinutes(1.5);

            TimeSpan t8 = TimeSpan.FromSeconds(1.5);

            TimeSpan t9 = TimeSpan.FromMilliseconds(1.5);

            TimeSpan t10 = TimeSpan.FromTicks(900000000L);

            Console.WriteLine(t1);

            Console.WriteLine(t2);

            Console.WriteLine(t3);

            Console.WriteLine(t4);

        }
    }
}