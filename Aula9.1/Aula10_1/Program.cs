﻿using System;
using System.Globalization;

namespace Aula10
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite a hora atual:");
            int hora = int.Parse(Console.ReadLine());

            if (hora < 12)
            
                Console.WriteLine("Dim dia!");
            
            else if (hora < 18)
            
                Console.WriteLine("Boa tarde!");
           
            else
            
                Console.WriteLine("Boa noite!");
            
        }
    }
}