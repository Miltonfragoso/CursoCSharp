using System;
using System.Collections.Generic;
using System.Text;

namespace ExercícioDeFixacaoMetodosabstratos.Entities
{
    internal class Individual : Contribuinte
    {
        public double Saude{ get; set; }
        public bool GastosComSaude { get; set; }


        public Individual(string nome, double rendaAnual, bool gastosComSaude) : base(nome, rendaAnual)
        {
            this.GastosComSaude = gastosComSaude;
        }

        public Individual(string nome, double rendaAnual, double saude, bool gastosComSaude) : base(nome, rendaAnual)
        {
            this.Saude = saude;
            this.GastosComSaude = gastosComSaude;
        }

        public override double Imposto()
        {
            if (RendaAnual < 20000 && GastosComSaude == true)
            {
                return RendaAnual * 0.15 - Saude * 0.5;
            }
            else if(RendaAnual < 20000 && GastosComSaude == false)
            {
                return RendaAnual * 0.15;
            }
            else if(RendaAnual >= 20.000 && GastosComSaude == true)
            {
                return RendaAnual * 0.25 - Saude * 0.5;
            }
            else
            {
                return RendaAnual * 0.25;
            }
        }
    }
}
