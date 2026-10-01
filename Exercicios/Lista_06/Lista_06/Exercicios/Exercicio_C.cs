using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_06.Exercicios
{
    internal class Exercicio_C
    {
        public static void Executar()
        {
            Console.Write("Digite sua data de nascimento (dd/mm/yyyy): ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime dataNascimento))
            {
                DateTime hoje = DateTime.Today;

                // 1. Diferença básica de anos
                int idade = hoje.Year - dataNascimento.Year;

                // 2. Se a pessoa ainda NÃO fez aniversário este ano, subtrai 1 ano
                if (hoje < dataNascimento.AddYears(idade))
                {
                    idade--;
                }

                Console.WriteLine($"\nVocê tem {idade} ano(s).");
            }
            else
            {
                Console.WriteLine("Data inválida. Tente no formato dd/mm/yyyy.");
            }
        }
    }
}
