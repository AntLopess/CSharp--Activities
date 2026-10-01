using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_06.Exercicios
{
    internal class Exercicio_H
    {
        public static void Executar()
        {
            Console.Write("Digite apenas uma letra: ");
            string entrada = Console.ReadLine()?.Trim();

            // Valida se foi digitado exatamente um único caractere e se esse caractere é uma letra
            if (!string.IsNullOrEmpty(entrada) && entrada.Length == 1 && char.IsLetter(entrada[0]))
            {
                char letra = char.ToLower(entrada[0]);

                // Conjunto de vogais (incluindo vogais com acentos comuns)
                char[] vogais = { 'a', 'e', 'i', 'o', 'u', 'á', 'é', 'í', 'ó', 'ú', 'â', 'ê', 'ô', 'ã', 'õ' };

                if (vogais.Contains(letra))
                {
                    Console.WriteLine($"\nA letra '{entrada}' é uma VOGAL.");
                }
                else
                {
                    Console.WriteLine($"\nA letra '{entrada}' é uma CONSOANTE.");
                }
            }
            else
            {
                Console.WriteLine("\nEntrada inválida! Por favor, digite apenas UMA letra (sem números ou símbolos).");
            }
        }
    }
}
