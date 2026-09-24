using System;
using System.Collections.Generic;
using System.Text;

namespace Lista_05.Exercicios
{
    internal class Exercicio_A
    {
        public static void Executar()
        {
            /*a) Verifique se um número é par ou ímpar.*/
            Console.Clear();
            Console.WriteLine("Digite um numero: ");
            int n = int.Parse(Console.ReadLine());
            string poi = (n % 2 == 0) ? "É Par" : "É Impar";
            Console.WriteLine(poi);
        }
    }
}
