using System;
using System.Collections.Generic;
using System.Text;

namespace ComposicaoDeObjetosExercicio.Entities
{
    internal class Departamento
    {
        //Propriedades 
        public string Nome{ get; set; }


        //Construtores
        public Departamento()
        {
        }

        public Departamento(string name)
        {
            Nome = name;
        }
    }
}
