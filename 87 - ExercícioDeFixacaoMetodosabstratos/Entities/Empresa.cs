using System;
using System.Collections.Generic;
using System.Text;

namespace ExercícioDeFixacaoMetodosabstratos.Entities
{
    internal class Empresa : Contribuinte
    {
        public int NumeroDeFuncuionarios { get; set; }

        public Empresa(string nome, double rendaAnual, int numeroDeFuncuionarios) : base(nome, rendaAnual)
        {
            this.NumeroDeFuncuionarios = numeroDeFuncuionarios;
        }

        public override double Imposto()
        {
            if (NumeroDeFuncuionarios < 10)
            {
                return RendaAnual * 0.16;
            }
            else 
            {
                return RendaAnual * 0.14;
            }
        }
    }
}
