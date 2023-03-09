using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade1, idade2, idade3, idade4, idade5, media;

            Console.WriteLine("\t\t---Idade média de 5 alunos---");

            Console.Write("Digite a idade do primeiro aluno: ");
            idade1 = int.Parse((Console.ReadLine()));

            Console.Write("Digite a idade do segundo aluno: ");
            idade2 = int.Parse((Console.ReadLine()));

            Console.Write("Digite a idade do terceiro aluno: ");
            idade3 = int.Parse((Console.ReadLine()));

            Console.Write("Digite a idade do quarto aluno: ");
            idade4 = int.Parse((Console.ReadLine()));

            Console.Write("Digite a idade do quinto aluno: ");
            idade5 = int.Parse((Console.ReadLine()));

            media = (idade1 + idade2 + idade3 + idade4 + idade5) / 5;

            Console.WriteLine($"A idade média dos 5 alunos é: {media}");

            Console.ReadKey();
        }
    }
}