

using System.Diagnostics;
using System.Globalization;

namespace ExercicioComposicaoStrigBuilder.Entities
{
    internal class ItemDoPedido
    {
        public int Quantidade { get; set; }
        public double Preco { get; set; }

        public Produto Produto { get; set; }

        public ItemDoPedido()
        {
        }

        public ItemDoPedido(int quantidade, double preco, Produto produto)
        {
            Quantidade = quantidade;
            Preco = preco;
            Produto = produto;
        }

        public double SubTotal()
        {
            return Quantidade * Preco;
        }
        public override string ToString()
        {
            return Produto.Nome
            + ", $"
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantity: "
                + Quantidade
                + ", Subtotal: $"
                + SubTotal().ToString("F2", CultureInfo.InvariantCulture);

        }

    }
}
