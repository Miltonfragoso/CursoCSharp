using System;

namespace _32___Exerc_Estrut_Reptit_Para_for_07
{
    internal class Program
    {
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
