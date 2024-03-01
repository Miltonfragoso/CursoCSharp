using System;
using System.Globalization;

namespace Exerc_Triangulo_CLASS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo X, Y;

             X = new Triangulo();
             Y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triangulo X: ");
            X.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            X.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            X.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("Entre com as medidas do triangulo Y: ");
            Y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            double p = (X.A + X.B + X.C) / 2.0;
            double areaX = Math.Sqrt(p * (p - X.A) * (p - X.B) * (p - X.C));

            p = (Y.A + Y.B + Y.C) / 2.0;
            double areaY = Math.Sqrt(p * (p - Y.A) * (p - Y.B) * (p - Y.C));

            Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }
        }
    }
}
