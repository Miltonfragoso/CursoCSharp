/*
 * Fazer um programa para ler um conjunto de produtos a partir de um
    arquivo em formato .csv (suponha que exista pelo menos um produto).
    Em seguida mostrar o preço médio dos produtos. Depois, mostrar os
    nomes, em ordem decrescente, dos produtos que possuem preço
    inferior ao preço médio.
 */
using ExercFixacao.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace ExercFixacao
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o caminho do arquivo: ");
            string path = Console.ReadLine();

            List<Produto> produtos = new List<Produto>();

            using (StreamReader sr = File.OpenText(path)) 
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');
                    string nome = fields[0];
                    double preco = double.Parse(fields[1], CultureInfo.InvariantCulture);

                    //com inicializador de objeto quando a classe tem o construtor padrao ou seja sem argumentos ou sem construtor
                    //produtos.Add(new Produto { Nome = nome, Preco = preco });


                    produtos.Add(new Produto(nome, preco));
                }
            }

            //Achar preço médio dos produtos
            var PrecoMedio = produtos.Select(p => p.Preco).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Preço Médio = " + PrecoMedio.ToString("F2", CultureInfo.InvariantCulture));

            //Achar os nomes dos produtos com preço inferior ao preço médio em ordem decrescente alfabética
            var nomes = produtos.Where(p => p.Preco < PrecoMedio).OrderByDescending(p => p.Nome).Select(p => p.Nome);
            foreach (string nome in nomes)
            {
                Console.WriteLine(nome);
            }
        }
    }
}
