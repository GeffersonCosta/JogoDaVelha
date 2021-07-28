using System;
using System.Collections.Generic;
using System.Text;

namespace JogoDaVelhaN.Entities
{
   public class Tabuleiro
    {
       public static void tabuleiro()
        {
            string[,] vet = new string[3, 3];
            int cont = 1;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    vet[i, j] = Convert.ToString(cont);
                    cont++;
                    Console.Write("[" + vet[i, j] + "]");
                }
                Console.WriteLine();
            }
          

        }
    }
}
