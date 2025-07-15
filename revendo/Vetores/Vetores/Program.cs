using System;

namespace Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 0.0;
            double avg = 0.0;
            int nProdutos = 0;

            double[] vect = new double[n];

            for (int i = 0; i < n; i++)
            {
                vect[i] = double.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                sum += vect[i];
            }

            avg = sum / vect.Length;

            Console.WriteLine(avg);

            Console.WriteLine("-----------------------------------------------------------------------------");


            nProdutos = int.Parse(Console.ReadLine());

            Produto[] produtos = new Produto[nProdutos];

            for (int i = 0; i < nProdutos; i++)
            {
                string nome  = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine());

                produtos[i] = new Produto {  Name = nome, Price = preco };
               
            }
        }
    }
}