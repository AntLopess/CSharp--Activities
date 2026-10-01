using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_06.Exercicios
{
    internal class Exercicio_I
    {
        public static void Executar()
        {
            Console.Write("Digite um número de 1 a 7 para representar o dia da semana: ");

            // Valida se a entrada é um número inteiro
            if (int.TryParse(Console.ReadLine(), out int dia))
            {
                Console.WriteLine(); // Linha em branco para organização

                switch (dia)
                {
                    case 1:
                        Console.WriteLine("Dia 1: Domingo");
                        break;
                    case 2:
                        Console.WriteLine("Dia 2: Segunda-feira");
                        break;
                    case 3:
                        Console.WriteLine("Dia 3: Terça-feira");
                        break;
                    case 4:
                        Console.WriteLine("Dia 4: Quarta-feira");
                        break;
                    case 5:
                        Console.WriteLine("Dia 5: Quinta-feira");
                        break;
                    case 6:
                        Console.WriteLine("Dia 6: Sexta-feira");
                        break;
                    case 7:
                        Console.WriteLine("Dia 7: Sábado");
                        break;
                    default:
                        Console.WriteLine("Número inválido! Digite apenas um valor entre 1 e 7.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("\nEntrada inválida! Por favor, insira um número inteiro.");
            }
        }
    }
}
