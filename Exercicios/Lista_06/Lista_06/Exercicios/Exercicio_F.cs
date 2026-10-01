using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_06.Exercicios
{
    internal class Exercicio_F
    {
        public static void Executar()
        {
            Console.Write("Digite um número inteiro: ");

            // Valida se o usuário digitou um número inteiro válido
            if (int.TryParse(Console.ReadLine(), out int numero))
            {
                // Estrutura condicional para verificar o sinal do número
                if (numero > 0)
                {
                    Console.WriteLine($"\nO número {numero} é POSITIVO.");
                }
                else if (numero < 0)
                {
                    Console.WriteLine($"\nO número {numero} é NEGATIVO.");
                }
                else
                {
                    Console.WriteLine("\nO número digitado é ZERO.");
                }
            }
            else
            {
                Console.WriteLine("\nEntrada inválida! Por favor, insira um número inteiro válido.");
            }
        }
    }
}
