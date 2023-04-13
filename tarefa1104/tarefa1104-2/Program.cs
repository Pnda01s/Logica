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

            int opcao = 0;
            while (opcao = 4) 
            {

            
            Console.WriteLine("O que você quer fazer?");
            Console.WriteLine("1. Depositar");
            Console.WriteLine("2. Sacar");
            Console.WriteLine("3. Exibir Saldo");
            Console.WriteLine("4. Sair");
            Console.Write("Sua opção: ");
            opcao = int.Parse(Console.ReadLine());

            double conta = 0, valorDeposito = 0, valorSaque = 0, saldo = 0;

                switch (opcao)
                {
                    case 1:
                        Console.Write("Qual valor? ");
                        valorDeposito = double.Parse(Console.ReadLine());
                        conta += valorDeposito;

                        break;
                    case 2:
                        Console.Write("Qual valor? ");
                        valorSaque = double.Parse(Console.ReadLine());
                        conta -= valorSaque;

                        break;
                    case 3:
                        Console.WriteLine("Saldo atual: R$ " + conta);
                        break;
                    case 4:
                        Console.WriteLine("Obrigado por utilizar nossos serviços!");
                        opcao = 4;
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            } 

        }
    }
}
