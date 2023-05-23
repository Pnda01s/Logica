using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ques2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[101];

            for (int i = 0; i <= 100; i++)
            {
                numeros[i] = i;
            }

            Console.WriteLine("Os números de 0 a 100 são:");

            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }

            Console.ReadLine();
        }
    }
}
