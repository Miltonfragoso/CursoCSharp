
/*LISTAS: contem dados do mesmo tipo, os elementos são acessados por meio de posições, inícia vazia e seus elementos são alocados sob demanda,
 cada elemento ocupa um nó ou nodo da lista.
*
*Classe List: utilizamos a lista com a class list que pertence ao namespace System.colletions.generic;
*
*Vantagens: Tamanho variável, começa vazia e vamos adicionando elementos, facilidade de inserir e remover elementos
*Desvantagens: acesso sequencial e não direito a posição do elemento
*/
using System;
using System.Collections.Generic;

namespace Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //cria uma lista vazia
            List<String> list = new List<String>();


            //cria a lista e já adicionamos elementos nela
            List<String> list2 = new List<String> { " Milton ", " Danilsa ", " Yahminah "};
        }
    }
}
