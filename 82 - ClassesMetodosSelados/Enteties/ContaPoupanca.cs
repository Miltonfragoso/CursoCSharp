using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesMetodosSelados.Enteties
{
    //Ao colocar a palavra Sealed impedimos que essa classe seja herdada
    class ContaPoupanca : Conta
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
        //ao incluir a palavra sealed estamos dizendo que esse método não pode ser sobrescrito novamente 
        public  sealed override void Saque(double quantia)
        {
            base.Saque(quantia);
            Saldo -= 2.0;
        }
    }
}
