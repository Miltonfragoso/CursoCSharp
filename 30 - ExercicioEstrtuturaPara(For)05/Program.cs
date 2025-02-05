using System;

namespace _30___ExercicioEstrtuturaPara_For_05
{
    internal class Program
    {
        static void Main(string[] args)
        {


            /*Ler um valor N. Calcular e escrever seu respectivo fatorial. Fatorial de N = N * (N-1) * (N-2) * (N-3) * ... * 1.
              Lembrando que, por definição, fatorial de 0 é 1.
             */
            int fatorial = 1;

            Console.Write("Digite um numero:");
            int num = int.Parse(Console.ReadLine());

            if (num < 0)
            {
                Console.WriteLine("Número inválido. apaenas > que zero");
            }
            else if ((num == 0) || (num == 1))
            {
                Console.WriteLine("Fatorial de {0} é 1", num);
            }
            else
            {
                for (int i = 1; i <= num; i++)
                {
                    fatorial = fatorial * i;
                    Console.WriteLine(i);
                }
                Console.WriteLine("Fatorial de {0} é {1}", num, fatorial);
            }
        }
    }
}
