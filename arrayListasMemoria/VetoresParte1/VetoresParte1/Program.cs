using System;
using System.Globalization;

namespace Course {
    class Program {
     static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 0.0;

            double[] vect = new double[n];

            for (int i = 0; i < n; i++)
            {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }


            for(int i = 0; i < vect.Length; i++)
            {
                sum += vect[i];
            }

            double avg = sum / n;
        }
    }
}