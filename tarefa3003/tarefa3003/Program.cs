using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarefa3003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Texto de exemplo
            string texto = "Este é um exemplo de texto de teste. Este texto tem algumas palavras repetidas, como exemplo, texto, este, palavras.";

            // Dividir o texto em palavras
            string[] palavras = texto.Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            // Criar um dicionário para contar as palavras
            Dictionary<string, int> contagem = new Dictionary<string, int>();

            // Percorrer as palavras e contar as repetições
            foreach (string palavra in palavras)
            {
                if (contagem.ContainsKey(palavra))
                {
                    contagem[palavra]++;
                }
                else
                {
                    contagem.Add(palavra, 1);
                }
            }

            // Exibir a contagem de palavras
            foreach (KeyValuePair<string, int> par in contagem)
            {
                Console.WriteLine("Palavra: {0}, Repetições: {1}", par.Key, par.Value);
            }
        }
    }
}
