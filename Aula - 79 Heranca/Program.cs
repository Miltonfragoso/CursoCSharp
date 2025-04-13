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


using System;

namespace Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
