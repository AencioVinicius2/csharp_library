using System;
using System.Globalization;

namespace MembrosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {   

            Console.Write("Entre o valor do raio: ");

            double raio = double.Parse(Console.ReadLine());

            Console.WriteLine("Circunferência: " + Calculadora.Circunferencia(raio).ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + Calculadora.Volume(raio).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}