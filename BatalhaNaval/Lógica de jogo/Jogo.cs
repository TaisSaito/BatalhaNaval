using BatalhaNaval.Tabuleiro;
using System;
using System.Globalization;
using System.Linq.Expressions;
using System.Threading;

namespace BatalhaNaval.Lógica_de_jogo
{
    public class Jogo
    {
        MostrarTabuleiro tab;
        string[,] pecas;


        public static string EscolhePosicao()
        {
            
            bool testePosicao = false;
            string posicaoEscolhida;

            while (!testePosicao)
            {
                try
                {
                    Console.Write("Escolha a posição que deseja jogar: ");
                    posicaoEscolhida = Console.ReadLine();
                    string[] posicaoSeparada = posicaoEscolhida.Split();
                   

                    string primeiroElemento = posicaoSeparada[0].ToString();
                    /*string segundoElemento = posicaoSeparada[1].ToString();*/


                    if (primeiroElemento.Equals("a", StringComparison.OrdinalIgnoreCase) ||
                        primeiroElemento.Equals("b", StringComparison.OrdinalIgnoreCase) ||
                        primeiroElemento.Equals("c", StringComparison.OrdinalIgnoreCase) ||
                        primeiroElemento.Equals("d", StringComparison.OrdinalIgnoreCase) ||
                        primeiroElemento.Equals("e", StringComparison.OrdinalIgnoreCase) ||
                        primeiroElemento.Equals("f", StringComparison.OrdinalIgnoreCase) ||
                        primeiroElemento.Equals("g", StringComparison.OrdinalIgnoreCase) ||
                        primeiroElemento.Equals("h", StringComparison.OrdinalIgnoreCase) ||
                        primeiroElemento.Equals("i", StringComparison.OrdinalIgnoreCase) ||
                        primeiroElemento.Equals("j", StringComparison.OrdinalIgnoreCase)
                        )
                    {
                        testePosicao = true;
                        
                    }
                    if (posicaoSeparada[1].Equals("1") ||
                        posicaoSeparada[1].Equals("2") ||
                        posicaoSeparada[1].Equals("3") ||
                        posicaoSeparada[1].Equals("4") ||
                        posicaoSeparada[1].Equals("5") ||
                        posicaoSeparada[1].Equals("6") ||
                        posicaoSeparada[1].Equals("7") ||
                        posicaoSeparada[1].Equals("8") ||
                        posicaoSeparada[1].Equals("9") ||
                        posicaoSeparada[1].Equals("10")
                        )
                    {
                        
                        testePosicao = true;
                    }
                    else
                    {
                        testePosicao = false;
                    }

                    /*while (posicaoEscolhida == null || posicaoEscolhida.Length > 4 || testePosicao == false) ;*/
                    
                    return posicaoEscolhida;
                }



                catch (Exception ex)
                {
                    Console.WriteLine("Escreva a letra e o número com um espaço entre eles, ex: a 1");

                }
                
            }
            return "Tente outra vez";
        }
    






    public static Tuple<int, int> jogada(MostrarTabuleiro tab)
    {

        string[] jogadaEscolhida = EscolhePosicao().Split();
        string letra = jogadaEscolhida[0];
        string numero = jogadaEscolhida[1];
        int letraConvertida = 1;
        int numeroConvertido = 2;


        // Converte a letra no número da linha
        if (letra == "a")
            letraConvertida = 0;

        else if (letra == "b")
            letraConvertida = 1;

        else if (letra == "c")
            letraConvertida = 2;

        else if (letra == "d")
            letraConvertida = 3;

        else if (letra == "e")
            letraConvertida = 4;

        else if (letra == "f")
            letraConvertida = 5;

        else if (letra == "g")
            letraConvertida = 6;

        else if (letra == "h")
            letraConvertida = 7;

        else if (letra == "i")
            letraConvertida = 8;



        else if (letra == "j")
            letraConvertida = 9;



        //Converte o número no número da coluna
        if (numero == "1")
            numeroConvertido = 0;

        else if (numero == "2")
            numeroConvertido = 1;

        else if (numero == "3")
            numeroConvertido = 2;

        else if (numero == "4")
            numeroConvertido = 3;

        else if (numero == "5")
            numeroConvertido = 4;

        else if (numero == "6")
            numeroConvertido = 5;

        else if (numero == "7")
            numeroConvertido = 6;

        else if (numero == "8")
            numeroConvertido = 7;

        else if (numero == "9")
            numeroConvertido = 8;

        else if (numero == "10")
            numeroConvertido = 9;

        var resultado = new Tuple<int, int>(letraConvertida, numeroConvertido);

        return resultado;




    }

}
}

