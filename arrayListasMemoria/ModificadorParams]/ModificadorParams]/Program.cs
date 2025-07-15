using System;

namespace Course { 
    class Program
    {
        static void Main(string[] args)
        {
            int s1 = Calculator.Sum(2, 3, 4, 5, 6, 7, 8, 9);
            Console.Write("Resultado: ");
            Console.Write(s1);
        }
    }
}