using System;
using System.Globalization;

namespace _28___ExercicioEstrtuturaPara_For_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada caso de teste consiste
              de 3 valores reais, cada um deles com uma casa decimal. Apresente a média ponderada para cada um destes
              conjuntos de 3 valores, sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem
              peso 5.
             */

            Console.Write("Quantos casos de testes serão feitos? ");
            int N = int.Parse(Console.ReadLine());


            for (int i = 0; i < N; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                double x = double.Parse(valores[0], CultureInfo.InvariantCulture);
                double y = double.Parse(valores[1], CultureInfo.InvariantCulture);
                double z = double.Parse(valores[2], CultureInfo.InvariantCulture);

                double media = (x * 2.0 + y * 3.0 + z * 5.0) / (10.0);

                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
