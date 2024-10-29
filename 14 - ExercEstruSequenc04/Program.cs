using System;
using System.Globalization;

namespace _14___ExercEstruSequenc04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por
              hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas
              decimais.
            */


            Console.WriteLine("Entrada:");

            int N1 = int.Parse(Console.ReadLine());
            int N2 = int.Parse(Console.ReadLine());
            double SalarioPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double SalarioMensal = N2 * SalarioPorHora;

            Console.WriteLine("Saída:");
            Console.WriteLine("NUMBER = " + N1);
            Console.WriteLine("SALARY =  U$ " + SalarioMensal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
