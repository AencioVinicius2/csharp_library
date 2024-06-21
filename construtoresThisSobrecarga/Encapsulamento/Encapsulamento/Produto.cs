using System;

namespace Course
{
    internal class Produto
    {
        private string _nome;
        private double _preco;
        private int _quantidade;
        public Produto(string nome, double preco, int quantidade) {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        public string Nome {
            get { return _nome; }
            set {
                if (value.Length < 1) return;
                _nome = value;
            }
        }

        public double Preco
        {
            get { return _preco; }
        }

        public int Quantidade {
            set {
                if (value < 0) return;
                _quantidade = value;
            }
            get { return _quantidade; }
        }


    }
}
