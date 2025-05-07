using System;
using System.Collections.Generic;
using System.Text;

namespace SobreposicaoSobrescrita.Entities
{
    internal class ContaEmpresarial : Conta
    {
        public double LimiteParaEmprestimo { get; set; }

        public ContaEmpresarial()
        {
        }

        /*Quando uma classe herda de outra, podemos reutilizar o construtor da classe base
         * com : base podemos acessar todos os construtores da classe base.
         *isso: base(numero, titular, saldo) é igual a Numero= numero; Titular = titular; Saldo = saldo
         */
        public ContaEmpresarial(int numero, string titular, double saldo, double limiteParaEmprestimo) : base(numero, titular, saldo)
        {
            LimiteParaEmprestimo = limiteParaEmprestimo;
        }

        public void Emprestimo(double quantia)
        {
            if (quantia <= LimiteParaEmprestimo)
            {
                Saldo += quantia;
            }
        }
    }
}
