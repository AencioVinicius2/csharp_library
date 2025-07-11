using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegacao
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

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverQuantidade(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return Nome 
                + ", $ " 
                +  Preco.ToString("F2", CultureInfo.InvariantCulture) 
                +", " 
                + Quantidade
                + " unidades, Total: $ " 
                + (Preco * Quantidade).ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
