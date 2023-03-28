using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarefa02_210323
{
    internal class Program
    {
        static void Main(string[] args)
        {
   
            string nomeAluno;
            double nota1, nota2, nota3, nota4, media;
            char conceito;

            Console.WriteLine("\t\t---Calcula nota do aluno---");

            Console.WriteLine("Digite o nome do aluno: ");
            nomeAluno = Console.ReadLine();

            Console.WriteLine("Digite a nota do 1º bimestre: ");
            nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota do 2º bimestre: ");
            nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota do 3º bimestre: ");
            nota3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota do 4º bimestre: ");
            nota4 = double.Parse(Console.ReadLine());

            media = (nota1 + nota2 + nota3 + nota4) / 4.0;

            if (media >= 90.0)
            {
                conceito = 'A';
            }
            else if (media >= 80.0)
            {
                conceito = 'B';
            }
            else if (media >= 60.0)
            {
                conceito = 'C';
            }
            else if (media >= 40.0)
            {
                conceito = 'D';
            }
            else if (media >= 20.0)
            {
                conceito = 'E';
            }
            else
            {
                conceito = 'F';
            }

            Console.WriteLine($"Nome do aluno: {nomeAluno}");
            switch (conceito)
            {
                case 'A':
                    Console.WriteLine("Situação: Aprovado");
                    break;
                case 'B':
                    Console.WriteLine("Situação: Aprovado");
                    break;
                case 'C':
                    Console.WriteLine("Situação: Aprovado");
                    break;
                case 'D':
                    Console.WriteLine("Situação: Aprovado");
                    break;
                case 'E':
                    Console.WriteLine("Situação: Exame");
                    break;
                default:
                    Console.WriteLine("Situação: Reprovado");
                    break;
            }
            Console.WriteLine($"Média: {media}");
            Console.WriteLine($"Conceito: {conceito}" );

            Console.ReadKey();
        }
    }
}
