using System;
using System.Collections.Generic;

namespace ConjuntosHashSetSortedSet
{
    public class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();

            set.Add("TV");
            set.Add("Notbook");
            set.Add("Tablet");

            Console.WriteLine(set.Contains("Hello World!"));

            foreach (string p in set) {
                Console.WriteLine(p);
            }

            Console.WriteLine("----------------------------------------------------------------------");

            SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10};
            SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10};

            ImprimirColecao(b);

            //União de conjuntos(lembrando que só vai elementos que ainda não existem no conjunto)
            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b);

            ImprimirColecao(c);

            // Interseção de conjuntos
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);
            ImprimirColecao(d);

            //Diferença de conjuntos
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);
            ImprimirColecao(e);
        }

        static void ImprimirColecao<T>(IEnumerable<T> colecao)
        {
            foreach (T obj in colecao) {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }
    }
}
