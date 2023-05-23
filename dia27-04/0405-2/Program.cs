using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0405_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o nome: ");
            string nome = Console.ReadLine();


            int nLetra = (nome.Trim()).Length;

            Console.WriteLine(nLetra);

            for (int i = 1; i <= nLetra; i++)
            {
                Console.WriteLine(nome);
            }
        }
    }
}
