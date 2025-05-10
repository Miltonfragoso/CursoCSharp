using MétodosAbstratos.Entities.Enuns;
using System;
using System.Collections.Generic;
using System.Text;

namespace MétodosAbstratos.Entities
{
    internal class Circulo : Figura
    {
        public double Raio { get; set; }

        public Circulo(Cor cor, double raio) : base (cor)
        {
            this.Raio = raio;
        }

        public override double Area()
        {
            return Math.PI * Raio * Raio;
        }
    }
}
