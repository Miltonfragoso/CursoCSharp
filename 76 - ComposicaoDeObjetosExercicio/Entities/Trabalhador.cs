using ComposicaoDeObjetosExercicio.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComposicaoDeObjetosExercicio.Entities
{
    internal class Trabalhador
    {
        //Propriedades
        public string Nome{ get; set; }
        public NivelDoTrabalhador Nivel{ get; set; }
        public double SalrioBase { get; set; }

        //Associação entre classes (Composição de objetos)
        public Departamento Departamento { get; set; }

                                                           // Instanciando a lista para não ser nulla
        public List<ContratoPorHora> Contratos { get; set; } = new List<ContratoPorHora>();



        //Construtores
        public Trabalhador()
        {
        }

        //Sempre que tiver uma associação com uma lista, não passamos no construtor
        public Trabalhador(string nome, NivelDoTrabalhador nivel, double salrioBase, Departamento departamento)
        {
            Nome = nome;
            Nivel = nivel;
            SalrioBase = salrioBase;
            Departamento = departamento;
        }


       //Métodos
       public void AddContratos(ContratoPorHora  contrato)
        {
            Contratos.Add(contrato);
        }

        public void RemoverContratos(ContratoPorHora contrato)
        {
            Contratos.Remove(contrato);
        }

        public double RendaMensal(int ano, int mes)
        {
            double soma = SalrioBase;

            //Para cada contrato por hora na lista de contrato faça
            foreach (ContratoPorHora contrato in Contratos)
            {
                if (contrato.Data.Year == ano && contrato.Data.Month == mes)
                {
                    soma = soma + contrato.ValorTotalDoContrato();
                }
            }
            return soma;
        }
    }
}
