using System;
using System.Globalization;

namespace ExercicioTrianguloSemPOO
{
    internal class Program
    {
          /*Fazer um programa para ler as medidas dos lados de dois triângulos X e Y(suponha medidas
            válidas). Em seguida, mostrar o valor das áreas dos dois triângulos e dizer qual dos dois triângulos
            possui a maior área.
            A fórmula para calcular a área de um triângulo a partir das medidas de seus lados a, b e c, é a
            seguinte(fórmula de Heron): ÁREA= Raizdep(p - a)(p - b)(p - c) onde p = a+b+c div/2  */
           
        static void Main(string[] args)
        {
            double XA, XB, XC, YA, YB, YC;

            Console.WriteLine("Entre com as medidas do triângulo X");
            XA = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            XB = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            XC = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y");
            YA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            YB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            YC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (XA + XB + XC) / 2.0;
            double areaX = Math.Sqrt(p * (p - XA) * (p - XB) * (p - XC));


             p = (YA + YB + YC) / 2.0;
            double areaY = Math.Sqrt(p * (p - YA) * (p - YB) * (p - YC));

            Console.WriteLine("Área de x = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if(areaX > areaY)
            {
                Console.WriteLine("Maior área do triângulo: X");
            }
            else if(areaY > areaX) 
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
