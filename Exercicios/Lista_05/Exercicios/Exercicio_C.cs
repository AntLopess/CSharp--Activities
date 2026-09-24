using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace Lista_05.Exercicios
{
    internal class Exercicio_C
    {
        public static void Executar()
        {
            /*c) Verifique se uma lista está vazia.*/
            Console.Clear();
            List<string> lista = new List<string>();

            string resposta = (lista == null || lista.Count == 0) ? "A lista esta Vazia." : "A lista esta preenchida.";
            Console.WriteLine(resposta);
        }
    }
}
