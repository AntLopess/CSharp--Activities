using System;
namespace CalculadoraSimples
{
    class CalculadoraSimples
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro numero: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero: ");
            double n2 = double.Parse(Console.ReadLine());

            double soma = n1 + n2;
            double multiplicacao = n1 * n2;
            double divisao = n1 / n2;
            double subtracao = n1 - n2;
            Console.WriteLine("Soma: " + soma);
            Console.WriteLine("Multiplicação: "+multiplicacao);
            Console.WriteLine("Divisão: "+divisao);
            Console.WriteLine("Subtração: "+subtracao);
            Console.ReadLine();
        }
    }
}