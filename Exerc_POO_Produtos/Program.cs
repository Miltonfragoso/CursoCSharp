using System;
using System.Globalization;

namespace Exerc_POO_Produtos
{
    /*Fazer um programa para ler os dados de um produto em estoque(nome, preço, quantidade)
     Em seguida mostra os dados do produto(nome, preço, quantidade no estoque, valor total no estoque).

    -Adicionar mais produtos no estoque e mostra os dados novamente.
    -retirar alguns produtos no estoque e mostra os dados do produto*/

    internal class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());


            // Imprimindo a saída desta forma gera repetição de código visto que faremos 3 saídas
            //Console.WriteLine();
            //Console.WriteLine("Dados do produto: " + p.Nome + ", $" + p.Preco + " , " + p.Quantidade);



            //O método ToString da class produto é chamado implicitamente. chamamos sempre que precisarmos imprimir saída.
            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);


            Console.WriteLine();
            Console.Write("Digite o numero de produtos a ser adicionado em estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados " + p);

            Console.WriteLine();
            Console.Write("Digite o numero de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);


            Console.WriteLine();
            Console.WriteLine("Dados atualizados " + p);
        }
    }
}
