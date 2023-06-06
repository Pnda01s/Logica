using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] X = new int[10];
                       
            for (int i = 0; i < X.Length; i++)
            {
                Console.Write("Informe o valor para o elemento " + i + ": ");
                X[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Informe o índice (0 a 9): ");
            int P = int.Parse(Console.ReadLine());

           
            if (P >= 0 && P < X.Length)
            {
                int valor = X[P];
                Console.WriteLine("O valor do elemento no índice " + P + " é: " + valor);
            }
            else
            {
                Console.WriteLine("Índice inválido!");
            }

            Console.ReadLine();
        }
    }
}
