using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarefa1104_1
{
    internal class Program
    {
        /*Escreva um programa que tem por finalidade calcular a Média Geral de uma Turma de alunos.
        O Programa deverá:
        Ler o numero de alunos da turma;
        Ler as notas dos 4 bimestres de cada aluno;
        Calcular e imprimir a média do aluno;
        Calcular e imprimir a média da turma.*/
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---Média Geral de uma Turma de alunos---\n");
            Console.Write("Digite o número de alunos na turma: ");
            int numAlunos = int.Parse(Console.ReadLine());

            double somaNotasTurma = 0.0;
            double mediaTurma = 0.0;
            int i = 1;

            
            while (i <= numAlunos)
            {
                
                Console.WriteLine($"\nAluno {i}:");
                Console.Write("1º bimestre: ");
                double nota1 = int.Parse(Console.ReadLine());
                Console.Write("2º bimestre: ");
                double nota2 = int.Parse(Console.ReadLine());
                Console.Write("3º bimestre: ");
                double nota3 = int.Parse(Console.ReadLine());
                Console.Write("4º bimestre: ");
                double nota4 = int.Parse(Console.ReadLine());

                double mediaAluno = (nota1 + nota2 + nota3 + nota4) / 4.0;
                Console.WriteLine($"\nMédia do aluno: {mediaAluno}");

                somaNotasTurma += mediaAluno;
                mediaTurma = somaNotasTurma / i;

                i++;
            }


            Console.WriteLine($"\nMédia da turma: {mediaTurma}");
            Console.ReadKey();
        }
        
    }
 }
