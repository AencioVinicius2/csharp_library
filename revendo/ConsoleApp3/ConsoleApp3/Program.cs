using System;

namespace ExercicioVetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int nQuartos = 0;

            Quarto[] quartos = new Quarto[10];

            Console.Write("Quantos quartos serão alugados? ");

            nQuartos = int.Parse(Console.ReadLine());

            for(int i = 0; i < nQuartos; i++)
            {
                Console.WriteLine("Aluguel #" + (i+1).ToString());
                Console.Write("Nome: "); 
                string nome = Console.ReadLine();
                Console.Write("E-mail: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                quartos[i] = new Quarto { Nome = nome, Email = email, QuartoId = quarto };

                Console.WriteLine();
            }

            Console.WriteLine("Quartos ocupados: ");

            for(int i = 0; i < nQuartos; i++)
            {
                if (!(quartos[i].QuartoId is Nullable))
                {
                    Console.WriteLine((i + 1).ToString() + ": " + quartos[i].Nome + ", " + quartos[i].Email);
                }
            }
            


        }
    }
}