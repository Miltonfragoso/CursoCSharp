﻿/*A grande questão nos membros estaticos são os atributos da classe é estatico e tem os valores fixos, os métodos por 
 * sua vez são estaticos também.
 * os valores dos atributos não mudam.
 * Uma classe cujo os atributos tem valores fixos não precisamos instanciar atraves da classe podemos
 * chamar direto suas funções.
 */
using System;
using System.Globalization;

namespace MembrosEstaticosParte03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculadora.Circunferencia(raio);

            double volume = Calculadora.Volume(raio);

            Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
