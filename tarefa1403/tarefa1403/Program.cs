using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarefa1403
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---Verifica se um número é par ou ímpar---");
            Console.Write("\nInforme um número: ");
            int num = int.Parse(Console.ReadLine());

            if (num%2 == 0)
            {
                Console.WriteLine($"o número {num} é par!");
            }
            else
            {
                Console.WriteLine($"O número {num} é ímpar!");
            }
            Console.ReadKey();
        }
    }

}
