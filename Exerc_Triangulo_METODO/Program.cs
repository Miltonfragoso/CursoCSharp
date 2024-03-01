using System;
using System.Globalization;

namespace Exerc_Triangulo_METODO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo X = new Triangulo();
            Triangulo Y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triangulo X: ");
            X.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            X.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            X.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("Entre com as medidas do triangulo Y: ");
            Y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);



            double areaX = X.Area();
            double areaY = Y.Area();



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
