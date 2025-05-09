/*
 * Fazer um programa para ler os dados de N produtos (N fornecido pelo usuário). Ao final,mostrar a etiqueta de preço de cada produto na
 * mesma ordem em que foram digitados. Todo produto possui nome e preço. Produtos importados possuem uma taxa de alfândega, e
 * produtos usados possuem data de fabricação. Estes dados específicos devem ser acrescentados na etiqueta de preço conforme exemplo (próxima página).
 * Para produtos importados, a taxa e alfândega deve ser acrescentada ao preço final do produto. 
 * 
 */

//         Produto                      ProdutoImportado : Produto               ProdutoUsado
//    |-----------------             -------------------------------         --------------------
//    |- nome: String                    - TaxaDeAlfandega: Double              - dataDeFabricacao
//    |- Preco: Double
//    |-----------------              ---------------------------------       ---------------------
//    | + etiquetaDePreco: String        + etiquetaDePreco: String           + etiquetaDePreco: String
//                                        + precoTotal: Double

using ExercicioFixacaoPolimorfismo.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioFixacaoPolimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Produto> list = new List<Produto>();

            Console.Write("Insira o número de produtos: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Dados do Produto #{i}: ");
                Console.Write("Comum, usado ou importado (c/u/i)? ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Preço: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(ch == 'i')
                {
                    Console.Write("Taxa de alfandega: ");
                    double taxaAlfandega = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new ProdutoImportado(nome, preco, taxaAlfandega));
                }
                else if(ch == 'u')
                {
                    Console.Write("Dta de fabricação (DD/MM/YYYY): ");
                    DateTime data = DateTime.Parse(Console.ReadLine());

                    list.Add(new ProdutoUsado(nome, preco, data));
                }
                else
                {
                    list.Add(new Produto(nome, preco));
                }

            }

            Console.WriteLine();
            Console.WriteLine("TABELA DE PREÇOS: ");
            foreach (Produto prod in list)
            {
                Console.WriteLine(prod.etiquetaDePreco());
            }
        }
    }
}
