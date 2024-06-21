using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void main(string[] args)
        {
            Produto p = new Produto("TV", 500.00, 10);

            Console.WriteLine(p.getNome());
        }
    }
}