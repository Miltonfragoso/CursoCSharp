using System;
using System.Globalization;

namespace ExercDeFixacao.Entities
{
    public class Parcela
    {
        public DateTime DataDeVencimento { get; set; }
        public double Valor { get; set; }

        public Parcela(DateTime data, double valor)
        {
            DataDeVencimento = data;
            Valor = valor;
        }

        public override string ToString()
        {
            return DataDeVencimento.ToString("dd/MM/yyyy")
                + " - "
                + Valor.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
