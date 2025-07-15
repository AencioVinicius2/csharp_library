using ExercicioDeFixacao.Entities;
using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            Product product = new Product();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Product #" + (i + 1) + " data:");
                Console.WriteLine("Coomon, used or imported? (c/u/i)?");
                char type = char.Parse(Console.ReadLine());

                if (type == 'c')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine());

                }
                else if (type == 'u')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine());
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manuFacDate = DateTime.Parse(Console.ReadLine());

                }
                else if (type == 'i')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine());
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine());

                }
            }
        }
    }
}