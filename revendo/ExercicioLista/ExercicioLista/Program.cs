using System;
using System.Globalization;
using System.Collections.Generic;

namespace ExercicioLista
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int id;
            double percent;

            List<Employee> employees = new List<Employee>();


            Console.Write("How many employees will be registred? ");

            n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Employee #"+(1+i).ToString()+":");
                Console.Write("Id: ");
                int idEmployee = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                employees.Add(new Employee { Id = idEmployee, Name = name, Salary = salary});

                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will have salary increase: " );    
            id = int.Parse(Console.ReadLine());
            if(employees.Find(x => x.Id == id) != null )
            {
                Console.Write("Enter the percentage: ");
                percent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                employees.Find(x => x.Id == id).IncreaseSalary(percent);

            } else
            {
                Console.Write("This ID doesn't have any match.");
            }

            Console.WriteLine();

            Console.WriteLine("Updated list of employees:");
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
            }

        }
    }
}