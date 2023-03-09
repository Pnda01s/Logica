using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String nome, endereco, telefone;
            
            Console.WriteLine("\t\t---Cadastro---");

            Console.Write("Nome: ");
            nome = Console.ReadLine();

            Console.Write("Endereço: ");
            endereco = Console.ReadLine();

            Console.Write("Telefone: ");
            telefone = Console.ReadLine();

            Console.Clear();

            Console.WriteLine($"Nome:\t\t{nome}");
            Console.WriteLine($"Endereço:\t{endereco}");
            Console.WriteLine($"Telefone:\t{telefone}");
            
        }  
    }
}
