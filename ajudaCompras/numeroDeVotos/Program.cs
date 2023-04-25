using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numeroDeVotos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int nvcard1 = 0, nvcard2 = 0, nvcard3 = 0, nvbrancos = 0, nvnulos = 0, neleitores = 0, op;

            string resposta = "SIM";
            do
            {
                Console.WriteLine("Data: " +DateTime.Now.ToString("dd-MM-yyyy"));

                Console.WriteLine("\n\t\t---Qual é a melhor série de todos os tempos?");
                Console.WriteLine("\n\t[1]The Big Bang Throry\n\t[2]Game of Thrones\n\t[3]The Glory\n\t[4]Outra\n\t[5]Não sei!");
                Console.Write("\nInforme a sua opção: ");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        nvcard1++;
                        break;
                    case 2:
                        nvcard2++;
                        break;
                    case 3:
                        nvcard3++;
                        break;
                    case 4:
                            nvbrancos++;
                        break;
                    case 5:
                        nvnulos++;
                        break;
                    default:
                        Console.Write("Opção Invalida!");
                        break;
                      

                }
                Console.WriteLine("\nVoto realizado com sucesso");
                Console.WriteLine("\nDeseja registrar outra valor?");
                Console.Write("Digite [S] ou [SIM] para prosseguir: ");
                resposta = Console.ReadLine().ToUpper();

            } while (resposta == "SIM" || resposta == "S");

            neleitores =  nvcard1 + nvcard2 + nvcard3 + nvbrancos + nvnulos;

            Console.WriteLine("\n\t\t---Resultados da Votação---");
            Console.WriteLine("\nNúmeros de votos: "+ neleitores);
            Console.WriteLine("The Big Bang Theaty: "+ nvcard1);
            Console.WriteLine("Game of Thrones: " + nvcard2);
            Console.WriteLine("The Glory: " + nvcard3); 
            Console.WriteLine("Outras: " + nvbrancos);
            Console.WriteLine("Não sei/Nulo: " + nvnulos);
           
        }
    }
}
