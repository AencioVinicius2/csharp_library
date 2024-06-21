using System;

namespace Course {
    class Program
    {
        static void Main(string[] args) {
            double? x = null;
            double? y = 10;

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());
        }
    }
}