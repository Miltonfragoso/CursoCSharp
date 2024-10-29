using System;
using System.Globalization;

namespace _12___ExercEstruSequenc02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro
              casas decimais conforme exemplos.
              Fórmula da área: area = π . raio2
              Considere o valor de π = 3.14159*/

            Console.WriteLine("Entrada:");
            double N1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = 3.14159;

            double Area = Math.Pow(N1, 2.0) * p;

            Console.WriteLine();

            Console.WriteLine("Saída:");
            Console.WriteLine("A=" + Area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
