using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesMetodosSelados.Enteties
{
    //Ao colocar a palavra Sealed impedimos que essa classe seja herdada
    sealed class ContaPoupanca : Conta
    {
        public double TaxaJuros { get; set; }

        public ContaPoupanca()
        {
        }

        public ContaPoupanca(int numero, string titular, double saldo, double taxaJuros) : base(numero, titular, saldo)
        {
            TaxaJuros = taxaJuros;
        }

        public void AtualizarSaldo()
        {
            Saldo += Saldo * TaxaJuros;
        }

        //sobrescrevendo o método saque
        public override void Saque(double quantia)
        {
            Saldo -= (quantia);
        }
    }
}
