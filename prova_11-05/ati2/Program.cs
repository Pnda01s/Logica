using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ati2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a data de nascimento (dd/MM/yyyy): ");
            string dataNascimentoRes = Console.ReadLine();

            DateTime dataNascimento = DateTime.Parse(dataNascimentoRes);
            int idade = DateTime.Today.Year - dataNascimento.Year;

            if (dataNascimento > DateTime.Today.AddYears(-idade))
            {
                idade--;
            }

            Console.WriteLine("Idade: " + idade + " anos");
        }
    }
}
