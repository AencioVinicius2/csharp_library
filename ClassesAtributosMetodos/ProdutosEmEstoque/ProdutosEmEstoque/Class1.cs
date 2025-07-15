using System;
using System.Globalization;

namespace Course
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AtualizaProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;   
        }

        public override string ToString()
        {
            return Nome + " $ " + Preco.ToString("F2", CultureInfo.InvariantCulture) + " " + ValorTotalEmEstoque();
        }


    }
}
