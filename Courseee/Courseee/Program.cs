using System;
using System.Globalization;

namespace Coursee
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um numero inteiro: ");
            double n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            while (n1 >= 0.0) {
                double raiz = Math.Sqrt(n1);
                Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
                Console.Write("Digite outro numero: ");
                n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
        }
    }
}