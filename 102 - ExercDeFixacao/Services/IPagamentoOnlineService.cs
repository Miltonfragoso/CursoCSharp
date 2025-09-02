using System;
using System.Collections.Generic;
using System.Text;

namespace ExercDeFixacao.Services
{
    public interface IPagamentoOnlineService
    {
        double TaxaPagamento(double quantia);
        double Juros(double quantia, int meses);
    }
}
