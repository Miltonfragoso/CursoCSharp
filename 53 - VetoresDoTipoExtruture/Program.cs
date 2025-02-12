using System;
using System.Globalization;

/*Vetores
• Em programação, "vetor" é o nome dado a arranjos unidimensionais
• Arranjo é uma estrutura de dados:
• Homogênea (dados do mesmo tipo)
• Ordenada (elementos acessados por meio de posições)
• Alocada de uma vez só, em um bloco contíguo de memória
• Vantagens:
• Acesso imediato aos elementos pela sua posição
• Desvantagens:
• Tamanho fixo
• Dificuldade para se realizar inserções e deleções*/

namespace Vetores
{
    /* VETOR DO TIPO EXTRUTURE
       Fazer um Programa para ler um número inteiro N e a altura de N pessoas. Armazenar as N alturas em um vetor.
       em seguida, mostrar a altura média dessas pessoas.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantidade de alturas");
            int N = int.Parse(Console.ReadLine());

            // declaração e inicialização do vetor;
            double[] vet = new double[N];


            //para inserir dados no vetor vamos percorrer as posições do vetor com um for
            for (int i = 0; i < N; i++)
            {
                vet[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double soma = 0;

            for (int i = 0; i < N; i++)
            {
                soma = soma + vet[i];
            }

            double alturaMedia = soma / N;
            Console.WriteLine("Altura Média = " + alturaMedia.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

