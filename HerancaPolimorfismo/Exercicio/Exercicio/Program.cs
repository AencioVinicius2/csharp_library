using System;
using System.Globalization;
using System.Collections.Generic;
using Course.Entities;
using Exercicio.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.Write("Enter the number of employess");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Employee number #{i} data:");
                Console.Write("Outsourced (y/n)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(ch == 'y')
                {
                    Console.Write("Additional charge: ");
                    double addiTionalCharge = double.Parse((string) Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutsourcedEmployee(name, hours, valuePerHour, addiTionalCharge));
                } else
                {
                    list.Add(new Employee(name, hours, valuePerHour));
                }

                Console.WriteLine();
                Console.WriteLine("PAYMENTS: ");
                
                foreach(Employee emp in list)
                {
                    Console.WriteLine(emp.Name + " - $ " + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
                }
            }

        }
    }
}