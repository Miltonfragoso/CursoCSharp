/*     Nullable
       • É um recurso de C# para que dados de tipo valor (structs) possam
       receber o valor null
       • Uso comum:
       • Campos de banco de dados que podem valer nulo (data de nascimento,
       algum valor numérico, etc.).

       • usamos o nullable para Dados e parâmetros opcionais.

       • Métodos: do nullable
                        • GetValueOrDefault(Pega o valor de x, se não existir pega o valor padrão que é zero)
                        • HasValue(existe valor?) vai retornar boleano verdadeiro ou falso
                        • Value (pegar o valor direto na variável se não tiver valor lança uma exceção se não houver valor)
                        • Um nullable não pode ser atribuído para um struct comum
                        • Valor default para tipos:

*/

using System;

namespace Nullable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // double x = null; da erro 

            //para resolver usamos o nullable sua sintaxe é a interrogação (?)
            double? x = null;
            double? y = 10.0;
            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            // tratando a escessão que o métoro value lança caso não houver valor
            if (x.HasValue)

                Console.WriteLine(x.Value);


            else

                Console.WriteLine("x is null");


            if (y.HasValue)
                Console.WriteLine(y.Value);
            else
                Console.WriteLine("y is null");



            /*OPERADOR DE COALESCÊNCIA NULA (??)
             * resultado = x ?? y ; verifica, se x for null resultado rece y se não, resultado recebe valor de x.
             */

            double? a = null;
            double? b = 10.00;


            double? c = a ?? 5;
            double? d = b ?? 20;

            Console.WriteLine(c);
            Console.WriteLine(d);


        }
    }
}
