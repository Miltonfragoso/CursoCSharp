using GetHashCodeEquals.Entities;
using System;

namespace GetHashCodeEquals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tipos pre definidos ja possuem implementacao para essas operacoes Equals e GetHashCode
            string a = "Maria";
            string b = "Alex";

            string c = "Maria";
            string d = "Maria";

            Console.WriteLine(a.Equals(b));
            Console.WriteLine(c.Equals(d));



            Console.WriteLine("-------------------------------");

            string e = "Maria";
            string f = "Maria";

            Console.WriteLine(e.GetHashCode());
            Console.WriteLine(f.GetHashCode());


            Console.WriteLine("---------------Clase Personalizada----------------");

            Cliente g = new Cliente() { Nome = "Maria", Email = "maria@gmail.com" };
            Cliente h = new Cliente() { Nome = "Alex", Email = "alex@gmail.com" };

            Console.WriteLine(g.GetHashCode());
            Console.WriteLine(h.GetHashCode());


            Console.WriteLine(g.Equals(b));

        }
    }
}
