using System;
using System.Globalization;

namespace ExercEntradaDeDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Fazer um programa para executar a seguinte interação  com o usuário, lendo os valores, depois mostrar os dados na tela 
              (Entre com seus nome completo:
              Alex Green 
              Quantos quartos tem sua casa?
              3 
              Entre com o preço do produto:
              500.50
              Entre com seu último nome, idade e altura na mesma linha na saída em variáveis diferentes:
              Green 21 1.73)*/


            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");

            Console.WriteLine("Entre com seu nome completo:");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem em sua casa?");
            int quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço do produto:");
            double produto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com seu último nome, idade e altura na mesma linha:");
            string[] split = Console.ReadLine().Split(' ');
            string nome1 = split[0];
            int idade1 = int.Parse(split[1]);
            double altura = double.Parse(split[2], CultureInfo.InvariantCulture);

            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(produto.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine(nome1);
            Console.WriteLine(idade1);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
