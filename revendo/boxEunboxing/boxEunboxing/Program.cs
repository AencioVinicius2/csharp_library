using System;

namespace boxANDunboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            // Boxing, é o processo de conversão de um objeto tipo valor para um objeto tipo referencia compativel
            int x = 20; // [X] stack
            Object obj = x; // obj é uma referencia para um objeto no heap (custa mais processamento e memoria)

            // é o processo do conversão de um objeto tipo referência para um objeto tipo valor compátivel
            int y = (int) obj; // variavel y é criada no stack e recebe o valor [20], que estava dentro do heap (variavel x) [20]


        }
    }
        
}