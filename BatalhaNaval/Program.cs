using BatalhaNaval.Lógica_de_jogo;
using BatalhaNaval.Tabuleiro;
using System;


namespace BatalhaNaval
{


    class Program
    {
        static void Main(string[] args)
        {
            MostrarTabuleiro tabuleiro = new MostrarTabuleiro(10,10);

            
                        
            MostrarTabuleiro.posicaoDosNavios(tabuleiro);
            MostrarTabuleiro.imprimirTabuleiroJogador(tabuleiro);

            MostrarTabuleiro.colocarPosicao(tabuleiro);
            /*Console.Clear();*/
            MostrarTabuleiro.imprimirTabuleiroJogador(tabuleiro);





        }

    }
}

