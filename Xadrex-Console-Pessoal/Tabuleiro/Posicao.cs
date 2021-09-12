using System;
using System.Collections.Generic;
using System.Text;

namespace tabuleiro
{
    class Posicao
    {
        
        public int linha { get; set; }
        public int colunas { get; set; }

        public Posicao(int linha, int colunas)
        {
            this.linha = linha;
            this.colunas = colunas;
        }

        public override string ToString()
        {
            return $"{linha}, {colunas}";
        }
    }
}
