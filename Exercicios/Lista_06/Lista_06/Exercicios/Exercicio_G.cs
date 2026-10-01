using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_06.Exercicios
{
    internal class Exercicio_G
    {
        public static void Executar()
        {
            Console.WriteLine("===============================");
            Console.WriteLine("       ESCOLHA UMA COR        ");
            Console.WriteLine("===============================");
            Console.WriteLine("- Vermelho");
            Console.WriteLine("- Azul");
            Console.WriteLine("- Verde");
            Console.WriteLine("===============================");
            Console.Write("Digite o nome de uma das cores acima: ");

            // Lê a entrada, remove espaços extras (.Trim) e converte para minúsculas (.ToLower)
            string entrada = Console.ReadLine()?.Trim().ToLower();

            Console.WriteLine(); // Linha em branco para organização

            switch (entrada)
            {
                case "vermelho":
                    Console.WriteLine("Você escolheu a cor VERMELHO. 🔴");
                    break;
                case "azul":
                    Console.WriteLine("Você escolheu a cor AZUL. 🔵");
                    break;
                case "verde":
                    Console.WriteLine("Você escolheu a cor VERDE. 🟢");
                    break;
                default:
                    Console.WriteLine("Opção inválida! Por favor, escolha entre vermelho, azul ou verde.");
                    break;
            }
        }
    }
}
