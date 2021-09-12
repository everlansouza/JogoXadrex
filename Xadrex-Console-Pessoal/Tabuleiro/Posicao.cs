using System;
using System.Collections.Generic;
using System.Text;

namespace tabuleiro
{
    class Posicao
    {
        
        public int Linha { get; set; }
        public int Colunas { get; set; }

        public Posicao(int linha, int colunas)
        {
            Linha = linha;
            Colunas = colunas;
        }

        public override string ToString()
        {
            return $"{Linha}, {Colunas}";
        }
    }
}
