using System;
using System.Collections.Generic;
using System.Text;

namespace ComposiçãoDeObjetosStringBuilder.Entities
{
    internal class Comentario
    {
        public string Texto { get; set; }

        public Comentario()
        {
        }

        public Comentario(string texto)
        {
            this.Texto = texto;
        }
    }
}
