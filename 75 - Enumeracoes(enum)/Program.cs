/*Enumerações
 * É um tipo especial que serve para especificar de forma literal um conjunto de constantes relacionadas
 * Palavra chave em C#: enum Nota: enum é um tipo valor
 * Vantagem: melhor semântica, código mais legível e auxiliado pelo compilador
 */
using Enumeracoes.Entites;
using Enumeracoes.Entites.Enuns;
using System;

namespace Enumeracoes
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Intanciar um objeto do tipo pedido inicializando seus atributos
            Pedidos pedido = new Pedidos
            {
                Id = 1080,
                Momento = DateTime.Now,
                Status = StatusDoPedido.PagamentoPendente
                
            };
            Console.WriteLine(pedido);

            //conversão de enum para string
            string txt = StatusDoPedido.PagamentoPendente.ToString();


            //conversão de string para enum 
            StatusDoPedido os = Enum.Parse<StatusDoPedido>("Entregue");

            Console.WriteLine(txt);
            Console.WriteLine(os);
        }
    }
}
