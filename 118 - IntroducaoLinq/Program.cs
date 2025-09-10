using System;
using System.Linq;

namespace IntroducaoLinq
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Data source
            int[] numeros = new int[] { 2, 3, 4, 5 };

            //Definir a consulta (query)
            //var resultado = from n in numeros where n > 3 select n;
            var resultado = numeros.Where(n => n > 3);

            //EXECUTAR A CONSULTA
            foreach (int n in resultado)
            {
                Console.WriteLine(n);
            }


            Console.WriteLine("------------------------------------------");

            //Data source
            int[] numbers = new int[6] { 1, 2, 3, 4, 5, 6 };

            //Definir a consulta (query)
            var result = numeros.Where(x => x % 2 == 0).Select(x => x * 10);

            //EXECUTAR A CONSULTA
            foreach (int x in result)
            {
                Console.WriteLine(x);
            }
        }
    }
}
