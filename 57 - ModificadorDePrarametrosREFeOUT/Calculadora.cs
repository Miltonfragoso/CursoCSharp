using System;
using System.Collections.Generic;
using System.Text;

namespace ModificadorDePrarametrosREFeOUT
{
    internal class Calculadora
    {
        //Uma função para triplicar o valor de um número
        public static void Triplicar(int x)
        {
            x = x * 3; 
        }

        /*Neste exemplo a função recebe dois parametros, um que é o valor a ser triplicado o outro uma variável para armazenar o resultado*/
        public  static void Triplicar2(int origem, out int triplicar)
        {
            triplicar = origem * 3;
        }
    }
}
