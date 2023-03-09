using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numTotalPrestacoes, numPrestacoesPagas;
            double valorPrestacao, valorTotalPago, saldoDevedor;

            Console.WriteLine("\t\t---Prestações---");

            Console.Write("Digite o número total de prestações: ");
            numTotalPrestacoes = int.Parse((Console.ReadLine()));
                

            Console.Write("Digite a quantidade de prestações pagas: ");
            numPrestacoesPagas = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor da prestação: ");
            valorPrestacao = double.Parse((Console.ReadLine()));

            valorTotalPago = numPrestacoesPagas * valorPrestacao;
            saldoDevedor = (numTotalPrestacoes - numPrestacoesPagas) * valorPrestacao;

            Console.WriteLine($"Valor total pago: R$ {valorTotalPago}");
            Console.WriteLine($"Saldo devedor: R$ {saldoDevedor}");

            Console.ReadKey();
        }
    }
}