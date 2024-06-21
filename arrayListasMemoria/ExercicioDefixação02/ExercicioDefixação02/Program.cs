using System;
using System.Globalization;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;

            Console.Write("How many employees will be registered? ");

            n = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Employee #" + (i+1) +":");

                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine();

                list.Add(new Employee(id, name, salary));

            }

            Console.Write("Enter the employee id that will have salary increase: ");

            int searchId = int.Parse(Console.ReadLine());
            Employee emp = list.Find(x => x.Id == searchId);

            if (emp != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine());
                emp.IncreaseSalary(percentage);
                Console.WriteLine();
            } else
            {
                Console.WriteLine("This id does not exist");
                Console.WriteLine();
            }

            Console.WriteLine("Updated list of employees: ");

            foreach (var obj in  list) {
                Console.WriteLine(obj);
            }

        }
    }
}