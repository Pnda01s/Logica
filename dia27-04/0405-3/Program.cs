using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0405_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            double totalImposto = 0;

            for (int i = 1; i <= 10; i++)
            {
                Console.Write("Digite o nome da pessoa {0}: ", i);
                string nome = Console.ReadLine();
                Console.Write("Digite o salário bruto da pessoa {0}: ", i);
                double salarioBruto = double.Parse(Console.ReadLine());

                double imposto = 0;

                if (salarioBruto < 1000.0)
                {
                    imposto = 0;
                }
                else if (salarioBruto < 1500.0)
                {
                    imposto = salarioBruto * 0.075;
                }
                else
                {
                    imposto = salarioBruto * 0.15;
                }

                Console.WriteLine("{0} deve pagar R$ {1:F2} de imposto de renda.", nome, imposto);
                totalImposto += imposto;
            }

            Console.WriteLine("O total de imposto de renda a ser pago é de R$ {0:F2}.", totalImposto);
            Console.ReadKey();
        } 
    }
}
