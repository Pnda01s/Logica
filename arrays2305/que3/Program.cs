﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace que3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] alfabeto = new char[26];
            int unicode = 65;

            for (int i = 0; i < 26; i++)
            {
                alfabeto[i] = (char)unicode;
                unicode++;
            }

            Console.WriteLine("O alfabeto é:");

            foreach (char letra in alfabeto)
            {
                Console.WriteLine(letra);
            }

            Console.ReadLine();
        }
    }
}