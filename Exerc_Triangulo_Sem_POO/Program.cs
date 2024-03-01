using System;
using System.Globalization;

namespace Exerc_Triangulo_Sem_POO
{
         /* Fazer um programa para ler as medidas dos lados de dois triângulos X e Y (suponha medidas
        válidas). Em seguida, mostrar o valor das áreas dos dois triângulos e dizer qual dos dois triângulos
        possui a maior área.
        A fórmula para calcular a área de um triângulo a partir das medidas de seus lados a, b e c é a
        seguinte (fórmula de Heron):
        area = Raiz de p( p - a)( p - b)( p - c)
        
        p= (a + b + c)/2  */
    internal class Program
    {
        static void Main(string[] args)
        {
            double XA, XB, XC, yA, yB, yC;

            Console.WriteLine("Entre com as medidas do triangulo X: ");
            XA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            XB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            XC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("Entre com as medidas do triangulo Y: ");
            yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            double p = (XA + XB + XC) / 2.0;
            double areaX = Math.Sqrt(p * (p - XA) * (p - XB) * (p - XC));

            p = (yA + yB + yC) / 2.0;
            double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

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
