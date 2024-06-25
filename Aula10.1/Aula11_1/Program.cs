using System;
using System.ComponentModel.Design;

namespace Aula13
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite três números:");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            
            double result = Maior(n1, n2, n3);
            Console.WriteLine("Maior = " + result);
        }
        static int Maior(int a, int b, int c) {
            int m;
            if (a > b && a > c)
            {
                m = a;
            }
            else if (b > c && b > a)
            {
                m = b;
            }
            else
            {
                m = c;
            }
            return m;
        }
    }
}
