using System;
using System.Collections.Generic;
using System.Text;

namespace ComposiçãoDeObjetosStringBuilder.Entities
{
    internal class Publicar
    {
        public DateTime Momento { get; set; }
        public string Titulo { get; set; }
        public string Conteudo { get; set; }
        public int Curtidas { get; set; }
        public List<Comentario> Comentarios { get; set; } = new List<Comentario> { };

        public Publicar()
        {
        }

        public Publicar(DateTime momento, string titulo, string conteudo, int curtidas)
        {
            Momento = momento;
            Titulo = titulo;
            Conteudo = conteudo;
            Curtidas = curtidas;
        }

        public void AddComentario(Comentario comentario)
        {
            Comentarios.Add(comentario);
        }


        public void RemoveComentario(Comentario comentario)
        {
            Comentarios.Remove(comentario);
        }

        // Sobrescrevendo uma ToString() Usando o método StringBuilder()
        /*STRINGbUILDER: A classe StringBuilder faz parte do pacote System.text
         * Essa classe permite criar e manipular dados de Strings dinamicamente, 
         * ou seja, podem criar variáveis de String modificáveis.
         */

        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Titulo);
            sb.Append(Curtidas);
            sb.Append(" Curtidas - ");
            sb.Append(Momento.ToString("dd/MM/yyyy  HH: mm:ss"));
            sb.Append(Momento);
            sb.AppendLine(Conteudo);
            sb.Append("Comentarios: ");
            foreach (Comentario c in Comentarios)
            {
                sb.Append(c.Texto);
            }
            return sb.ToString();
        }
    }
}
