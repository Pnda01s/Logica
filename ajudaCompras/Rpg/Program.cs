using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int heroHealth = 10;
            int monsterHealth = 10;
            Random rand = new Random();

            Console.WriteLine("Iniciando batalha entre herói e monstro!\n");

            do
            {
                int heroAttack = rand.Next(1, 11);
                monsterHealth -= heroAttack;
                Console.WriteLine($"O monstro foi danificado e perdeu {heroAttack} saúde e agora tem {monsterHealth} saúde.");

                if (monsterHealth > 0)
                {
                    int monsterAttack = rand.Next(1, 11);
                    heroHealth -= monsterAttack;
                    Console.WriteLine($"O herói foi danificado e perdeu {monsterAttack} saúde e agora tem {heroHealth} saúde.");
                }
            } while (heroHealth > 0 && monsterHealth > 0);

            if (heroHealth > 0)
            {
                Console.WriteLine("\nO herói venceu!");
            }
            else
            {
                Console.WriteLine("\nO monstro venceu!");
            }

            Console.ReadLine();
        }
    }
}
