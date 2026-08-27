using System;
namespace EstruturasCondicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());// Lê a idade informada e converte para inteiro.

            if(idade >= 18) // Se a idade for maior ou igual a 18, o código dentro do if será executado.
            {
                Console.WriteLine("Você é maior de idade.");
            }
            else // Caso a condição não seja verdadeira (idade < 18), executa o código abaixo.
            {
                Console.WriteLine("Você é menor de idade.");
            }
            Console.ReadLine();
        }
    }
}
