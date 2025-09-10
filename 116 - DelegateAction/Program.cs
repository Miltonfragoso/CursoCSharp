/*Problema exemplo
    Fazer um programa que, a partir de uma lista de produtos, aumente o
    preço dos produtos em 10%.
 */


using DelegateAction.Entities;
using System;
using System.Collections.Generic;

namespace DelegateAction
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Produto> list = new List<Produto>();

            list.Add(new Produto("Tv", 900.00));
            list.Add(new Produto("Mouse", 50.00));
            list.Add(new Produto("Tablet", 350.50));
            list.Add(new Produto("HD Case", 80.90));

            ////Outras formas de usar o Action
            //Action<Produto> action = AumentarPreco;
            //list.ForEach(action);
            ////ou dessa forma, onde usamos a expressão lambda as chaves são para simbolizar que a funão é void
            //Action<Produto> action2 = p => { p.Preco += p.Preco * 0.1; };


            list.ForEach(AumentarPreco);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        static void AumentarPreco(Produto p)
        {
            p.Preco += p.Preco * 0.1;
        }
    }

}
