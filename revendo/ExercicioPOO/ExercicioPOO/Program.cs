
/*
EXERCÍCIO 01:
-------------------------------------------------------------------------------------------------
Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais velha.
-------------------------------------------------------------------------------------------------
Exemplo:
Dados da primeira pessoa:
Nome: Maria
Idade: 17
Dados da segunda pessoa:
Nome: Joao
Idade: 16
Pessoa mais velha: Maria
 */


using System;

namespace ExercicioPOO { 
    class Program
    {
        static void Main(string[] args)
        {

            Pessoa pessoa1, pessoa2;
            pessoa1 = new Pessoa();
            pessoa2 = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            pessoa1.nome = Console.ReadLine();

            Console.Write("Idade: ");
            pessoa1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            pessoa2.nome = Console.ReadLine();

            Console.Write("Idade: ");
            pessoa2.idade = int.Parse(Console.ReadLine());

            if (pessoa1.idade > pessoa2.idade)
            {
                Console.WriteLine("Pessoa mais velha: " + pessoa1.nome);
            } else
            {
                Console.WriteLine("Pessoa mais velha: " + pessoa2.nome);
            }
        }
    }
}

