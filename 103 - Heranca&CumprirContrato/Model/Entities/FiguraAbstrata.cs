using System.Drawing;

namespace Heranca_CumprirContrato.Model.Entities
{
    abstract class FiguraAbstrata : IFigura
    {
        public Color Cor { get; set; }

        public abstract double Area();
    }
}

//Cumprimos a implementação do contrato da interface IFigura,porém como a classe é abstrata,não precisamos implementar o método Area().
//DEixamos o método abstrato para que as classes derivadas sejam obrigadas a implementar o método Area().

