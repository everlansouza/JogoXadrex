using System;
using tabuleiro;

namespace Xadrex_Console_Pessoal
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tabuleiro = new Tabuleiro(8, 8);

            Tela.imprimirTabuleiro(tabuleiro);

            Console.ReadKey();
        }
    }
}
