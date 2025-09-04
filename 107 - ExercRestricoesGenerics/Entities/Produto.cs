using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExercRestricoesGenerics.Entities
{
    public  class Produto : IComparable
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Produto))
            {
                throw new ArgumentException("Comparing error: argument is not an Product");
            }
            Produto other = obj as Produto;
            return Preco.CompareTo(other.Preco);
        }

        public override string ToString()
        {
            return Nome
                + ", "
                + Preco.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
