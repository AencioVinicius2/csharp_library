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
        // atributos privados 
        // propriedades autoimplementadas
        // construtores
        // propriedades customizadas
        // outros metodos da classe

        private string _nome; 
        private double _preco;
        private int _quantidade;

        public Produto()
        {

        }
        public Produto(string nome, double preco, int quantidade)
        {

            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }


        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        public double Preco
        {
            get { return _preco; }
            set
            {
                if (value != 0)
                {
                    _preco = value;
                }
            }
        }

        public int Quantidade
        {
            get { return _quantidade; }
            set
            {
                if (value != 0)
                {
                    _quantidade = value;
                }
            }
        }


        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }


        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }

        public void RemoverQuantidade(int quantidade)
        {
            _quantidade -= quantidade;
        }

         
        public override string ToString()
        {
            return _nome
                + ", $ "
                + _preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + _quantidade
                + " unidades, Total: $ "
                + (_preco * _quantidade).ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}