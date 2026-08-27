using System;
namespace ValidaçãoDeSenha
{
    class ValidaçãoDeSenha
    {
        static void Main(string[] args)
        {
            string senhaCorreta = "1234"; // A senha correta que será comparada.

            Console.WriteLine("Digite a senha: ");
            string senha = Console.ReadLine();

            if(senha == senhaCorreta)
            {
                Console.WriteLine("Senha correta! Acesso permitido.");
            }
            else
            {
                Console.WriteLine("Senha incorreta! Acesso negado.");
            }
            Console.ReadLine();
        }
    }
}
