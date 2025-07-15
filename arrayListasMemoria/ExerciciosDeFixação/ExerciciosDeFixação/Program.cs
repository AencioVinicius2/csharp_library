using System;

namespace Course
{
    class Program {
        static void Main(string[] args)
        {
            int nQuartos = 0;

            Quartos[] vect = new Quartos[10];

            Console.Write("Quantos quartos serão alugados? ");
            nQuartos = int.Parse(Console.ReadLine());

            for(int i = 0; i < nQuartos; i++)
            {
                Console.WriteLine();

                Console.WriteLine("Aluguel #"+(i+1)+":");

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                vect[quarto] = new Quartos { Nome = nome, Email = email, Quarto = quarto };
            }

            Console.WriteLine();

            Console.WriteLine("Quartos ocupados:");

            for (int i = 0; i < vect.Length; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(vect[i].Quarto + ":" + vect[i].Nome + ", " + vect[i].Email);
                }  
            }


        }
    }
}