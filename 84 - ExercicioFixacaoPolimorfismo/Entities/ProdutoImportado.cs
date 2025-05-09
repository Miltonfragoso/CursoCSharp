using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExercicioFixacaoPolimorfismo.Entities
{
    internal class ProdutoImportado : Produto
    {
        public double TaxaDeAlfandega { get; set; }

        public ProdutoImportado()
        {
        }

        public ProdutoImportado(string nome, double preco, double taxaDeAlfandega) : base( nome, preco) {
        
            TaxaDeAlfandega = taxaDeAlfandega;
        }


        public override string etiquetaDePreco()
        {
            return Nome
                   + " $ "
                   + PrecoTotal().ToString("F2", CultureInfo.InvariantCulture)
                   + " (Taxa da alfandega: $ "
                   + TaxaDeAlfandega.ToString("F2", CultureInfo.InvariantCulture)
                   + " ) ";
        }

        public double PrecoTotal()
        {
            return Preco + TaxaDeAlfandega;
        }
    }
}
