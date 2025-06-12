using ExercDeFixacaoTratamExce.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExercDeFixacaoTratamExce.Entities
{
    internal class Conta
    {
        public int Numero{ get; set; }
        public string Titular{ get; set; }
        public double Saldo{ get; set; }
        public double LimiteDeSaque { get; set; }


        public Conta()
        {
        }

        public Conta(int numero, string titular, double saldo, double limiteDeSaque)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
            LimiteDeSaque = limiteDeSaque;
        }

        public void Deposito(double quantiaDeDeposito)
        {
            Saldo += quantiaDeDeposito;
        }

        public void Saque(double quantiaDeSaque)
        {
            if (quantiaDeSaque > LimiteDeSaque)
            {
                throw new DomainExceptions("O valor para saque excedeu o limite de saque");
            }
            if (quantiaDeSaque > Saldo )
            { 
                throw new DomainExceptions("Não tem saldo suficiente");
            }
            Saldo -= quantiaDeSaque;
        }


        //public override string ToString()
        //{
        //    return "Conta: "
        //            + Numero
        //            + ", Titular: "
        //            + Titular
        //            + ", Saldo: $ "
        //            + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        //}
    }
}
