/*Em programação "Matriz" é o nome dado a arranjos bidimensionais (Linhas e Colunas)
 *A matriz também possui dados homogênios do mesmo tipo
 *elementos acessados por meio de posições
 *quando instanciada a matriz, precisamos falar o seu tamanho igual a vetores
 */
using System;

namespace Matrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[,] matriz = new double[2, 3];

            //Função Length: total de linhas e colunas
            Console.WriteLine(matriz.Length);

            //Função Rank: total de linhas
            Console.WriteLine(matriz.Rank);
        }
    }
}
