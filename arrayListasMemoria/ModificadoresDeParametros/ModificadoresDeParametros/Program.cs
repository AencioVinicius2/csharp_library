using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args) {
            int a = 10;
            int b;

             Calculadora.Triple(ref a);

            Calculadora.TripleOut(a, out b);

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}