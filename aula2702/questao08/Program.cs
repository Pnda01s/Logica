using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, soma, diferenca, produto, quociente;

            Console.WriteLine("\t\t---Calcular o consumo de combustível---");

            Console.Write("Digite o primeiro número: ");
            num1 = double.Parse((Console.ReadLine()));

            Console.Write("Digite o segundo número: ");
            num2 = double.Parse((Console.ReadLine()));

            soma = num1 + num2;
            diferenca = num1 - num2;
            produto = num1 * num2;
            quociente = num1 / num2;

            Console.WriteLine($"Soma: {soma}");
            Console.WriteLine($"Diferença: {diferenca}");
            Console.WriteLine($"Produto: {produto}");
            Console.WriteLine($"Quociente: {quociente}");
                              
            Console.ReadKey();
        }
    }
}