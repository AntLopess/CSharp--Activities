using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_06.Exercicios
{
    internal class Exercicio_B
    {
        public static void Executar()
        {
            Console.Write("Digite a primeira data (dd/mm/yyyy): ");
            DateTime data1 = DateTime.Parse(Console.ReadLine());

            Console.Write("Digite a segunda data (dd/mm/yyyy): ");
            DateTime data2 = DateTime.Parse(Console.ReadLine());

            // Math.Abs garante que o resultado seja positivo, independente da ordem
            int diferencaDias = Math.Abs((data2 - data1).Days);

            Console.WriteLine($"\nDiferença: {diferencaDias} dia(s).");
        }
    }
}
