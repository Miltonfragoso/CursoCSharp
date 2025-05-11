using System;
using System.Collections.Generic;
using System.Text;

namespace ExercícioDeFixacaoMetodosabstratos.Entities
{
    abstract class Contribuinte
    {
        public string Nome { get; set; }
        public double RendaAnual{ get; set; }

        public Contribuinte(string nome, double rendaAnual)
        {
            this.Nome = nome;
            this.RendaAnual = rendaAnual;
        }

        public abstract double Imposto();
    }
}
