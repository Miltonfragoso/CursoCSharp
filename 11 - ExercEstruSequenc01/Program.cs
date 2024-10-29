using System;

namespace ExercEstruSequenc01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma
               mensagem explicativa, conforme exemplos.
             */

            Console.WriteLine("Entrada:");
            int N1 = int.Parse(Console.ReadLine());
            int N2 = int.Parse(Console.ReadLine());

            int soma = N1 + N2;
            Console.WriteLine();
            Console.WriteLine("Saída");
            Console.WriteLine("SOMA = " + soma);
        }
    }
}
