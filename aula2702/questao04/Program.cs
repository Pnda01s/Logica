using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double comprimento, largura, altura, volume;

            Console.WriteLine("\t\t---Volume de uma caixa retangular---");

            Console.Write("Digite o comprimento da caixa: ");
            comprimento = double.Parse((Console.ReadLine()));

            Console.Write("Digite a largura da caixa: ");
            largura = double.Parse((Console.ReadLine()));

            Console.Write("Digite a altura da caixa: ");
            altura = double.Parse((Console.ReadLine()));

            volume = comprimento * largura * altura;

            Console.WriteLine($"O volume da caixa é: {volume}");

            Console.ReadKey();
        }
    }
}
