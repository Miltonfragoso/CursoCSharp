using System;

namespace ExercicioEstrtuturaParaFor07
{
    internal class Program
    {
        /*Fazer um programa para ler um número inteiro positivo N. O programa deve então mostrar na tela N linhas,
          começando de 1 até N. Para cada linha, mostrar o número da linha, depois o quadrado e o cubo do valor, conforme
          exemplo.*/
        static void Main(string[] args)
        {
            
                Console.Write("Digite um número: ");
                int N = int.Parse(Console.ReadLine());

                Console.WriteLine("----------------------------");

                double quadrado = 0;
                double cubo = 0;
                for (int i = 1; i <= N; i++)
                {

                    quadrado = (Math.Pow(i, 2));
                    cubo = (Math.Pow(i, 3));
                    Console.WriteLine("{0} {1} {2}", i, quadrado, cubo);
                }

            
        }
    }
}
