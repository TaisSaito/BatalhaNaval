using System;
using System.Globalization;
using System.Threading;

namespace BatalhaNaval.Lógica_de_jogo
{
    public class Jogo
    {


        public static string escolhePosicao()
        {
            bool testePosicao;
            string posicaoEscolhida;
            do
            {
                Console.Write("Escolha a posição que deseja jogar: ");
                posicaoEscolhida = Console.ReadLine();
                string[] posicaoSeparada = posicaoEscolhida.Split();
                

                if (posicaoSeparada[0].Equals("a", StringComparison.OrdinalIgnoreCase) ||
                    posicaoSeparada[0].Equals("b", StringComparison.OrdinalIgnoreCase) ||
                    posicaoSeparada[0].Equals("c", StringComparison.OrdinalIgnoreCase) ||
                    posicaoSeparada[0].Equals("d", StringComparison.OrdinalIgnoreCase) ||
                    posicaoSeparada[0].Equals("e", StringComparison.OrdinalIgnoreCase) ||
                    posicaoSeparada[0].Equals("f", StringComparison.OrdinalIgnoreCase) ||
                    posicaoSeparada[0].Equals("g", StringComparison.OrdinalIgnoreCase) ||
                    posicaoSeparada[0].Equals("h", StringComparison.OrdinalIgnoreCase) ||
                    posicaoSeparada[0].Equals("i", StringComparison.OrdinalIgnoreCase) ||
                    posicaoSeparada[0].Equals("j", StringComparison.OrdinalIgnoreCase)
                    )
                {
                    testePosicao = true;
                }
                else if (posicaoSeparada[1].Equals("1") ||
                    posicaoSeparada[1].Equals("2") ||
                    posicaoSeparada[1].Equals("3") ||
                    posicaoSeparada[1].Equals("4") ||
                    posicaoSeparada[1].Equals("5") ||
                    posicaoSeparada[1].Equals("6") ||
                    posicaoSeparada[1].Equals("7") ||
                    posicaoSeparada[1].Equals("8") ||
                    posicaoSeparada[1].Equals("9") ||
                    posicaoSeparada[1].Equals("10"))
                {
                    testePosicao = true;
                }
                else
                {
                    testePosicao = false;
                }
            }
            while (posicaoEscolhida == null || posicaoEscolhida.Length > 2 || testePosicao == false);

            return posicaoEscolhida;
        }




    }
}
