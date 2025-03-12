/*
 * Fazer um programa para ler dois números inteiros M e N, e depois ler
    uma matriz de M linhas por N colunas contendo números inteiros,
    podendo haver repetições. Em seguida, ler um número inteiro X que
    pertence à matriz. Para cada ocorrência de X, mostrar os valores à
    esquerda, acima, à direita e abaixo de X, quando houver, conforme
    exemplo.
 */

using System;

namespace _65___ExercicioMatriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //vetor para linhas e colunas 
            string[] linha =  Console.ReadLine().Split(' ');

            // variável m = linhas, variável n = colunas adicionadas no vetor linhas
            int m = int.Parse(linha[0]);
            int n = int.Parse(linha[1]);
            Console.WriteLine();




            // declaração e inicialização da matriz recebendo os valores de linhas e colunas
            int[,] mat = new int[m, n];

            // for para percores o total de linhas
            for (int i = 0; i < m; i++)
            {
                //vetor para receber os valores a ser adicionado nas colunas que esta linha possui
                Console.WriteLine("Digite os valores desta linha, conrrespondente as suas colunas");
                string[] valor = Console.ReadLine().Split(" ");

                //for para percorer as colunas 
                for (int j = 0; j < n; j++)
                {
                    mat[i,j] = int.Parse(valor[j]);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Digite um numero pertencente a sua matriz");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0;i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if(mat[i,j] == x)
                    {
                        Console.WriteLine("Posição" + i + "," + j + ":");
                        if(j > 0)
                        {
                            Console.WriteLine("Diteita:" + mat[i, j - 1]);
                        }

                        if (i > 0)
                        {
                            Console.WriteLine("acima:" + mat[i - 1, j]);
                        }

                        if (j < n - 1)
                        {
                            Console.WriteLine("esquerda:" + mat[i, j + 1]);
                        }

                        if (j < m - 1)
                        {
                            Console.WriteLine("baixo:" + mat[i + 1, j]);
                        }
                    }
                }
            }
        }
    }
}
