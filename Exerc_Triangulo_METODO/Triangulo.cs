using System;

namespace Exerc_Triangulo_METODO
{
    internal class Triangulo
    {
        public double A;
        public double B;
        public double C;


        /*O método é uma função dentro da class
         * Com o método evitamos a repetição do código
         * Quando o método esta na mesma class não precisa passar parametro*/

        public double Area()
        {
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}