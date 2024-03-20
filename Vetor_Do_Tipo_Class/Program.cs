using System;
using System.Globalization;

namespace Vetor_Do_Tipo_Class
{
    // VETOR DO TIPO CLASS
    /*Fazer um programa para ler um número inteiro N e os dados (nome e preço ) de N produtos. Armazene os N produtos em um vetor. 
      Em seguida, mostrar o preço médio dos produtos.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            Produto[] vet = new Produto[N];

            for (int i = 0; i < N; i++)
            {
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vet[i] = new Produto { Nome = nome, Preco = preco };
            }

            double soma = 0.0;
            for (int i = 0; i < N; i++)
            {
                soma = soma + vet[i].Preco;
            }

            double precoMedio = soma / N;
            Console.WriteLine("Preço Médio = " + precoMedio.ToString(), CultureInfo.InvariantCulture);
        }
    }
}
