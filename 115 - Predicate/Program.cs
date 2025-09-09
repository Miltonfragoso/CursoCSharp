/*Fazer um programa que, a partir de uma lista de produtos, remova da
lista somente aqueles cujo preço mínimo seja 100.
 */

using Predicate.Entities;
using System.Collections.Generic;

namespace Predicate
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

            //Podemos usar uma expressão lambda para definir a condição de remoção desde que atenda a assinatura do Predicate que é:
            //receber um objeto como paramêtro e retornar um booleano.
            list.RemoveAll(p => p.Preco >= 100.0);

            list.RemoveAll(TestarProduto);

            //Foreach para mostrar os produtos restantes na lista
            foreach (Produto p in list)
            {
                System.Console.WriteLine(p);
            }
        }

        //Outra forma de fazer é criar um método estático que atenda a assinatura do Predicate e passar esse método como argumento do RemoveAll
        //Passando o método como argumento no RemoveAll
        public static bool TestarProduto(Produto p)
        {
            return p.Preco >= 100.0;
        }
    }
}
