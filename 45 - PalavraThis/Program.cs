/*Palavra this
• É uma referência para o próprio objeto

• Usos comuns:
• Diferenciar atributos de variáveis locais (Java)
• Referenciar outro construtor em um construtor
• Passar o próprio objeto como argumento na chamada de um método ou construtor*/

using System;
using System.Globalization;

namespace PalavraThis
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


/*  Diferenciar atributos de variáveis locais
 *  public Produto(string Nome, double Preco) {
           this.Nome = Nome;
           this.Preco = Preco;
           Quantidade = 0;
    }*/
