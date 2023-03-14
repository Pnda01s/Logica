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
            string nome;
            double nota1, nota2, nota3, nota4, media;

            Console.WriteLine("\t\t---Média de um aluno---");

            Console.Write("Digite o nome do aluno: ");
            nome = Console.ReadLine();

            Console.Write("Digite a primeira nota: ");
            nota1 = Double.Parse(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            nota2 = Double.Parse(Console.ReadLine());

            Console.Write("Digite a terceira nota: ");
            nota3 = Double.Parse(Console.ReadLine());

            Console.Write("Digite a quarta nota: ");
            nota4 = Double.Parse(Console.ReadLine());

            Console.Clear();

            media = (nota1 + nota2 + nota3 + nota4) / 4;

            Console.WriteLine("\t\t---Media do aluno---");

            Console.WriteLine($"Nome do aluno: {nome}\nMédia: {media} ");
            
            if (media >= 6.0)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else
            {
                Console.WriteLine("Aluno reprovado.");
            }

            Console.ReadKey();
        }
    }
}