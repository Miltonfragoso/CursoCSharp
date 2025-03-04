/*Fazer um programa para ler um número inteiro N e uma matriz de orden N contendo números inteiros
 * Em seguida, mostrar a diagonal principal e a quantidade de valores negativos da matriz
 */
using System;

namespace MatrizesNaPratica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qua é o número de linhas e colunas da matriz?: ");
            int N = int.Parse(Console.ReadLine());

            int[,] matriz = new int[N, N];

            //for para percorrer as linhas
            for(int i  = 0; i < N; i++)
            {
                string[] valor = Console.ReadLine().Split(' ');
                //for para percorrer as colunas
                for(int j = 0; j < N; j++)
                {
                    matriz[i,j] = int.Parse(valor[j]);
                }

            }

            Console.WriteLine("Diagonal principal: ");
            for (int i = 0; i < N; i++) {
                Console.Write(matriz[i,i] + " ");
            }

            Console.WriteLine("Contagem de números negativos na matriz");
            //estrutura basica para percorrer uma matriz inteira(for para linhas e for para colunas )

            int contagem = 0;

            for (int i = 0; i < N; i++) { 
                for(int j = 0; j < N; j++)
                {
                    if (matriz[i,j] < 0)
                    {
                        contagem++;
                    }
                }
            }

            Console.Write("Números negativos: "+ contagem);
        }
    }
}
