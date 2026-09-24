using System;
using System.Collections.Generic;
using System.Text;

namespace Lista_05.Exercicios
{
    internal class Exercicio_E
    {
        public static void Executar()
        {
            /*e) Verifique se uma condição é verdadeira.*/
            Console.Clear();
            Console.WriteLine("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());
            bool maioridade = idade >= 18;
            string resposta = (maioridade) ? "Pode tirar carteira" : "Não pode tirar carteira.";
            Console.WriteLine(resposta);
        }
    }
}
