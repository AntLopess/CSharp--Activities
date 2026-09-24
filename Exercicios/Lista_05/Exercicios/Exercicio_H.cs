using System;
using System.Collections.Generic;
using System.Text;

namespace Lista_05.Exercicios
{
    internal class Exercicio_H
    {
        public static void Executar()
        {
            /*h) Converta uma string em um número.*/
            Console.Clear();
            Console.WriteLine("Digite o preço de um produto.");
            string preco = Console.ReadLine();
            string numeros = new string(preco.Where(c => char.IsDigit(c)|| c == ',').ToArray());
            double valor = double.Parse(numeros);
            Console.WriteLine(valor);
        }
    }
}
