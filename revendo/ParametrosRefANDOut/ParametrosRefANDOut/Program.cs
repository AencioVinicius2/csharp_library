using System;

namespace ParametrosRefANDOut
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int triple;
                               // passando o valor original como referencia // out = valor do resultado (nao precisa ser iniciado com algum valor)
            Calculadora.Triple(ref a, out triple);
            Console.WriteLine(a);
        }
    }
}