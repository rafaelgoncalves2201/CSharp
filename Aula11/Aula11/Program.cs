using System;

namespace Aula11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o preço do produto");
            double preco = double.Parse(Console.ReadLine())
            double desconto = 0.0; 

            if (preco >  100.0) {
                desconto = preco * 0.1;
            }
            Console.WriteLine(desconto);
        }
    }
}