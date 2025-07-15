using System;
using System.Globalization;

namespace Course {
    class ProdEstoque
    {
        static void Main(string[] args)
        {
            Produto p1;

            p1 = new Produto();

            Console.WriteLine("Entre os dados do produto: ");

            Console.Write("Nome: ");
            p1.Nome = Console.ReadLine();

            Console.Write("Preço: ");
            p1.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade no estoque: ");
            p1.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados de produtos: "+p1);

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qtde = int.Parse(Console.ReadLine());
            p1.AtualizaProdutos(qtde);

            Console.WriteLine("Dados atualizados: "+p1);

            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qtde = int.Parse(Console.ReadLine());
            p1.RemoverProdutos(qtde);

            Console.WriteLine("Dados atualizados: "+p1);

        }
    }
}