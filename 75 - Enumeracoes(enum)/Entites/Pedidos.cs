using Enumeracoes.Entites.Enuns;
using System;
using System.Collections.Generic;
using System.Text;

namespace Enumeracoes.Entites
{
    public class Pedidos
    {
        public int Id { get; set; }
        public DateTime Momento { get; set; }

        //Esse atributo da classe é um enum
        public StatusDoPedido Status { get; set; }


        public override string ToString()
        {
            return Id 
                + ", "
                + Momento
                + ", "
                + Status;
        }
    }
}
