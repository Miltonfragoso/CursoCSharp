using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioVetorDoTipoClassPOO
{
    internal class Estudante
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        //construtor com 2 argumentos
        public Estudante(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        //sobreposição do método ToString para formatar a saída de estudante vai mostrar primeiro o nome espaço e virgula e depois o email
        public override string ToString()
        {
            return Nome + ", " + Email;
        }
    }
}
