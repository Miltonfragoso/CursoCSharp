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
        public double SalarioBase { get; set; }
        //Associação entre classes (Composição de objetos)
        public Departamento Departamento { get; set; }
        //um trabalhar tem vários contratos,então usamos a lista // Instanciando a lista para não ser nulla
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
            SalarioBase = salrioBase;
            Departamento = departamento;
        }


       //Métodos
       //Adicionar contratos a lista
       public void AddContratos(ContratoPorHora  contrato)
        {
            Contratos.Add(contrato);
        }


        //Remover contrato da lista
        public void RemoverContratos(ContratoPorHora contrato)
        {
            Contratos.Remove(contrato);
        }

        //calculo da renda mensal somando todos contratos
        public double RendaMensal(int ano, int mes)
        {
            double soma = SalarioBase;

            // foreach para percorrer a lista de contratos//Para cada contrato por hora na lista de contrato faça
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
