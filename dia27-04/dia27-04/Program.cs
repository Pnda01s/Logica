using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dia27_04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\t\t---Conversão de graus Celsius em Fahrenheit");

            Console.Write("Digite o limite superior do intervalo desejado: ");
            double limiteSuperior = double.Parse(Console.ReadLine());

            Console.Write("Digite o limite inferior do intervalo desejado: ");
            double limiteInferior = double.Parse(Console.ReadLine());

            Console.Write("Digite o decremento desejado: \n");
            double decremento = double.Parse(Console.ReadLine());

            Console.WriteLine("Celsius\tFahrenheit");
            for (double fahrenheit = limiteSuperior; fahrenheit >= limiteInferior; fahrenheit -= decremento)
            {
                double celsius = 5 * (fahrenheit - 32) / 9;
                Console.WriteLine("{0}\t{1}", fahrenheit, celsius);
            }
            Console.ReadKey();
        }
    }
}

