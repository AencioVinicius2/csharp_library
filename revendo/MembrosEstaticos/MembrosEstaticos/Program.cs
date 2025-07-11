using System;
using System.Globalization;

namespace MembrosEstaticos
{
    class Program
    {
        static double Pi = 3.14;
        static void Main(string[] args)
        {

            Console.WriteLine("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine());

 
            double circ = Circunferencia(raio);
            double voçume = Voume(raio);


            Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + voçume.ToString("F2", CultureInfo.InvariantCulture));
        }

        static double Circunferencia(double raio)
        {
            return 2 * Pi * raio;
        }

        static double Voume (double raio)
        {
            return 4.0 / 3.0 * Pi * raio;
        }
    }
}