using System;
using System.Globalization;

namespace ConsoleApp1 {
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();


            Console.WriteLine("Entre com as medidas do triangulo X");
            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com as medidas do triangulo Y");
            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());

            Console.WriteLine("A area do triangulo X é " + x.Area().ToString("f4"), CultureInfo.InvariantCulture);
            Console.WriteLine("A area do triangulo Y é " + y.Area().ToString("f4"), CultureInfo.InvariantCulture);

            if(x.Area() > y.Area())
            {
                Console.WriteLine("Maior area X");
            } else
            {
                Console.WriteLine("Maior area Y");
            }

        }
    } 

}