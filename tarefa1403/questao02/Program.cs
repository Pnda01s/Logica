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
            int num1, num2, num3, maior;

            Console.WriteLine("\t\t---ê três números inteiros e imprima o maior---");

            Console.Write("Digite o primeiro número: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            num2 = int.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro número: ");
            num3 = int.Parse(Console.ReadLine());

            maior = num1;

            if (num2 > maior)
            {
                maior = num2;
            }

            if (num3 > maior)
            {
                maior = num3;
            }

            Console.WriteLine($"O maior número é: {maior}");

            Console.ReadKey();
        }
    }
}