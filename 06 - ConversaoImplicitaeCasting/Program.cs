using System;

namespace ConversaoImplicitaeCasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Conversão implícita 4b em 8b

            float x = 4.5f;

            double y = x;

            Console.WriteLine(y);

            //Conversão explicita de topo usa o (Casting)

            double a;
            float b;

            a = 5.1;

            //casting
            b = (float)a;
            Console.WriteLine(b);


            // 8b e valor quebrado em 4b inteiro
            double c;
            int d;

            c = 5.1;

            d = (int)c;
            Console.WriteLine(d);

            int e = 5;
            int f = 2;

            //casting
            double resultado = (double)e / f;
            Console.WriteLine(resultado);
        }
    }
}
