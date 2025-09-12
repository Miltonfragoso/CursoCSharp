using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ExercFixacao.Entities
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
    }
}
