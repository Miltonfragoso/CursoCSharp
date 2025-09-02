

namespace ExercDeFixacao.Services
{
    public class PaypalService : IPagamentoOnlineService
    {
        private const double JurosMes = 0.01;
        private const double Taxa = 0.02;
        
        public double Juros(double quantia, int meses)
        {
            return quantia * JurosMes * meses;
        }
        public double TaxaPagamento(double quantia)
        {
            return quantia * Taxa;
        }
    }
}
