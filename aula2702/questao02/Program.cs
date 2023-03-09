using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero1, numero2, soma, subtracao, multiplicacao, divisao;

            Console.WriteLine("\t\t---Multiplicação---");

            Console.Write("Digite o primeiro número: ");
            numero1 = double.Parse((Console.ReadLine()));

            Console.Write("Digite o segundo número: ");
            numero2 = double.Parse((Console.ReadLine()));


            Console.WriteLine($"{numero1} * {numero2} = " + (numero1 * numero2));

            Console.ReadKey();
        }
    }
}