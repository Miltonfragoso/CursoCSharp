using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExercicioFixacaoPolimorfismo.Entities
{
    internal class ProdutoUsado : Produto
    {
        public DateTime DataDeFabricacao{ get; set; }

        public ProdutoUsado()
        {
        }

        public ProdutoUsado(string nome, double preco, DateTime dataDeFabricacao) : base(nome, preco)
        {
            DataDeFabricacao = dataDeFabricacao;
        }

        public override string etiquetaDePreco()
        {
            return Nome
                   + " ( Usado ) $ "
                   + Preco.ToString("F2", CultureInfo.InvariantCulture)
                   + "(Data da fabricação: "
                   + DataDeFabricacao.ToString("dd/MM/yyyy")
                   + ")";
        }
    }
}
