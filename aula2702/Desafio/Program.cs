using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string identificacao;
            double salarioFixo, totalVendas, comissao, salarioFinal;

            Console.WriteLine("\t\t---Desafio---");

            Console.Write("Digite a identificação do vendedor: ");
            identificacao = Console.ReadLine();

            Console.Write("Digite o salário fixo do vendedor: ");
            salarioFixo = double.Parse((Console.ReadLine()));

            Console.Write("Digite o total de vendas realizadas (em R$): ");
            totalVendas = double.Parse((Console.ReadLine()));

            Console.Write("Digite o percentual de comissão sobre as vendas: ");
            comissao = double.Parse((Console.ReadLine()));

            salarioFinal = salarioFixo + (totalVendas * comissao / 100);

            Console.WriteLine($"O salário do vendedor {identificacao} é: R$ {salarioFinal}");

            Console.ReadKey();
        }
    }
}