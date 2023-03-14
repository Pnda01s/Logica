using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome1, nome2, maiorNome;
            int qtdLetras;

            Console.WriteLine("\t\t---o maior nome e sua quantidade de letras--");

            Console.Write("Digite o nome da primeira pessoa: ");
            nome1 = Console.ReadLine();

            Console.Write("Digite o nome da segunda pessoa: ");
            nome2 = Console.ReadLine();

            if (nome1.Length > nome2.Length)
            {
                maiorNome = nome1;
            }
            else
            {
                maiorNome = nome2;
            }

            maiorNome = maiorNome.Trim();
            qtdLetras = maiorNome.Length;
            
            Console.WriteLine($"O maior nome é: {maiorNome} \nQuantidade de letras: {qtdLetras}");


            Console.ReadKey();
        }
    }
}