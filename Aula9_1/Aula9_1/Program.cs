﻿using System;
using System.Globalization;

namespace Aula9_1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool c1 = 2 > 3 || 4 != 5;
            bool c2 = !(2 > 3) && 4 != 5;

            Console.WriteLine(c1);
            Console.WriteLine(c2);

            bool c3 = 10 < 5; // False
            bool c4 = c1 || c2 && c3;

            Console.WriteLine(c3);
            Console.WriteLine(c4);
        }
    }
}