using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dia0405
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int termoAtual = 1;
            int termoAnterior = 1;

            Console.WriteLine(termoAnterior);
            Console.WriteLine(termoAtual);

            for (int i = 3; i <= 10; i++)
            {
                int proximoTermo = termoAtual + termoAnterior;
                Console.WriteLine(proximoTermo);
                termoAnterior = termoAtual;
                termoAtual = proximoTermo;
            }
        }
    }
}
