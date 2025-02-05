using System;
using System.Globalization;

namespace ExercicioEstrtuturaParaFor04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             *  Fazer um programa para ler um número N. Depois leia N pares de números e mostre a divisão do primeiro pelo
                segundo. Se o denominador for igual a zero, mostrar a mensagem "divisao impossivel".
             */

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                double x = double.Parse(valores[0], CultureInfo.InvariantCulture);
                double y = double.Parse(valores[1], CultureInfo.InvariantCulture);

                if (y == 0)
                {
                    Console.WriteLine("Divisão impossivel");
                }
                else
                {
                    double div = (double)x / y;
                    Console.WriteLine(div.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
