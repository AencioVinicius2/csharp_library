using System;

namespace Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.Write("Input: ");
            n = int.Parse(Console.ReadLine());

            double[,] mat = new double[n, n];

            for(int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');

                for(int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);


                }
            }






        }
    }
}