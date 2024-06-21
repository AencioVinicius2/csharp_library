using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Boxing é o processo de conversão de um objeto tipo valor para um objeto tipo referência compatível 
            */

            int x = 20;
  
            Object obj = x;

            /*
             Unboxing é o processo de conversão de um objeto tipo referência para um objeto tipo valor compatível
            */

            int a = 20;

            Object obj2 = a;

            int b = (int) obj;

        }
    }
}