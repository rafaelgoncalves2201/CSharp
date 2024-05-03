using System;
using System.Globalization;

namespace Coursee {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite sua senha: ");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (x != 2002) { 
                Console.WriteLine("Senha invalida:!");
                Console.Write("Digite novamente:");
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            Console.WriteLine("Acesso liberado");
        }
    }
}