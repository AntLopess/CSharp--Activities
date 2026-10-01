using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_06.Exercicios
{
    internal class Exercicio_E
    {
        public static void Executar()
        {
            bool executando = true;

            do
            {
                Console.Clear(); // Limpa o console a cada exibição
                Console.WriteLine("==============================");
                Console.WriteLine("        MENU DE OPÇÕES        ");
                Console.WriteLine("==============================");
                Console.WriteLine("1 - Exibir mensagem de Boas-Vindas");
                Console.WriteLine("2 - Exibir data e hora atuais");
                Console.WriteLine("3 - Exibir frase motivacional");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("==============================");
                Console.Write("Escolha uma opção (0-3): ");

                string opcao = Console.ReadLine();

                Console.WriteLine(); // Linha em branco para organização

                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("--> Seja muito bem-vindo(a) ao sistema!");
                        break;
                    case "2":
                        Console.WriteLine($"--> Data e Hora atuais: {DateTime.Now:dd/MM/yyyy HH:mm:ss}");
                        break;
                    case "3":
                        Console.WriteLine("--> \"O único lugar onde o sucesso vem antes do trabalho é no dicionário.\" - Albert Einstein");
                        break;
                    case "0":
                        Console.WriteLine("Encerrando o programa... Até logo!");
                        executando = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida! Por favor, escolha 1, 2, 3 ou 0.");
                        break;
                }

                if (executando)
                {
                    Console.WriteLine("\nPressione qualquer tecla para continuar...");
                    Console.ReadKey();
                }

            } while (executando);
        }
    }
}
