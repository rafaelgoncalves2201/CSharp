﻿using System;
using System.ComponentModel.Design;

namespace Aula13
{
    class Program
    {
        static void Main(string[] args) {

            Console.WriteLine("Digite três números:");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            if (n1 > n2 && n1 > 3) {
                Console.WriteLine("Maior = " + n1);
            }
            else if (n2 > n3) {
                Console.WriteLine("Maior = " + n2);
            }
            else{
                Console.WriteLine("Maior = " + n3);
            }
        }
    }
}