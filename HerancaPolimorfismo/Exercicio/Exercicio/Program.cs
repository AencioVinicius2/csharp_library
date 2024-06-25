using System;
using System.Collections.Generic;
using Course.Entities;
using Exercicio.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.Write("Enter the number of employess");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Employee number #{i} data:");
                Console.Write("Outsourced (y/n)? ");
            }

        }
    }
}