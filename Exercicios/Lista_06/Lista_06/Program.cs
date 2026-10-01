using System;
namespace Lista_06
{
    class Program
    {
        public static void Main(string[] args)
        {
            string continuar = " ";
            while (continuar != "sim")
            {
                Console.Clear();
                MenuPrincipal.Menu.Executar();
                Console.WriteLine("Voce deseja sair?");
                continuar = Console.ReadLine();
            }

        }
    }
}