using Heranca_CumprirContrato.Model.Entities;
using System.Drawing;
using System.Globalization;

namespace Course.Model.Entities
{
    class Retangulo : FiguraAbstrata
    {

        public double Largura { get; set; }
        public double Altura { get; set; }

        public override double Area()
        {
            return Largura * Altura;
        }

        public override string ToString()
        {
            return "Rectangle color = "
                + Cor
                + ", width = "
                + Largura.ToString("F2", CultureInfo.InvariantCulture)
                + ", height = "
                + Altura.ToString("F2", CultureInfo.InvariantCulture)
                + ", area = "
                + Area().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
