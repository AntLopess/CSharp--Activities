using System;
using System.Collections.Generic;
using System.Text;

namespace Lista_05.Exercicios
{
    internal class Exercicio_F
    {
        public static void Executar()
        {
            Console.Clear();
            Console.WriteLine("Digite um numero para mostrarmos seu valor absoluto.");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("O seu valor absoluto é: " + Math.Abs(n));
        }
    }
}
