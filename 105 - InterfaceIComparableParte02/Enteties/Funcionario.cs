using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading;

namespace InterfaceIComparableParte02.Enteties
{
    public class Funcionario : IComparable
    {
        public string Nome{ get; set; }
        public double Salario{ get; set; }

        public Funcionario(string csvFuncionario)
        {
            string[] vect = csvFuncionario.Split(',');

            Nome = vect[0];
            Salario = double.Parse(vect[1], CultureInfo.InvariantCulture);
        }

        public override string ToString()
        {
            return Nome
                + ", "
                + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }

        //Método CompareTo da interface IComparable é usado para comparar o objeto atual com outro objeto do mesmo tipo.
        public int CompareTo(object obj)
        {
            if (!(obj is Funcionario))
            {
                throw new ArgumentException("Comparing error: argument is not a Funcionario");
            }
            Funcionario outro = obj as Funcionario;       
            return Nome.CompareTo(outro.Nome);
        }
    }
}
