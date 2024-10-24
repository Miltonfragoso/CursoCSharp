using System;

namespace _02___Comentarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Comentário de uma única linha

            /* Comentário
             * de múltiplas
             * linhas 
             */

            adicionar(10, 11);
        }

        //se fizermos um comentário de 3 linhas teremos a extrutura abaixo e onde usarmos a função adicionar teremos uma descrição


        /// <summary>
        /// Executa a adição de valores a e  b 
        /// </summary>
        /// <param name="a">Parcela 1</param>
        /// <param name="b">Parcela 2</param>
        static void adicionar(int a, int b)
        {

        }
    }
}

