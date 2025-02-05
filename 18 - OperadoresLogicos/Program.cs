using System;

namespace OperadoresLogicos
{
    internal class Program
    {
        //Operadores lógicos mais utilizados são:                              
        /* E   (&&) As 2 condições tem de ser verdadeira
           OU  (||) Pelo menos uma ou as 2 condições tem de ser verdadeira
           NÃO (!)
        */

        /*PRESEDÊNCIA
         * Operador NÃO ! > && > ||
         */
        static void Main(string[] args)
        {
            bool c1 = 4 != 5;
            Console.WriteLine(c1);

            bool c2 = 2 > 3 && 4 != 5;
            Console.WriteLine(c2);

            bool c3 = 2 > 3 || 4 != 5;
            Console.WriteLine(c3);


            bool c4 = !(2 > 3) && 4 != 5;
            Console.WriteLine(c4);

            Console.WriteLine("----------------------------");

            bool c5 = 10 < 5;
            bool c6 = c3 || c4 && c5;

            Console.WriteLine(c5);
            Console.WriteLine(c6);
        }
    }
}
