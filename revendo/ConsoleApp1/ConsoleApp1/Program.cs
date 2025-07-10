using System;
using System.Globalization;

namespace ConsoleApp1 {
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo area = new Triangulo();

            double a, b, c;

            Console.WriteLine("Entre com as medidas do triangulo X");

             area.A = double.Parse(Console.ReadLine());
             area.B = double.Parse(Console.ReadLine());
             area.C = double.Parse(Console.ReadLine());

            Console.WriteLine("A area do triangulo x é " + area.Area().ToString("f4"), CultureInfo.InvariantCulture);

        }
    } 

}