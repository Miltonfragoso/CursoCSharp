using System;
using System.Collections.Generic;
using System.Text;

namespace ComposicaoDeObjetosExercicio.Entities
{
    internal class ContratoPorHora
    {
        public DateTime Data { get; set; }
        public double ValorPorHora { get; set; }
        public int Horas { get; set; }

        public ContratoPorHora()
        {
        }

        public ContratoPorHora(DateTime data, double valorPorHora, int horas)
        {
            Data = data;
            ValorPorHora = valorPorHora;
            Horas = horas;
        }

        public double ValorTotalDoContrato()
        {
            return Horas * ValorPorHora;
        }
    }
}
