/*Fazer um programa para ler os dados de um produto em estoque(nome, preço e quantidade no estoque)
 em seguida, mostrar os dados do produto(nome, preço quantidade no estoque, valor total no estoque)
 realizar uma entrada no estoque e mostrar novamente os dados do produto
 Realizar uma saída no estoque e mostrar novamente os dados do produto
                                      PRODUTO
                  ------------------------------------------
                        -Nome: String
                        -Preço: double
                        -Quantidade: int
                  -------------------------------------------
                        + ValorTotalEm Estoque(): double
                        + AdicionarProduto(quantity: int): void
                        +RemoverProdutos(quantity: int): void
*/
using System;
using System.Globalization;

namespace ExercicioProdutoPOO
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();
            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p.ToString());

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int Qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(Qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p.ToString());



            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            Qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(Qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p.ToString());
        }
    }
}
