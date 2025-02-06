/*Fazer um programa para ler os valores da largura e altura de um retângulo. Em
seguida, mostrar na tela o valor de sua área, perímetro e diagonal. Usar uma classe
como mostrado no projeto ao lado.

                                                        Retangulo
                                                    ------------------
                                                     -Largura: double
                                                     -Altura: double
                                                    ------------------- 
                                                    +Area(): double
                                                    +Perimetro(): double
                                                    +Diagonal(): double*/
using System;
using System.Globalization;

namespace ExercíciosPOO01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();
            Console.WriteLine("Entre com a largura e a altura do retângulo: ");
            retangulo.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            retangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            Console.WriteLine("Area = " + retangulo.Area().ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("Perímetro = " + retangulo.Perimetro().ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("Diagonal = " + retangulo.Diagonal().ToString("F2"), CultureInfo.InvariantCulture);

        }
    }
}
