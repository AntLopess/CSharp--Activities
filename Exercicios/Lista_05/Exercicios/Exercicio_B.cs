using System;
using System.Collections.Generic;
using System.Text;

namespace Lista_05.Exercicios
{
    internal class Exercicio_B
    {
        public static void Executar()
        {
            /*b) Encontre o maior entre dois números.*/
            Console.Clear();
            Console.WriteLine("Digite o primeiro numero: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            Console.WriteLine("O programa mostrara qual é maior.");
            int n2 = int.Parse(Console.ReadLine());
            string mom = (n1 > n2) ? "O primeiro é o maior." : "O segundo é o maior.";
            Console.WriteLine(mom);
        }
    }
}
