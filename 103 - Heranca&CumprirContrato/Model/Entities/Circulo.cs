
using Heranca_CumprirContrato.Model.Entities;
using System;
using System.Drawing;
using System.Globalization;

namespace Course.Model.Entities
{
    class Circulo : FiguraAbstrata
    {

        public double Raio { get; set; }

        public override double Area()
        {
            return Math.PI * Raio * Raio;
        }

        public override string ToString()
        {
            return "Circle color = "
                + Cor
                + ", radius = "
                + Raio.ToString("F2", CultureInfo.InvariantCulture)
                + ", area = "
                + Area().ToString("F2", CultureInfo.InvariantCulture);
        }
    }

}