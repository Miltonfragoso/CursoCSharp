using System;
using System.Collections.Generic;
using System.Text;

namespace ModificadorDePrametrosParams
{
    internal class Calculadora
    {
        /* SOLUÇÃO RUIM Conforme a necessidade de mais calculos criamos mais sobrecarga o que torna uma solução RUIM*/
        public static int sum(int n1, int n2)
        {
            return n1 + n2;
        }
        public static int sum(int n1, int n2, int n3)
        {
            return n1 + n2 + n3;
        }

        public static int sum(int n1, int n2, int n3, int n4)
        {
            return n1 + n2 + n3 + n4;
        }

        /*-----------------------------SOLUÇÃO QUASE BOA: FUNÇÃO SOMA QUE RECEBE UM VETOR-----------------*/

        public static int Soma(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++) {
                sum = sum + numbers[i];
            }
            return sum;
        }


        /*Solução Boa: Adicionamos a palavra PARAMS QUE AVISA AO COMPILADOR QUE PODE SER ADICIONADO UMA QUANTIA VARIADA DE PARAMETROS*/
        public static int SomaBoa(params int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum = sum + numbers[i];
            }
            return sum;
        }
    }
}


