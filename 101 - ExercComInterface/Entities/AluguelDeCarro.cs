using System;
using System.Collections.Generic;
using System.Text;

namespace ExercComInterface.Entities
{
    public  class AluguelDeCarro
    {
        public DateTime Entrada { get; set; }
        public DateTime Saida { get; set; }
        public Veiculo Veiculo { get; private set; }
        public Fatura Fatura { get; set; }

        public AluguelDeCarro(DateTime entrada, DateTime saida, Veiculo veiculo)
        {
            Entrada = entrada;
            Saida = saida;
            Veiculo = veiculo;
            Fatura = null;

        }
    }
}
