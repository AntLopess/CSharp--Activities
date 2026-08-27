using System;
namespace Funções_Metodos
//Criar e chamar funções (métodos) no terminal.
{
    class Funções_Metodos
    {
        static void Main(string[] args)
        {
            Saudacao(); // Chama a função Saudacao, que será definida abaixo.
            Console.ReadLine();
        }
        static void Saudacao() // Define o método "Saudacao", que exibe uma mensagem de boas-vindas.
        {
            Console.WriteLine("Bem-vindo ao programa!");
        }
    }
}
