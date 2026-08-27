using System;
namespace LaçosDeRepetiçao_While
{
    class LaçosDeRepetiçao_While
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i <= 5) // O laço irá se repetir enquanto 'i' for menor ou igual a 5.
            {
                Console.WriteLine("Contagem: " + i);
                i++; // Incrementa o valor de 'i' a cada repetição.
            }
            Console.ReadLine();
        }
    }
}
