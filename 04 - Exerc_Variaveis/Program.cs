using System;
using System.Globalization;

namespace ExercVariaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // iNICIE AS SEGUINTES VARIÁVEIS
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            //EM SEGUIDA, USANDO OS VALORES DAS VARIÁVEIS, PRODUZA A SEGUINTE SAÍDA  NA TELA
            Console.WriteLine("Produtos:");
            Console.WriteLine(produto1 + ", cujo preço é $ " + preco1.ToString("F2"));
            Console.WriteLine(produto2 + ", cujo preço é $ " + preco2.ToString("F2"));
            Console.WriteLine();
            Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero: {genero}");
            Console.WriteLine();
            Console.WriteLine("Medida com oito casas decimais:" + medida);
            Console.WriteLine("Arredondando (três casas  decimais): " + medida.ToString("F3"));
            Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
