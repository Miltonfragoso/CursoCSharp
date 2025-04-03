using System;
using System.Collections.Generic;
using System.Text;

namespace Enumeracoes.Entites.Enuns
{
    public enum StatusDoPedido : int
    {
        PagamentoPendente = 0,
        Processando = 1,
        Enviado = 2,
        Entregue = 3
    }
}
