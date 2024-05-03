using System;
using System.Globalization;

namespace AulaFor {
    class Program {
        static void Main(string[] args) {

            Console.Write("Irar digitar quantos números Inteiros? ");
            int n = int.Parse(Console.ReadLine());

            int soma = 0;
            for (int i = 1; i <= n; i++) {
                Console.Write("Digite um número: #{0}: ", i);
                int valor = int.Parse(Console.ReadLine());
                soma += valor;

            }
            Console.WriteLine("Soma = " + soma);
        }
    }
}