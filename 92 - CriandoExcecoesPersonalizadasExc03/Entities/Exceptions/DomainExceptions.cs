using System;
using System.Collections.Generic;
using System.Text;

namespace CriandoExcecoesPersonalizadasExc03.Entities.Exceptions
{
    internal class DomainExceptions : ApplicationException
    {
        //Constrtutor com parametro e repassa a message para a classe base 
        public DomainExceptions(string message) : base(message)
        {
        }
    }
}
