using System;
namespace TesteQuestionario
{
    class Program
    {
        static void Main(string[] args)
        {
            string resposta;
            int pontuação = 0;

            Console.WriteLine("Bem vindo ao quiz da atividade de fixação");
            Console.WriteLine("");
            Console.WriteLine("1) Qual a diferença entre Java e C#?");
            Console.WriteLine("");
            Console.WriteLine("a) C# só pode ser usado para criar páginas web, enquanto Java só serve para aplicativos mobile");
            Console.WriteLine("");
            Console.WriteLine("b) Java roda em qualquer sistema via JVM, enquanto C# foi criado pela Microsoft e é fortemente ligado ao ecossistema.NET");
            Console.WriteLine("");
            Console.WriteLine("c) Java e C# são exatamente a mesma linguagem, apenas com nomes diferentes");
            Console.WriteLine("");
            Console.WriteLine("Digite (a, b, ou c) para dar a resposta");

            resposta = Console.ReadLine();

            if (resposta.Equals("b", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Correto!");
                pontuação++;
            }
            else
            {
                Console.WriteLine("Errado! a resposta correta era b");
            }
            Console.WriteLine("2) O que é uma IDE?");
            Console.WriteLine("");
            Console.WriteLine("a) Um tipo de banco de dados usado para armazenar informações de programas");
            Console.WriteLine("");
            Console.WriteLine("b) Uma linguagem de programação usada para criar sites");
            Console.WriteLine("");
            Console.WriteLine("c) Um Ambiente de Desenvolvimento Integrado, com editor de código, depurador e ferramentas de compilação em um só lugar");
            Console.WriteLine("");
            Console.WriteLine("Digite (a, b, ou c) para dar a resposta");

            resposta = Console.ReadLine();

            if (resposta.Equals("c",StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Correto!");
                pontuação++;
            }
            else
            {
                Console.WriteLine("Errado! a resposta correta era c.");
            }
            Console.WriteLine("3) Qual método inicia um programa C#?");
            Console.WriteLine("");
            Console.WriteLine("a) start()");
            Console.WriteLine("");
            Console.WriteLine("b) Main()");
            Console.WriteLine("");
            Console.WriteLine("c) begin()");
            Console.WriteLine("");
            Console.WriteLine("Digite (a, b, ou c) para dar a resposta");

            resposta = Console.ReadLine();

            if(resposta.Equals("b", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Correto!");
                pontuação++;
            }
            else
            {
                Console.WriteLine("Errado! a resposta correta era b.");
            }
            Console.WriteLine("4) Qual comando mostra informações no console em C#?");
            Console.WriteLine("");
            Console.WriteLine("a) print()");
            Console.WriteLine("");
            Console.WriteLine("b) System.out.println()");
            Console.WriteLine("");
            Console.WriteLine("c) Console.WriteLine()");

            resposta = Console.ReadLine();
            
            if(resposta.Equals("c", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Correto!");
                pontuação++;
            }
            else
            {
                Console.WriteLine("Errado! a resposta correta era c.");
            }
            Console.WriteLine("5) Qual a função do Visual Studio?");
            Console.WriteLine("");
            Console.WriteLine("a) É um navegador de internet usado para testar sites");
            Console.WriteLine("");
            Console.WriteLine("b) É um sistema operacional usado para rodar aplicativos .NET");
            Console.WriteLine("");
            Console.WriteLine("c) É uma IDE da Microsoft usada para desenvolver, depurar e compilar aplicações, principalmente em C# e .NET");

            resposta = Console.ReadLine();
            if(resposta.Equals("c", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Correto!");
                pontuação++;
            }
            else
            {
                Console.WriteLine("Errado! a resposta correta era c.");
            }
            Console.WriteLine("Voce acertou "+pontuação +" questões.");

            if (pontuação == 5)
            {
                Console.WriteLine("Parabens! Voce acertou todas as questoes, sabe muito!");
            }
        }
    }
}
