using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo.Entities
{
    internal class FuncionarioTercerizado : Funcionario
    {
        public double DispesaAdicional { get; set; }


        public FuncionarioTercerizado()
        {
        }

        public FuncionarioTercerizado(string nome, int horas, double valorPorHora, double dispesaAdicional) : base(nome, horas, valorPorHora) 
        {
            DispesaAdicional = dispesaAdicional;
        }

        //Esse método multiplica horas * valor por hora + 110% da taxa adicional que é 1.1
        public override double Pagamento()
        {
            //return (Horas * ValorPorHora ) + (1.1 * DispesaAdicional);
            return base.Pagamento() + (1.1 * DispesaAdicional);
        }
    }
}
