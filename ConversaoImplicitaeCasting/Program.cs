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

            //Conversão explicita (Casting)

            double a;
            float b;

            a = 5.1;

            b = (float)a;
            Console.WriteLine(b);



            double c;
            int d;

            c = 5.1;

            d = (int)a;
            Console.WriteLine(d);

        }
    }
}
