using System;

namespace Coruse
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vect = new string[] { "Maria", "Bob", "Alex" };

            foreach (var obj in vect)
            {
                Console.WriteLine(obj);
            }
        }
    }
}