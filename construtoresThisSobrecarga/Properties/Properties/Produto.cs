using System;

namespace Course
{
    internal class Produto
    {
        private string _nome;
        private double _preco;
        private int _quantidade;
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }
        public void setNome(string nome)
        {
            if (nome.Length < 1) return;
            _nome = nome;
        }

        public void SetQuantidade(int quantidade)
        {
            if (quantidade < 0) return;
            _quantidade = quantidade;
        }
        public string getNome()
        {
            return _nome;
        }

        public double getPreco()
        {
            return _preco;
        }

    }
}
