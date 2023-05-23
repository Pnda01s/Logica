using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays2305
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[5];

            Console.WriteLine("Informe o nome de cinco pessoas:");

            for (int i = 0; i < nomes.Length; i++)
            {
                Console.Write("Nome " + (i + 1) + ": ");
                nomes[i] = Console.ReadLine();
            }

            Console.WriteLine("Os nomes informados são:");

            foreach (string nome in nomes)
            {
                Console.WriteLine(nome);
            }

            Console.ReadLine();
        }
    }
}

