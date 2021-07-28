using System;
using JogoDaVelhaN.Entities;

namespace JogoDaVelhaN
{
    class Program
    {


        static void Main(string[] args)
        {
            string Vencedor = "";
            int C = 0;
            int cont = 1;
            bool R = false;
            MudarJogador trocarJogador = new MudarJogador();
            Tabuleiro.tabuleiro();
            string[,] vet = new string[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    vet[i, j] = Convert.ToString(cont);
                    cont++;

                }

            }


            string XouBola = "X";
            bool mudou = false;
            bool Terminou = false;
            //Verificar se tem jogadas valida
            while (Terminou != true)
            {
                while (R != true)
                {

                    Console.Write("Vai jogar [" + XouBola + "] em qual posição: ");
                    int posicao = int.Parse(Console.ReadLine());
                    R = volta(mudou, posicao);
                    if (R == false)
                    {
                        Console.WriteLine("Jogada invalida");
                    }

                }
                //MudarJogador
                TerminouVelha(Terminou);
                Vencedor = XouBola;
                XouBola = trocarJogador.TrocarPlay(XouBola);
                Console.Clear();
                MostrarVelha();

                R = false;
            }








            //Mostrar Tabuleiro
            void MostrarVelha()

            {
                for (
                    int i = 0; i < 3;
                    i++)
                {
                    for (int j = 0; j < 3; j++)
                    {

                        Console.Write("[" + vet[i, j] + "]");
                    }
                    Console.WriteLine();
                }
            }









            //Retorna valor logico para determinar que o vetor recebeu o valor correspondente
            bool volta(bool mudou, int posicao)
            {

                mudou = false;

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (vet[i, j] == Convert.ToString(posicao))
                        {
                            vet[i, j] = XouBola;
                            mudou = true;

                        }
                    }
                }
                return mudou;




            }


            bool TerminouVelha(bool terminou)
            {

                //Jogos em linha
                for (int i = 0; i < 2; i++)
                {
                    if (vet[i, 0] == vet[i, 1] && vet[i, 1] == vet[i, 2])
                    {
                        Terminou = true;
                    }
                }
                //Jogos em Coluna
                for (int j = 0; j < 2; j++)
                {
                    if (vet[0, j] == vet[1, j] && vet[1, j] == vet[2, j])
                    {
                        Terminou = true;
                    }
                }
                //Jogos em Diagonal
                for (int j = 0; j < 2; j++)
                {
                    if (vet[0, 0] == vet[1, 1] && vet[1, 1] == vet[2, 2])
                    {
                        Terminou = true;
                    }
                }
                for (int j = 0; j < 2; j++)
                {
                    if (vet[0, 2] == vet[1, 1] && vet[1, 1] == vet[2, 0])
                    {
                        Terminou = true;
                    }
                }
                C++;
                //Jogo em velha
                if (Terminou != true && C == 9)
                {
                    Terminou = true;
                }
               
              

                return Terminou;
            }
            Console.WriteLine("JOGO FINALIZADO");
            if (C == 9)
            {
                Console.WriteLine("Deu velha!");
            }
            else
            {
                Console.WriteLine("O jogador " + Vencedor + " Ganhou!");
            }


        }
    }
}

