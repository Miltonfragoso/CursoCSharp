using System;


/* Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais
   velha.
*/

namespace Exerc_Class_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa();
            Pessoa pessoa2 = new Pessoa();

            Console.WriteLine("Digite Dados da primeira pessoa: ");
            Console.WriteLine("Nome: ");
            pessoa1.Nome = Console.ReadLine();
            Console.WriteLine("Idade: ");
            pessoa1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite Dados da Segunda pessoa: ");
            Console.WriteLine("Nome: ");
            pessoa2.Nome = Console.ReadLine();
            Console.WriteLine("Idade: ");
            pessoa2.idade = int.Parse(Console.ReadLine());


            if (pessoa1.idade > pessoa2.idade)
            {
                Console.WriteLine("A pessoa mais velha é o (a): " + pessoa1.Nome);
            }
            else
            {
                Console.WriteLine("A pessoa mais velha é o (a) " + pessoa2.Nome);
            }
        }
    }
}
