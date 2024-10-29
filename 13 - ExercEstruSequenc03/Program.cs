using System;

namespace ExercEstruSequenc03
{
    internal class Program
    {
        static void Main(string[] args)
        {
              /*Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto
              de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).*/
            Console.WriteLine("Entrada:");
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int D = int.Parse(Console.ReadLine());

            int DIFERENCA = (A * B) - (C * D);

            Console.WriteLine("Saída:");
            Console.WriteLine("DIFERENCA = " + DIFERENCA);
        }
    }
}
