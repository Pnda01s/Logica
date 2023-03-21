using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarefa2103
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            double salario, novoSalario, aumento = 0;
            int codigoCargo;

            Console.WriteLine("\t\t---Aumento Salario---");

            
            Console.Write("Digite o código do cargo do funcionário \n1 = gerente,\n2 = engenheiro,\n3 = técnico; \nInforme o seu cargo: ");
            codigoCargo = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o salário atual do funcionário: ");
            salario = double.Parse(Console.ReadLine());

            switch (codigoCargo)
            {
                case 1:
                    aumento = 0.1;
                    break;
                case 2:
                    aumento = 0.2;
                    break;
                case 3:
                    aumento = 0.3;
                    break;
                default:
                    aumento = 0.4;
                    break;
            }

           
            novoSalario = salario + (salario * aumento);

            Console.WriteLine($"Salário antigo: {salario:c2}");
            Console.WriteLine($"Novo salário: {novoSalario:c2}");
            Console.WriteLine($"Diferença: {(novoSalario - salario):c2}");

            Console.ReadKey();
        }
    }
}