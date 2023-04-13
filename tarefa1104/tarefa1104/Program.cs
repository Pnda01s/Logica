using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarefa1104
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op = 1;
            while (op == 1)
            {
                Console.WriteLine("\t\t---Calculadora com while---\n");
                Console.Write("Informe um número: ");
                int num = int.Parse(Console.ReadLine());

                int cont = 0;
                while (cont <= 10)
                {
                    Console.WriteLine($"{num} x {cont} = {num * cont}");
                    cont++;
                }
                Console.WriteLine("\nDeseja realizar outra operação?\n[0]Não\n[1]Sim");
                Console.Write("Escolha uma opçaão: ");
                op = int.Parse(Console.ReadLine());
                Console.Clear();
            }
            Console.ReadKey();
        }
    }
}
