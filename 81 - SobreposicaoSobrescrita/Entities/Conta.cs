using System;
using System.Collections.Generic;
using System.Text;

namespace SobreposicaoSobrescrita.Entities
{
    internal class Conta
    {
        public int Numero { get; private set; }
        public string Titular { get; private set; }
        public double Saldo { get; protected set; }

        public Conta()
        {
        }

        public Conta(int numero, string titular, double saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }

        //Para conta comum cobra taxa de 5.00
        // A palavra Virtual indica que o método pode ser sobrescrito nas subclasses
        public  virtual void Saque(double quantia)
        {
            Saldo -= quantia + 5.0;
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }
    }
}
