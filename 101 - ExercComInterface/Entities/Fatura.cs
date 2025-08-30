using System.Globalization;

namespace ExercComInterface.Entities
{
    public class Fatura
    {
        public double PagamentoBasico { get; set; }
        public double Imposto { get; set; }

        public Fatura(double pagamentoBasico, double imposto)
        {
            PagamentoBasico = pagamentoBasico;
            Imposto = imposto;
        }

        //Propiedade calculada
        public double PagamentoTotal
        {
            get { return PagamentoBasico + Imposto; }
        }

        public override string ToString()
        {
            return "Pagamento Básico: "
                + PagamentoBasico.ToString("F2", CultureInfo.InvariantCulture)
                + "\nImposto: "
                + Imposto.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTotal a pagar: "
                + PagamentoTotal.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}