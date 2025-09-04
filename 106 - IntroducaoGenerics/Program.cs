/* PROBLEMA: PARA DEMOSTRAR O REUSO DE CÓDIGO COM GENERICS
 * Deseja-se fazer um programa que leia um conjunto de N números inteiros (N de
    1 a 10), e depois imprima esses números de forma organizada conforme
    exemplo. Em seguida, informar qual foi o primeiro valor informado.

How many values? 3 de impressão:
10
8
23
[10, 8, 23]
First: 10

Criar um serviço de impressão

+ addValor(value : int) void
+primeiro() int
+ imprimir() void


 */
using System;

namespace IntroducaoGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ImpressaoService impressaoService = new ImpressaoService();

            Console.Write("How many values? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int value = int.Parse(Console.ReadLine());
                impressaoService.AddValor(value);
            }

            impressaoService.Imprimir();

            Console.WriteLine("Primeiro: " + impressaoService.Primeiro());
        }
    }
}
