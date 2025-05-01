/*Herança é um tipo de associação que permite que uma classe herde dados e comportamentos de outra
 *Vantagens do seu uso, Reuso e Polimorfismo. 
 */

/*
 * Suponha um negócio de banco que possui uma conta comum e uma conta para
 * empresas, sendo que a conta para empresa possui todos membros da conta
 * comum, mais um limite de empréstimo e uma operação de realizar empréstimo.
 */

//----------------------------------------------------------------------------------------------------------------------------------------------------//
//                                          Account                                 BusinessAccount
//                                         -number: Integer                         -number: Integer
//                                         -holder: String                          -holder String
//                                         -balance: Double                         -balance: Double
//                                                                                  -LoanLimit: Double
//                                  ----------------------------------     -------------------------------------------
//                                    +withdrow(amount: Double): void          +withdrow(amount: Double): void
//                                    +deposit(amount: Double): void           +deposit(amount: Double): void 
//                                                                             +Loan(amount: Double): void 



using Heranca.Entities;
using System;

namespace Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaEmpresarial contaEmpresarial = new ContaEmpresarial(8010, "Bob Brown", 100.0, 500.0);

            Console.WriteLine(contaEmpresarial.Saldo);

            //por útilizar o modificador de acesso proteted, o atributo saldo só pode ser modificado na classe base e em classes derivadas
            // contaEmpresarial.Saldo = 200.0;
        }
    }
}
