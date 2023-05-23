using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova_11_05
{
    internal class Program
    {
        /*
        Pedro Noemerg De Andrade
        Aline Noemerg Grey
        */
        static void Main(string[] args)
        {
            int fechar = 0;
            double conta = 0, valorDeposito = 0, valorSaque = 0;

            do
            {
                Console.WriteLine("\n\t\t---Caixa Eletrônico---");

                Console.WriteLine("\nO que você quer fazer?");
                Console.WriteLine("[1]-Saque");
                Console.WriteLine("[2]-Depósito");
                Console.WriteLine("[3]-Consulta Saldo");
                Console.WriteLine("[4]-Sair");
                Console.Write("Sua opção: ");

                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {


                    case 1:
                        Console.Write("Qual valor: ");
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
                    case 2:
                        Console.Write("Qual valor: ");
                        valorDeposito = double.Parse(Console.ReadLine());


                        if (valorDeposito > 0)
                        {
                            Console.WriteLine("Depósito efetuado com sucesso!!!");
                            conta += valorDeposito;
                        }
                        else
                        {
                            Console.WriteLine("ERRO!! Deposite um valor maior que 0!!");
                        }

                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine($"Saldo atual: {conta:C2}");
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("Deseja fazer outra operação:\n[1]-Sim\n[2]-Não");
                        int outra = int.Parse(Console.ReadLine());
                        if (outra == 1)
                        {
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Obrigado por utilizar nossos serviços!");
                            fechar = 4;
                        }
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Opção inválida. Tente novamente.");

                        break;                    

                }
            } while (fechar != 4);

        }
    }
}