using System;

namespace _31___ExercicioEstrtuturaPara_For_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ler um número inteiro N e calcular todos os seus divisores.*/

            Console.WriteLine("Entrada: ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                if (N % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
