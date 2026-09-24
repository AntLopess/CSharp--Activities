using System;
using System.Collections.Generic;
using System.Text;

namespace Lista_05.Exercicios
{
    internal class Exercicio_J
    {
        public static void Executar()
        {
            /*j) Verifique se uma variável é nula ou não.*/
            Console.Clear();
            Console.WriteLine("Digite algo ou tecle Enter e verificaremos se o espaço esta em branco.");
            string vazio = Console.ReadLine();
            string resposta = (string.IsNullOrEmpty(vazio)) ? "Esta em branco." : "Esta preenchido";
            Console.WriteLine(resposta);
        }
    }
}
