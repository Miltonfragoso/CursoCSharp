/*Sobreposição ou sobrescrita é a implementação de um método de uma superclasse na subclasse
 * 
 * Para que um método comum (Não abstrato) possa ser sobreposto, deve ser incluído nele o prefico "VIRTUAL"
 * 
 * Ao sobrescrever um método, devemos incluir nele o prefixo "override"
 */


using SobreposicaoSobrescrita.Entities;
using System;

namespace SobreposicaoSobrescrita
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta acc1 = new Conta(1001, "Alex", 500.0);
            Conta acc2 = new ContaPoupanca(1002, "Ana", 500.0, 0.01);

            acc1.Saque(10.0);
            acc2.Saque(10.0);

            Console.WriteLine(acc1.Saldo);
            Console.WriteLine(acc2.Saldo);
        }
    }
}
