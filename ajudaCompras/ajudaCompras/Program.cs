using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ajudaCompras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---Ajuda nas Compras---\n");

            Console.Write("Iforeme o valor disponível: ");
            double saldo = double.Parse(Console.ReadLine());

            int cont = 0;
            double compra = 0;
            double somaCompras = 0;
            bool podeComprar = true;

            do
            {
                Console.Write("\nValor da compra: ");
                compra = double.Parse(Console.ReadLine());
                
                if(compra > 0)
                {
                    if(compra <= saldo)
                    {
                        saldo -= compra;
                        somaCompras += compra;
                        cont++;
                        Console.WriteLine("\nCompra registrada!\nSaldo disponível: {0:c2}", saldo);
                    }
                    else
                    {
                        podeComprar = false;
                        Console.WriteLine("\nVocê não tem saldo suficiente para realizar essa compra");
                    }
                }
                else
                {
                    Console.WriteLine("Valor inválido!");
                }
                
            } while (podeComprar);
            Console.Clear();
            Console.WriteLine("\t\t---Resultado das Compras---");
            Console.WriteLine($"Número de Compras: {cont}\nTotal Gasto: {somaCompras:c2}\nSaldo Restate: {saldo:c2}");
            Console.ReadKey();
        }
    }
}
