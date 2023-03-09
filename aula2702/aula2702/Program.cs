using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double km, litros, re;

            Console.WriteLine("\t\t---Quantos Km o veículo está fazendo um litro---");
            Console.Write("Quantos litros: " );
            litros = Double.Parse(Console.ReadLine());

            Console.Write("Quantos Km: ");
            km = Double.Parse(Console.ReadLine());

            re = km / litros;

            Console.WriteLine($"O veículo está fazendo {re} Km com um litros de combustivel");

        }
    }
}
