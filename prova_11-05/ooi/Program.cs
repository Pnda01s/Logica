using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ooi
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var nome = "";
            var cabelo = true;

            do
            {
                Console.Write("Qual e seu primeiro nome: ");
                nome = Console.ReadLine();



                DateTime now = DateTime.Now;
                string Date = now.ToString("dd/MM/yyyy");
                Console.WriteLine("\t\t" + Date + "\n");

                nome = nome.ToLower();

                if (nome == "douglas")
                {
                    cabelo = false;
                                     
                }
                else
                {
                    Console.WriteLine("Parabéns!!! Você tem cabelo");

                }
            } while (cabelo != false);
            Console.WriteLine("Oi! Meu professor favorito");
            Console.ReadLine();
        }
    }
}