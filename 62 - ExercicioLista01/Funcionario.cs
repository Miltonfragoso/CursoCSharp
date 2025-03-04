using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExercicioLista01
{
    internal class Funcionario
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salario { get; private set; }




        public Funcionario(int id, string nome, double salario)
        {
            Id = id;
            Name = nome;
            Salario = salario;
        }


        public void IncreaseSalary(double percentage)
        {
            Salario += Salario * percentage / 100.0;
        }

        public override string ToString() { 
            return Id
                + ", " 
                + Name
                +", "
                + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
