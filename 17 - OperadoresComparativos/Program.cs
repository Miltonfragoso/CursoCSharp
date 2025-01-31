using System;

namespace _17___OperadoresComparativos
{
    internal class Program
    {
        /* >  maior
         * <  menor
         * >= maior ou igual
         * <= menor ou igual
         * == igual
         * != diferente
         */
        static void Main(string[] args)
        {
            int a = 10;

            Console.WriteLine("10 é menor que 10?");
            bool c1 = a < 10;
            Console.WriteLine(c1);

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("10 é maior que 5?");
            bool c2 = a > 5;
            Console.WriteLine(c2);

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("10 é menor ou igual a 10?");
            bool c3 = a <= 10;
            Console.WriteLine(c3);
            Console.WriteLine("------------------------------------------");

            Console.WriteLine("10 é maior ou igual a 5?");
            bool c4 = a >= 5;
            Console.WriteLine(c4);
            Console.WriteLine("---------------------------------------------");

            Console.WriteLine("10 é igual a 10?");
            bool c5 = a == 10;
            Console.WriteLine(c5);
            Console.WriteLine("------------------------------------------");

            Console.WriteLine("10 é diferente de 10?");
            bool c6 = a != 10;
            Console.WriteLine(c6);
        }
    }
}
