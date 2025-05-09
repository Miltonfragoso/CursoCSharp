/*
 * Classes abstratas são classes que não podem ser instanciadas é uma forma de garantir herança total.
 * Somente subclasses não abstratas podem ser instanciada, mas nunca a superclasse abstrata. 
 * 
 * Podemos herdar uma classe abstrata e aproveitar o reuso e o polimorfismo. Só não vai ser instanciado.
 */




using ClassesAbstratas.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace ClassesAbstratas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Não pode instanciar uma classe abstrata
            //Conta acc1 = new Conta(1001, "Alex", 500.0);

            //Conta acc2 = new ContaPoupanca(1002, "Ana", 500.0, 0.01);

            //acc1.Saque(10.0);
            //acc2.Saque(10.0);

            //Console.WriteLine(acc1.Saldo);
            //Console.WriteLine(acc2.Saldo);

            Console.WriteLine("--------------------------------------------------");

            //suponha que você queira:
            //Totalizar o saldo de todas as contas.
            //Sacar 10.00 de todas as contas.

            //mesmo sendo uma classe abstrata podemos usar como tipo de uma lista
            List<Conta> list = new List<Conta>();


            //Adicionando elementos a lista
            list.Add(new ContaPoupanca(1001, "Alex", 500.0, 0.01));
            list.Add(new ContaEmpresarial(1002, "Maria", 500.0, 400.0));
            list.Add(new ContaPoupanca(1003, "Bob", 500.0, 0.01));
            list.Add(new ContaEmpresarial(1003, "Ana", 500.0, 500.0));

            //Totalizar o saldo de todas as contas.
            //desta forma podemos aproveitar a propriedade "Saldo" da classe selada que foi herdada
            double soma = 0;
            foreach (Conta conta in list) 
            {
                soma += conta.Saldo;

            }

            Console.WriteLine("Saldo total: " + soma.ToString("F2", CultureInfo.InvariantCulture));

            foreach(Conta conta in list)
            {
                conta.Saque(10.0);
            }
            foreach(Conta conta in list)
            {
                Console.WriteLine("Saldo atualizado para a conta: " + conta.Numero + ": " + conta.Saldo.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
