/*     ---------------------        OS 3 PILARES DA PROGRAMAÇÃO ORIENTADA A OBJETOS   ----------------------------   *
 *                                                            EMCAPSULAMENTO
 *                                                               HERANÇA
 *                                                             POLIMORFISMO   
 */
using System;
using System.Globalization;

namespace ExercicioTrianguloComPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarãção das variáveis recebendo o tipo da class
            Triangulo X, Y;

            //Alem da declaração, precisamos instancia-las também
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


            //double p = (X.A + X.B + X.C) / 2.0;
            //double areaX = Math.Sqrt(p * (p - X.A) * (p - X.B) * (p - X.C));

            //p = (Y.A + Y.B + Y.C) / 2.0;
            //double areaY = Math.Sqrt(p * (p - Y.A) * (p - Y.B) * (p - Y.C));


            //chamada do método área para calcular as áreas de x e y.
            double areaX = X.Area();
            double areaY = X.Area();

            Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            //verificação do maior
            if (areaX > areaY)
            {
                Console.WriteLine("Maior área do triângulo: X");
            }
            else if (areaY > areaX)
            {
                Console.WriteLine("Maior área do triângulo: Y");
            }
            else
            {
                Console.WriteLine("As áreas são iguais");
            }
        }
    }
}
