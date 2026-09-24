using System;
using System.Collections.Generic;
using System.Text;

namespace Lista_05.Exercicios
{
    internal class Exercicio_D
    {
        public static void Executar()
        {
            Console.Clear();
            Console.WriteLine("Digite algo ou tecle Enter e verificaremos se o espaço esta em branco.");
            string vazio = Console.ReadLine();
            string resposta = (string.IsNullOrWhiteSpace(vazio)) ? "Esta em branco." : "Esta preenchido";
            Console.WriteLine(resposta);
        }
    }
}
