using System;
using System.Collections.Generic;
using System.Text;

namespace ComposicaoDeObjetosExercicio.Entities
{
    internal class Departamento
    {
        public string Nome{ get; set; }

        public Departamento()
        {
        }

        public Departamento(string name)
        {
            Nome = name;
        }
    }
}
