using ExercicioComposicaoStrigBuilder.Entities;
using ExercicioComposicaoStrigBuilder.Entities.Enums;
using System;
using System.Globalization;

namespace ExercicioComposicaoStrigBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira os dados do cliente: ");
            Console.Write("Nome: ");
            string nomeDoCliente = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Data de nascimento (DD/MM/YYYY): ");
            DateTime dataDeNascimento = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Insira os dados do pedido: ");
            Console.Write("Status: ");
            //O estatus do pedido vira de uma string e convertido para enum
            StatusDoPedido status = Enum.Parse<StatusDoPedido>(Console.ReadLine());

            Cliente cliente = new Cliente(nomeDoCliente, email, dataDeNascimento);

            Pedido pedido = new Pedido(DateTime.Now, status, cliente);

            Console.Write("Quantos itens há neste pedido? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Insira os dados do item #{i}:");
                Console.Write("Nome do produto: ");
                string nomeDoProduto= Console.ReadLine();
                Console.Write("Preço: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Produto produto = new Produto(nomeDoProduto, preco);

                Console.Write("Quantidade: ");
                int quantidade = int.Parse(Console.ReadLine());

                ItemDoPedido itemDoPedido = new ItemDoPedido(quantidade, preco, produto);

                pedido.AddItem(itemDoPedido);
            }

            Console.WriteLine();
            Console.WriteLine("RESUMO DO PEDIDO:");
            Console.WriteLine(pedido);
        }
    }
}

