/*Problema
 * Uma empresa de consultoria deseja avaliar a performance de produtos,
funcionários, dentre outras coisas. Um dos cálculos que ela precisa é encontrar
o maior dentre um conjunto de elementos. Fazer um programa que leia um
conjunto de N produtos, conforme exemplo, e depois mostre o mais caro deles.

 Enter N: 3                                                             Criar um serviço de cálculo:
Computer,890.50                                                              + max<T>(List<T> list) T 
IPhone X,910.00
Tablet,550.00
Max:
IPhone, 910.00

 */

using ExercRestricoesGenerics.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using ExercRestricoesGenerics.Services;

namespace ExercRestricoesGenerics
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Produto> list = new List<Produto>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] vect = Console.ReadLine().Split(',');
                string name = vect[0];
                double price = double.Parse(vect[1], CultureInfo.InvariantCulture);
                list.Add(new Produto(name, price));
            }

            CalculationService calculationService = new CalculationService();

            Produto p = calculationService.Max(list); // <Product> is optional

            Console.WriteLine("Most expensive:");
            Console.WriteLine(p);
        }
    }
}
