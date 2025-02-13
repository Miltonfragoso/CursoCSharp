﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExercicioContaBancaria
{
    internal class ContaBancaria
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
            Saldo = 0.0;
        }

        // passando o construtor de 2 argumentos para o de 3 usando a palavra this
        public ContaBancaria(int numero, string titular, double depositoInicial) : this(numero, titular)
        {
            Deposito(depositoInicial);
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia + 5.0;
        }

        public override string ToString()
        {
            return "Conta: "
                    + Numero
                    + ", Titular: "
                    + Titular
                    + ", Saldo: $ "
                    + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
