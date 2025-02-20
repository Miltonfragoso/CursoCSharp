/*Modificador de parametros REF: ele ajuda nas funções cujo o retorno é um Void
 *Se não usarmos o REF tanto na função quanto na sua chamada ele não vai alterar o valor da variável na memoria  Steak 
 *somente na função que esta  na Head o REF vai apontar o resultado da função para a variável na stack como uma referencia
 */


/*Modificador de parametros OUT: ele ajuda nas funções cujo o retorno é um Void
 *Se não usarmos o OUT tanto na função quanto na sua chamada ele não vai alterar o valor da variável na memoria  Steak 
 *somente na função que esta  na Head o OUT vai apontar o resultado da função para a variável na stack como uma referencia
 *O OUT NÃO EXIGE QUE A VARIÁVEL IRIGINAL OU NA STACK SEJA INICIADA OUT É UMA VARIÁVEL DE SAÍDA
 */


using System;

namespace ModificadorDePrarametrosREFeOUT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Calculadora.Triplicar(a);

            Console.WriteLine(a);


            int b = 10;
            int resultado;

            Calculadora.Triplicar2(b, out resultado);
            Console.WriteLine(resultado);
        }
    }
}
