using System;
using System.Globalization;

namespace ExercEntradaDeDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ler um número interiro  35
             * int.Parse para converter o texto string  == trinta e cinco para o número inteiro 35*/
            int N1 = int.Parse(Console.ReadLine());

            /*     
             Ler um caracter  F
            */
            char CH = char.Parse(Console.ReadLine());


            /*     
            Ler um número double  4.32
            */
            double N2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("Vovê digitou");
            Console.WriteLine(N1);
            Console.WriteLine(CH);
            Console.WriteLine(N2);


            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------------");
            /*Maria F 23 1.68
             * Ler um nome (única palavra)
             Sexo(caracter F ou M)
            Idade(inteiro) e Alrura(double) na mesma linha e armazenar em 4 variáveisn com os devidos tipos.
            */
            Console.WriteLine("Digite os dados");
            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("Vovê digitou");
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("------------------------------------------------------------------------");
        }
    }
}
