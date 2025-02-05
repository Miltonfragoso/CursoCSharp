using System;
using System.Globalization;

namespace _23___EstruturaRepetitivaEnquanto_While_
{
    internal class Program
    {   /*A estrutura repetitiva enquanto, executa o comando enquanto a condição for verdadeira so vai pular fora quando a condição for falsa
         * While (condição){
         * comando 1
         * comando 2
         * }
         */


        /*EXERCÍCIO
         * Digitar um número e mostrar sua raiz quadrada com três casa decimais, depois repetir o procedimento. 
         * Quando o usuário digitar um número negativo(podendo inclusive ser na primeira vez), mostra uma mensagem
         * "Número negativo" e terminar o programa.
         */
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (x >= 0.0)
            {
                double raiz = Math.Sqrt(x);
                Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));

                Console.Write("Digite outro número: ");
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            Console.WriteLine("Número negativo");
        }
    }
}
