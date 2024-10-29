using System;
using System.Globalization;

namespace ExercEstruSequenc05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o
             código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.
            */

            Console.WriteLine("Entrada:");
            string[] vet1 = Console.ReadLine().Split(' ');
            int cod1 = int.Parse(vet1[0]);
            int Qtpeca1 = int.Parse(vet1[1]);
            double valorpeca1 = double.Parse(vet1[2], CultureInfo.InvariantCulture);

            string[] vet2 = Console.ReadLine().Split(' ');
            int cod2 = int.Parse(vet2[0]);
            int Qtpeca2 = int.Parse(vet2[1]);
            double valorpeca2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);

            double valorAserPago = (Qtpeca1 * valorpeca1) + (Qtpeca2 * valorpeca2);

            Console.WriteLine("Saída:");
            Console.WriteLine("VALOR A PAGAR: R$ " + valorAserPago.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
