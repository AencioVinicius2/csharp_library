using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            double cotacaoDoDolar, dolarComprado, result;

            Console.Write("Qual a cotação do dolar? ");
            cotacaoDoDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? ");
            dolarComprado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            result = ConversorDeMoeda.DolarParaReal(cotacaoDoDolar, dolarComprado);

            Console.Write("Valor a ser pago em reais = " + result.ToString("F2", CultureInfo.InvariantCulture));
        }

    }
}