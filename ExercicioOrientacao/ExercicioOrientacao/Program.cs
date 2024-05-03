using System;
using System.Globalization;

namespace ExercicioOrientacao {
    class Program {
        static void Main(string[] args) {
            Pessoa p1 = new Pessoa(); 
            Pessoa p2 = new Pessoa();

            Console.WriteLine("Dados primeira pessoa:");
            Console.Write("Nome: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            p1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados da segunda pessoa:" );
            Console.Write("Nome: ");
            p2.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            p2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media_salario = (p1.Salario + p2.Salario) / 2.0;

            Console.WriteLine("A media salarial é: " + media_salario.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}