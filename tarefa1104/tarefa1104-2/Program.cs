using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarefa1104_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fe = 0;
            double conta = 0, valorDeposito = 0, valorSaque = 0;

            do
            {
                Console.WriteLine("\n\t\t---Calculadora de saldo---");

                Console.WriteLine("\nO que você quer fazer?");
                Console.WriteLine("1. Depositar");
                Console.WriteLine("2. Sacar");
                Console.WriteLine("3. Exibir Saldo");
                Console.WriteLine("4. Sair");
                Console.Write("Sua opção: ");

                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Write("Qual valor? ");
                        valorDeposito = double.Parse(Console.ReadLine());
                        conta += valorDeposito;
                        Console.WriteLine("Depósito efetuado com sucesso!");
                        break;

                    case 2:
                        Console.Write("Qual valor? ");
                        valorSaque = double.Parse(Console.ReadLine());
                        if (valorSaque > conta)
                        {
                            Console.Clear();
                            Console.WriteLine("Saldo insuficiente.");
                        }
                        else
                        {
                            conta -= valorSaque;
                            Console.Clear();
                            Console.WriteLine("Saque efetuado com sucesso!");
                        }
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("Saldo atual: R$ " + conta);
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("Obrigado por utilizar nossos serviços!");
                        fe = 4;
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                        
                }
            } while (fe != 4);
        }
    }
}