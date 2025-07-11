using System;
using System.Globalization;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double dolares, cotDoll;
            Console.Write("Qual a cotação do dolar? ");
            cotDoll = double.Parse(Console.ReadLine());

            Console.Write("Quantos dólares você vai comprar? ");
            dolares = double.Parse(Console.ReadLine());

            Console.WriteLine("Valor a ser pago em reais: " + ConversorDeMoedas.CalculaConversao(dolares, cotDoll).ToString("F2", CultureInfo.InvariantCulture));



        }
    }
}