using System;
using System.Globalization;

namespace Delegacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            produto.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            produto.Preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade no estoque: ");
            produto.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto: " + produto);

            Console.WriteLine();

            Console.Write("Digite o número de produtos a serem adicionados: ");
            int qtd = int.Parse(Console.ReadLine());
            produto.AdicionarProdutos(qtd);
            Console.WriteLine();

            Console.WriteLine("Dados atualizados: " + produto);

            Console.Write("Digite o número de produtos a serem removidos: ");
            int rm = int.Parse(Console.ReadLine());
            produto.RemoverQuantidade(rm);
            Console.WriteLine();

            Console.WriteLine("Dados atualizados: " + produto);





        }
    }
}