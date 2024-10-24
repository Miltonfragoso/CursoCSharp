using System;

namespace _05___OperadoresDeAtribuicao
{
    internal class Program
    {
        static void Main(string[] args)
        {
             //Operador de atribuição (=)
            //Operador de atribuição comulativa
            //(+=, -=, *=, /=, %=)

            // a recebe 10 
            int a = 10;
            Console.WriteLine(a);

            // 10 + 2
            a += 2;
            Console.WriteLine(a);

            a -= 2;
            Console.WriteLine(a);

            a *= 2;
            Console.WriteLine(a);

            a /= 2;
            Console.WriteLine(a);

            a %= 2;
            Console.WriteLine(a);


            //Operador aritmético / atribuição(++; --)
            int b = 10;
            Console.WriteLine(b);

            b++;
            Console.WriteLine(b);

            int c = 10;
            Console.WriteLine(c);

            c--;
            Console.WriteLine(c);
        }
    }
}
