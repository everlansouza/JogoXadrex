using System;
using Tabuleiro;

namespace Xadrex_Console_Pessoal
{
    class Program
    {
        static void Main(string[] args)
        {
            Posicao P = new Posicao(2, 3);

            Console.WriteLine("Posição: " + P);

            Console.ReadKey();
        }
    }
}
