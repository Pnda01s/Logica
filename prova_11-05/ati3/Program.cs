using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ati3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite a data de nascimento (dd/MM/yyyy): ");
            string dataNascimentoRes = Console.ReadLine();


            DateTime dataNascimento = DateTime.ParseExact(dataNascimentoRes, "dd/MM/yyyy", null);

            TimeSpan diferenca = DateTime.Today - dataNascimento;
            DateTime idade = DateTime.MinValue + diferenca;

            Console.WriteLine($"Idade: {idade.Year - 1} anos, {idade.Month - 1} meses e {idade.Day - 2} dias");
        }
    }
}