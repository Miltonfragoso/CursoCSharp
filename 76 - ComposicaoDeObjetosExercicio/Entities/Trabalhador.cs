using ComposicaoDeObjetosExercicio.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComposicaoDeObjetosExercicio.Entities
{
    internal class Trabalhador
    {
        public string Nome{ get; set; }
        public NivelDoTrabalhador Nivel{ get; set; }
        public double SalrioBase { get; set; }

        //Associação entre classes 
        public Departamento Departamento { get; set; }
    }
}
