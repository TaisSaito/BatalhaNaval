using BatalhaNaval.Lógica_de_jogo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace BatalhaNaval.Tabuleiro
{
    public class MostrarTabuleiro
    {
       public int linhas;
       public int colunas;
       public string[,] pecas;


        public MostrarTabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new String[linhas, colunas];
        }

        public static void imprimirTabuleiroJogador(MostrarTabuleiro tab)
        {
            Console.WriteLine("  -----------------------------------------");
            for (int i = 0; i < tab.linhas; i++)
            {
                if (i + 1 < 10)
                {
                    Console.Write(i + 1 + " |");
                }
                else
                {
                    Console.Write(i + 1+"|");
                }
                for (int j = 0; j < tab.colunas; j++)
                {
                   
                    if (tab.pecas[i, j] == null)
                    {
                        Console.Write(" ");
                    }
                    else if (tab.pecas[i,j] == "X")
                    {
                        
                    }
                    Console.Write($" {tab.pecas[i, j]} |");
                    
                }
                
               Console.WriteLine();
                Console.WriteLine("  -----------------------------------------");
               
            }
            Console.WriteLine("    A   B   C   D   E   F   G   H   I   J");
           
        }

        

        public static void posicaoDosNavios(MostrarTabuleiro tab)
        {
            //Tamanhos dos navios
            int tamanho4 = 4;
            int tamanho3 = 3;
            int tamanho2 = 2;
            int tamanho1 = 1;

            // Quantidade de navios de cada tamanho
            int quantidadeTamanho4 = 1;
            int quantidadeTamanho3 = 2;
            int quantidadeTamanho2 = 3;
            int quantidadeTamanho1 = 4;

            /*int quantidadeNavio = 4;
            int tamanhoNavio = 1;*/

            //preenchendo o tabuleiro com "água"
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    tab.pecas[i, j] = "~";
                }
            }


            // Gerando posições aleatórias para os navios
            Random random = new Random();

            // 4 Navios de tamanho 1
            for (int i = 0; i < quantidadeTamanho1; i++)
            {
                int row = random.Next(0, 10 - tamanho1);
                int col = random.Next(0, 10 - tamanho1);
                int orientation = random.Next(0, 2);

                if (orientation == 0)
                {
                    // Posicionando o navio na horizontal
                    for (int j = 0; j < tamanho1; j++)
                    {
                        tab.pecas[row, col + j] = "1";
                    }
                }
                else
                {
                    // Posicionando o navio na vertical
                    for (int j = 0; j < tamanho1; j++)
                    {
                        tab.pecas[row + j, col] = "1";
                    }
                }
            }

            // 3 Navios de tamanho 2
            for (int i = 0; i < quantidadeTamanho2; i++)
            {
                int row = random.Next(0, 10 - tamanho2);
                int col = random.Next(0, 10 - tamanho2);
                int orientation = random.Next(0, 2);

                if (orientation == 0)
                {
                    // Posicionando o navio na horizontal
                    bool canPlaceShip = true;
                    for (int j = 0; j < tamanho2; j++)
                    {
                        if (tab.pecas[row, col + j] != "~")
                        {
                            canPlaceShip = false;
                            break;
                        }
                    }
                    if (canPlaceShip)
                    {
                        for (int j = 0; j < tamanho2; j++)
                        {
                            tab.pecas[row, col + j] = "2";
                        }
                    }
                    else
                    {
                        i--;
                    }
                }
                else
                {
                    // Posicionando o navio na vertical
                    bool canPlaceShip = true;
                    for (int j = 0; j < tamanho2; j++)
                    {
                        if (tab.pecas[row + j, col] != "~")
                        {
                            canPlaceShip = false;
                            break;
                        }
                    }
                    if (canPlaceShip)
                    {
                        for (int j = 0; j < tamanho2; j++)
                        {
                            tab.pecas[row + j, col] = "2";
                        }
                    }
                    else
                    {
                        i--;
                    }
                }
            }
            // 2 Navios de tamanho 3
            for (int i = 0; i < quantidadeTamanho3; i++)
            {
                int row = random.Next(0, 10 - tamanho3);
                int col = random.Next(0, 10 - tamanho3);
                int orientation = random.Next(0, 2);

                if (orientation == 0)
                {
                    // Posicionando o navio na horizontal
                    bool canPlaceShip = true;
                    for (int j = 0; j < tamanho3; j++)
                    {
                        if (tab.pecas[row, col + j] != "~")
                        {
                            canPlaceShip = false;
                            break;
                        }
                    }
                    if (canPlaceShip)
                    {
                        for (int j = 0; j < tamanho3; j++)
                        {
                            tab.pecas[row, col + j] = "3";
                        }
                    }
                    else
                    {
                        i--;
                    }
                }
                else
                {
                    // Posicionando o navio na vertical
                    bool canPlaceShip = true;
                    for (int j = 0; j < tamanho3; j++)
                    {
                        if (tab.pecas[row + j, col] != "~")
                        {
                            canPlaceShip = false;
                            break;
                        }
                    }
                    if (canPlaceShip)
                    {
                        for (int j = 0; j < tamanho3; j++)
                        {
                            tab.pecas[row + j, col] = "3";
                        }
                    }
                    else
                    {
                        i--;
                    }
                }
            }

            // 1 Navio de tamanho 4
            for (int i = 0; i < quantidadeTamanho4; i++)
            {
                int row = random.Next(0, 10 - tamanho4);
                int col = random.Next(0, 10 - tamanho4);
                int orientation = random.Next(0, 2);

                if (orientation == 0)
                {
                    // Posicionando o navio na horizontal
                    bool canPlaceShip = true;
                    for (int j = 0; j < tamanho4; j++)
                    {
                        if (tab.pecas[row, col + j] != "~")
                        {
                            canPlaceShip = false;
                            break;
                        }
                    }
                    if (canPlaceShip)
                    {
                        for (int j = 0; j < tamanho4; j++)
                        {
                            tab.pecas[row, col + j] = "4";
                        }
                    }
                    else
                    {
                        i--;
                    }
                }
                else
                {
                    // Posicionando o navio na vertical
                    bool canPlaceShip = true;
                    for (int j = 0; j < tamanho4; j++)
                    {
                        if (tab.pecas[row + j, col] != "~")
                        {
                            canPlaceShip = false;
                            break;
                        }
                    }
                    if (canPlaceShip)
                    {
                        for (int j = 0; j < tamanho4; j++)
                        {
                            tab.pecas[row + j, col] = "4";
                        }
                    }
                    else
                    {
                        i--;
                    }
                }
            }

        }


        public static void colocarPosicao(MostrarTabuleiro tab)
        {
            var resultado = Jogo.jogada(tab);

            int letraConvertida = resultado.Item1;
            int numeroConvertido = resultado.Item2;
            // Printando escolha no tabuleiro
            if (tab.pecas[numeroConvertido, letraConvertida].Equals("~"))
                tab.pecas[numeroConvertido, letraConvertida] = " ";

            else
                tab.pecas[numeroConvertido, letraConvertida] = "X";

        }






        /*public static void imprimirTabuleiroOponente(MostrarTabuleiro tab)
        {
            Console.WriteLine("-----------------------------------------");
            for (int i = 0; i < tab.linhas; i++)
            {
                Console.Write("|");
                for (int j = 0; j < tab.colunas; j++)
                {
                    if (tab.pecas[i, j] == null)
                    {
                        Console.Write(" ");
                    }
                    Console.Write($" {tab.pecas[i, j]} |");
                }

                Console.WriteLine();
                Console.WriteLine("-----------------------------------------");
            }
        }*/
    }
}
