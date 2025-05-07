using ExercicioComposicaoStrigBuilder.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Xml.Serialization;

namespace ExercicioComposicaoStrigBuilder.Entities
{
    internal class Pedido
    {
        public DateTime MomentoDoPedido { get; set; }
        public StatusDoPedido Status { get; set; }
        public Cliente Cliente { get; set; }
                                                    //Essa linha de código garante que nossa lista seja instanciada
        public List<ItemDoPedido> Itens { get; set; } = new List<ItemDoPedido>();

        public Pedido()
        {
        }

        public Pedido(DateTime momentoDoPedido, StatusDoPedido status, Cliente cliente)
        {
            MomentoDoPedido = momentoDoPedido;
            Status = status;
            Cliente = cliente;
        }

        public void AddItem(ItemDoPedido item)
        {
            Itens.Add(item);
        }

        public void RemoverItem(ItemDoPedido item)
        {
            Itens.Remove(item);
        }

        /*O subtotal em cada item, é a quantidade * o valor do item
         * já o total é a soma de todos os subtotal
         */
        public double Total() {

            double soma = 0.0;
            foreach(ItemDoPedido item in Itens)
            {
                soma += item.SubTotal(); 
            }
            return soma;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("hora do pedido: " + MomentoDoPedido.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Status do pedido : " + Status);
            sb.AppendLine("Cliente: " + Cliente);
            sb.AppendLine("Order items:");
            foreach (ItemDoPedido item in Itens)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
