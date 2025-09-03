/*Neste exercício vamos fazer a combinação de interface para cumprir contratos e herança para reaproveitar código.
 * Vamos combinar herança e contratos (interfaces) em C#.
 */
using System;
using System.Drawing;
using Course.Model.Entities;
using Heranca_CumprirContrato.Model.Entities;

namespace Heranca_CumprirContrato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFigura f1 = new Circulo();
            f1 = new Circulo { Raio = 2.0, Cor = Color.White};

            IFigura f2 = new Retangulo { Largura = 3.5, Altura = 4.2, Cor = Color.Black };

            Console.WriteLine(f1);
            Console.WriteLine(f2);
        }
    }
}
