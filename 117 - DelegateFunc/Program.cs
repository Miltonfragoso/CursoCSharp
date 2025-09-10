/*
 * Problema exemplo
    Fazer um programa que, a partir de uma lista de produtos, gere uma
    nova lista contendo os nomes dos produtos em caixa alta.
 */

using DelegateFunc.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DelegateFunc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Produto> list = new List<Produto>();

            list.Add(new Produto("Tv", 900.00));
            list.Add(new Produto("Mouse", 50.00));
            list.Add(new Produto("Tablet", 350.50));
            list.Add(new Produto("HD Case", 80.90));



            //Func<Produto, string> func = p => p.Nome.ToUpper();
            //List<string> func = list.Select(p => p.Nome.ToUpper()).ToList();
            //Func<Produto, string> func = NomeComLetrasMaiusculas;
            //List<string> nomes = list.select(func).ToList();

            List<string> nomes = list.Select(NomeComLetrasMaiusculas).ToList();
            foreach (string nome in nomes)
            {
                Console.WriteLine(nome);
            }
        }
        static string NomeComLetrasMaiusculas(Produto p)
        {
            return p.Nome.ToUpper();
        }
    }
}
