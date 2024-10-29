using System;
using System.Globalization;

namespace ExercEstruSequenc06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e
             mostre:
             a) a área do triângulo retângulo que tem A por base e C por altura.
             b) a área do círculo de raio C. (pi = 3.14159)
             c) a área do trapézio que tem A e B por bases e C por altura.
             d) a área do quadrado que tem lado B.
             e) a área do retângulo que tem lados A e B.
            */
            Console.WriteLine("Entrada: ");
            string[] vet = Console.ReadLine().Split(' ');
            double A = double.Parse(vet[0], CultureInfo.InvariantCulture);
            double B = double.Parse(vet[1], CultureInfo.InvariantCulture);
            double C = double.Parse(vet[2], CultureInfo.InvariantCulture);

            /* Área do triângulo (A=base*altura/2 */
            double areaDoTriangulo = (A * C) / 2;

            /* Área da circunferência (A = pi* raio^2) */
            double areaDaCircunferencia = 3.14159 * Math.Pow(C, 2);

            /* Área do Trapézio (A = (B+b)*h/2) */
            double areaDoTrapezio = (A + B) * C / 2;

            /* Área do Quadrado (A = (B)^2 */
            double areaDoQuadrado = Math.Pow(B, 2);

            /* Área do Retangulo (A = b*h */
            double areaDoRetangulo = A * B;

            Console.WriteLine("TRIANGULO: " + areaDoTriangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRIANGULO: " + areaDaCircunferencia.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRIANGULO: " + areaDoTrapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRIANGULO: " + areaDoQuadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRIANGULO: " + areaDoRetangulo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
