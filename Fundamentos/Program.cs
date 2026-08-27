using System;
namespace EntradaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Olá, " + nome + "!");
            Console.ReadLine();
        }
    }
}
