using DemoLinqLambla.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DemoLinqLambla
{
    internal class Program
    {
        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);

            foreach (T obj in collection)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Categoria c1 = new Categoria() { Id = 1, Nome = "Ferramentas", Nivel = 2 };
            Categoria c2 = new Categoria() { Id = 2, Nome = "Computadores", Nivel = 1 };
            Categoria c3 = new Categoria() { Id = 3, Nome = "Eletrônicos", Nivel = 1 };

            List<Produto> produtos = new List<Produto>()
            {
                new Produto() { Id = 1, Nome = "Computador", Preco = 1100.0, Categoria = c2 },
                new Produto() { Id = 2, Nome = "Impressora", Preco = 300.0, Categoria = c2 },
                new Produto() { Id = 3, Nome = "Mouse", Preco = 20.0, Categoria = c2 },
                new Produto() { Id = 4, Nome = "Mesa de escritório", Preco = 70.0, Categoria = c1 },
                new Produto() { Id = 5, Nome = "Martelo", Preco = 90.0, Categoria = c1 },
                new Produto() { Id = 6, Nome = "Serrote", Preco = 80.0, Categoria = c1 },
                new Produto() { Id = 7, Nome = "TV true color", Preco = 1200.0, Categoria = c3 },
                new Produto() { Id = 8, Nome = "Roçadeira", Preco = 800.0, Categoria = c1 },
                new Produto() { Id = 9, Nome = "Abajour", Preco = 100.0, Categoria = c1 },
                new Produto() { Id = 10, Nome = "Nível", Preco = 70.0, Categoria = c1 },
                new Produto() { Id = 11, Nome = "Computador", Preco = 1300.0, Categoria = c2 },
                new Produto() { Id = 12, Nome = "Mouse", Preco = 40.0, Categoria = c2 },
                new Produto() { Id = 13, Nome = "Tablet", Preco = 700.0, Categoria = c2 },
                new Produto() { Id = 14, Nome = "Headset", Preco = 350.0, Categoria = c2 }
            };

            var r1 = produtos.Where(p => p.Categoria.Nivel == 1 && p.Preco < 900.0);
            Print("Mostrar todos produtos de nível 1 e preço < 900:", r1);


            var r2 = produtos.Where(p => p.Categoria.Nome == "Ferramentas").Select(p => p.Nome);
            Print("Mostrar os produtos da categoria ferramentas", r2);

            // Criação de uma projeção anonimo que não esta declarada em nenhuma classe
            var r3 = produtos.Where(p => p.Nome[0] == 'C').Select(p => new { p.Nome, p.Preco, CategoriaNome = p.Categoria.Nome });
            Print("Produtos que começam com a letra 'C' e projeção anonima", r3);


            var r4 = produtos.Where(p => p.Categoria.Nivel == 1).OrderBy(p => p.Preco).ThenBy(p => p.Nome);
            Print("Produtos de nível 1 ordenados por preço e depois por nome", r4);

            var r5 = r4.Skip(2).Take(4);
            Print("Pular os 2 primeiros e mostrar os 4 próximos", r5);

            var r6 = produtos.FirstOrDefault();
            Console.WriteLine("Primeiro produto da coleção (ou nulo):" + r6);

            var r7 = produtos.Where(p => p.Preco > 3000.0).FirstOrDefault();
            Console.WriteLine("Primeiro produto com preço > 3000 (ou nulo):" + r7);

            var r8 = produtos.Where(p => p.Id == 3).SingleOrDefault();
            Console.WriteLine("Produto com Id = 3 (ou nulo):" + r8);

            var r9 = produtos.Max(p => p.Preco);
            Console.WriteLine("Produto com maior preço" + r9);

            var r10 = produtos.Min(p => p.Preco);
            Console.WriteLine("Produto com menor preço" + r10);

            var r11 = produtos.Where(p => p.Categoria.Id == 1).Sum(p => p.Preco);
            Console.WriteLine("Soma dos preços dos produtos da categoria 1: " + r11);

            var r12 = produtos.Where(p => p.Categoria.Id == 1).Average(p => p.Preco);
            Console.WriteLine("Média dos preços dos produtos da categoria 1: " + r12);

            var r13 = produtos.Where(p => p.Categoria.Id == 1).Select(p => p.Preco).Aggregate(0.0, (x, y) => x + y);
            Console.WriteLine("Soma usando Aggregate: " + r13);

            var r14 = produtos.GroupBy(p => p.Categoria);
            foreach (IGrouping<Categoria, Produto> grupo in r14)
            {
                Console.WriteLine("Categoria " + grupo.Key.Nome + ":");

                foreach (Produto p in grupo)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine();

            }
        }
    }
}
