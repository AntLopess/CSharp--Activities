using System;
using System.Collections.Generic;
using System.Text;

namespace Lista_05.Exercicios
{
    internal class Exercicio_G
    {
        public static void Executar()
        {
            /*g) Verifique se um número é positivo, negativo ou zero.*/
            Console.Clear();
            Console.WriteLine("Digite um numero e o programa mostrara se ele é positivo, negativo ou igual a zero.");
            int n = int.Parse(Console.ReadLine());
            string resposta = (n > 0) ? "Numero Positivo." : (n == 0) ? "Numero igual a zero." : "O numero e negativo.";
            Console.WriteLine(resposta);
        }
    }
}
