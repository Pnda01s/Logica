using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalDias, anos, meses, semanas, diasRestantes;
            Console.WriteLine("---Calculadora de Anos---");

            Console.Write("Digite o total de dias: ");
            totalDias = int.Parse(Console.ReadLine());

            Console.WriteLine("\t\t---Calculadora de Anos---");

            anos = totalDias / 365;
            diasRestantes = totalDias % 365;

            meses = diasRestantes / 30;
            diasRestantes = diasRestantes % 30;

            semanas = diasRestantes / 7;
            diasRestantes = diasRestantes % 7;

            Console.WriteLine($"{totalDias} dias equivalem a {anos} anos, {meses} meses, {semanas} semanas e {diasRestantes} dias.");

            Console.ReadKey();
        }
    }
}