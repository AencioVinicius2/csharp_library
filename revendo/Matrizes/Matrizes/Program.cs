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


            Console.WriteLine("Main diagonal:");
            for(int i = 0; i < n; i++)
            {
                Console.Write(mat[i,i] + " ");
            }
            Console.WriteLine();

            int count;

            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if (mat[i,j] < 0)
                    {
                        i++;
                    }
                }
            }



        }
    }
}