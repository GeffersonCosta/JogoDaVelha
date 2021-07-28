using System;
using System.Collections.Generic;
using System.Text;

namespace JogoDaVelhaN.Entities
{
    class MudarJogador
    {
        public string JogadorX { get; set; }

        public MudarJogador(string jogadorX)
        {
            JogadorX = jogadorX;
        }

        public MudarJogador()
        {
        }
        public string TrocarPlay(string jogada)
        {
            string jogador;
            if (jogada == "X" )
            {
                jogador = "O";
            }
            else
            {
                jogador = "X";
            }
            return jogador;
        }

        
      
    }
}
