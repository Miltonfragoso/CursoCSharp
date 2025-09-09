using SobrecargaComparison.Entities;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace SobrecargaComparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Produto> list = new List<Produto>();

            list.Add(new Produto("TV", 900.00));
            list.Add(new Produto("Notebook", 1200.00));
            list.Add(new Produto("Tablet", 450.00));

            list.Sort(CompareProduto);

            foreach (Produto item in list)
            {
                Console.WriteLine(item);
            }



        }

        static int CompareProduto(Produto p1, Produto p2)
        {
            return p1.Nome.ToUpper().CompareTo(p2.Nome.ToUpper());
        }
    }
}
