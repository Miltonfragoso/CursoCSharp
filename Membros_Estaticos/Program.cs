﻿using System;
using System.Globalization;

/*Membros estáticos também são chamados membros de classe 
 *São membros que fazem sentido independente do objeto.Não precisam de objeto para serem chamados
 *são chamados apartir do própio nome da classe.
 *
 *Aplicações comuns:
 *Classeutilitárias
 *Declaração de constantes
 *
 *
 *Uma classe que possui somente membros estáticos, pode ser uma classe estática também. Esta classe não pode ser instanciada.
 */


/*Fazer um programa para ler um valor numérico qualquer, e daí mostrar
quanto seria o valor de uma circunferência e do volume de uma esfera
para um raio daquele valor. Informar também o valor de PI com duas
casas decimais.*/
namespace Membros_Estaticos
{
    internal class Program
    {
        static double Pi = 3.14;

        static void Main(string[] args)
        {
            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Circunferencia(raio);
            double volume = Volume(raio);


            Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Pi.ToString("F2", CultureInfo.InvariantCulture));
        }
        static double Circunferencia(double r)
        {
            return 2.0 * Pi * r;
        }
        static double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * r * r * r;
        }
    }
}
