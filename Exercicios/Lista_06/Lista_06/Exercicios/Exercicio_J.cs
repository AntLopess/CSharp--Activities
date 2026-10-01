using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_06.Exercicios
{
    internal class Exercicio_J
    {
        public static void Executar()
        {
            Console.WriteLine("===============================");
            Console.WriteLine("      TABELA DE TAMANHOS       ");
            Console.WriteLine("===============================");
            Console.WriteLine(" [ P ] - Tamanho Pequeno");
            Console.WriteLine(" [ M ] - Tamanho Médio");
            Console.WriteLine(" [ G ] - Tamanho Grande");
            Console.WriteLine("===============================");
            Console.Write("Escolha o tamanho da camiseta (P, M ou G): ");

            // Lê a entrada, remove espaços (.Trim) e converte para maiúsculo (.ToUpper)
            string tamanho = Console.ReadLine()?.Trim().ToUpper();

            Console.WriteLine(); // Linha em branco para organização

            switch (tamanho)
            {
                case "P":
                    Console.WriteLine("Camiseta Tamanho P selected.");
                    Console.WriteLine("Preço: R$ 35,00");
                    break;
                case "M":
                    Console.WriteLine("Camiseta Tamanho M selecionada.");
                    Console.WriteLine("Preço: R$ 45,00");
                    break;
                case "G":
                    Console.WriteLine("Camiseta Tamanho G selecionada.");
                    Console.WriteLine("Preço: R$ 55,00");
                    break;
                default:
                    Console.WriteLine("Tamanho inválido! Por favor, escolha apenas entre P, M ou G.");
                    break;
            }
        }
    }
}
