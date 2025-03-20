/*
 * DateTime representa um INSTANTE e é um tipo VALOR(STRUCT)
 * 
 */
using System;
using System.Globalization;
using System.Security.Cryptography;

namespace Datas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Como é a representação interna do DateTime: Um objeto DateTime internamente armazena: O número de "ticks"(100 nanosegundos) desde a meia noite do dia 1 dejaneiro do ano 1 da era comum


            //Como Instanciamos um DateTime
            //Construtores
            DateTime d2 = new DateTime(2018, 11, 25);
            DateTime d3 = new DateTime(2018, 11, 25, 20,45,3);
            DateTime d4 = new DateTime(2018, 11, 25, 20, 45, 3, 500);
            //Builders
            DateTime d1 = DateTime.Now;
            DateTime d5 = DateTime.Today;
            DateTime d6 = DateTime.UtcNow;

            //Como é formatação conversão de DateTime para String
            DateTime d7 = DateTime.Parse("2000-08-15");
            DateTime d8 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d9 = DateTime.Parse("15/08/2000");
            DateTime d10 = DateTime.Parse("15/08/2000 13:05:58");

            DateTime d11 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime d12 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss",CultureInfo.InvariantCulture);

            Console.WriteLine(d1.Ticks);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);
            Console.WriteLine(d7);
            Console.WriteLine(d8);
            Console.WriteLine(d9);
            Console.WriteLine(d10);
            Console.WriteLine(d11);
            Console.WriteLine(d12);
        }
    }
}
