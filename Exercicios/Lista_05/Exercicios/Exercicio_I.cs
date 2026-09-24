using System;
using System.Collections.Generic;
using System.Text;

namespace Lista_05.Exercicios
{
    internal class Exercicio_I
    {
        public static void Executar()
        {
            /*i) Verifique se um número é divisível por outro.*/
            Console.Clear();
            Console.WriteLine("Digite o primeiro numero: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            Console.WriteLine("O programa mostra-ra se o primeiro e divisivel pelo segundo.");
            int n2 = int.Parse(Console.ReadLine());
            string resposta = (n1 % n2 == 0) ? "O numero e divisivel." : "O numero não é divisivel.";
            Console.WriteLine(resposta);
        }
    }
}
