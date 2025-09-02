using ExercDeFixacao.Entities;
using System;

namespace ExercDeFixacao.Services
{
    public class ContratoService
    {
        private IPagamentoOnlineService _pagamentoOnlineService;

        public ContratoService(IPagamentoOnlineService pagamentoOnlineService)
        {
            _pagamentoOnlineService = pagamentoOnlineService;
        }

        public void ProcessarContrato(Contrato contrato, int numeroParcelas)
        {
            double valorBasica = contrato.ValorTotal / numeroParcelas;
            for (int i = 1; i <= numeroParcelas; i++)
            {
                //pegar a data do contrato e adicionar os meses
                DateTime date = contrato.Data.AddMonths(i);

                double valorJuros = valorBasica + _pagamentoOnlineService.Juros(valorBasica, i);
                double valorTaxa = valorJuros + _pagamentoOnlineService.TaxaPagamento(valorJuros);

                contrato.AdicionarParcela(new Parcela(date, valorTaxa));
            }

        }
    }
}
