using ExercComInterface.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExercComInterface.Services
{
    public class AluguelService
    {
        public double PrecoPorHora { get; private set; }
        public double PrecoPorDia { get; private set; }


        //Criando uma dependencia direta da classe Aluguel de carro para a classe ImpostoNoBrasilService
        private IImpostosService _impostoService;

        public AluguelService(double precoPorHora, double precoPorDia, IImpostosService impostoService)
        {
            PrecoPorHora = precoPorHora;
            PrecoPorDia = precoPorDia;
           _impostoService = impostoService;

        }

        public void ProcessarFatura(AluguelDeCarro aluguelDeCarro)
        {
            TimeSpan duracao = aluguelDeCarro.Saida.Subtract(aluguelDeCarro.Entrada);

            double pagamentoBasico = 0.0;

            if (duracao.TotalHours <= 12.0)
            {
                pagamentoBasico = PrecoPorHora * Math.Ceiling(duracao.TotalHours);
            }
            else
            {
                pagamentoBasico = PrecoPorDia * Math.Ceiling(duracao.TotalDays);
            }


            double imposto = _impostoService.Imposto(pagamentoBasico);

            aluguelDeCarro.Fatura = new Fatura(pagamentoBasico, imposto);
        }

    }
}
