using ModificadorParams;
using System;

namespace ModificdorParams
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1 = Calculator.Sum(new int[] {1, 2, 3});
            int s2 = Calculator.Sum(new int[] { 1, 2, 3, 4 });
        }
    }
}