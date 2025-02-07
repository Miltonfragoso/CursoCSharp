/*Sobrecarga
• É um recurso que uma classe possui de oferecer mais de uma
operação com o mesmo nome, porém com diferentes listas de
parâmetros.

 Mais de uma versão de um método com o mesmo nome porém com exigências ou parametros diferentes.*/

using System;
using System.Globalization;

namespace Sobrecarga
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.Write("Quantidade no estoque: ");
            //int quantidade = int.Parse(Console.ReadLine());

            //usando o construtor padrão
            Produto produto = new Produto(); 
            

            //usando o construtor de 2 argumentos
            Produto p = new Produto(nome, preco);

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


            /*Sintaxe alternativa para inicialização de valores sem a construção do construtor permitido no c#
             Produto p  = new Produto () {
                Nome = "TV"
                Preco = 900.00
                Quantidade = 0 
            }

            o objeto recebe os valores direto ao inicializar
             */
        }
    }
}
