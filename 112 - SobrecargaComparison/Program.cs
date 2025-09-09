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

            //Comparison<Produto> comp = CompareProduto;
            //list.Sort(comp);

            //list.Sort(CompareProduto);

            //Comparison<Produto> comp = (p1, p2) => p1.Nome.ToUpper().CompareTo(p2.Nome.ToUpper());

            list.Sort((p1, p2) => p1.Nome.ToUpper().CompareTo(p2.Nome.ToUpper()));




            foreach (Produto item in list)
            {
                Console.WriteLine(item);
            }



        }
        // Esta função deve obedecer a assinatura do delegate Comparison<T> que é receber dois parâmetros do tipo T e retornar um int
        //static int CompareProduto(Produto p1, Produto p2)
        //{
        //    return p1.Nome.ToUpper().CompareTo(p2.Nome.ToUpper());
        //}
    }
}
