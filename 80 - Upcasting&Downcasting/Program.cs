/*Upcasting é um casting(conversão) de um objeto da sublasse(a classe que herda) para a superclasse a classe base 
 * Seu uso comum: Polimorfismo
 * 
 * Downcasting é um casting(conversão) de um objeto da superclasse a classe base para sublasse(a classe que herda)
 * palavra "as" usado para fazer o casting
 * palavra "is" usado para verificar se é.
 * Seu uso comum: métodos que recebem parâmetros genéricos(ex: Equals)
 */

//----------------------------------------------------------------------------------------------------------------------------------------------------//
//            Account                              BusinessAccount                         SavingAccount
//       -number: Integer                         -number: Integer                     -interestReate: Double
//       -holder: String                          -holder String
//       -balance: Double                         -balance: Double
//                                                -LoanLimit: Double
//----------------------------------     ---------------------------------------   -----------------------------
//  +withdrow(amount: Double): void          +withdrow(amount: Double): void      +updateBalance() : void
//  +deposit(amount: Double): void           +deposit(amount: Double): void 
//                                           +Loan(amount: Double): void 


using System;
using UpcastingDowncasting.Entities;

namespace UpcastingDowncasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta acc = new Conta(1001, "Alex", 0.0);
            ContaEmpresarial caemp = new ContaEmpresarial(1002, "Maria", 0.0, 500.0);

            //UPCASTING

            // No Upcasting as variáveis do tipo classe base(Conta) podem receber qualquer objeto cujo a variável seja do tipo de uma subclasse
            //(ContaEmpresarial, ContaPoupança)

            Conta acc1 = caemp;
            Conta acc2 = new ContaEmpresarial(1003, "Bob", 0.0, 200.0);
            Conta acc3 = new ContaPoupanca(1004, "Anna", 0.0, 0.01);



            //DOWNCASTING
            // A variável acc2 ela é do tipo conta por mais que ela tenha sido instanciada do tipo contaempresarial, por isso precisa converter

            ContaEmpresarial caemp1 = (ContaEmpresarial)acc2;


            //Neste caso a variável acc3 é do tipo conta instanciada do tipo contapoupança que não pode ser convertido para o tipo contaempresarial
            //Esse erro só aparece quando o projeto é compilado
            //Para evitar esse tipo de erro usamos uma verificação

            //ContaEmpresarial caemp3 =(ContaEmpresarial)acc3;

            if(acc3 is ContaEmpresarial)
            {
                //sintaxe alternativa para casting 
                //ContaEmpresarial acc5 = acc3 as ContaEmpresarial;

                ContaEmpresarial acc4 = (ContaEmpresarial)acc3;
                acc4.Emprestimo(200.0);
                Console.WriteLine("Emprestimo!");
            }

            if (acc3 is ContaPoupanca)
            {
                ContaPoupanca acc5 = acc3 as ContaPoupanca;
                acc5.AtualizarSaldo();
                Console.WriteLine("Atualizado!");
            }
        }
    }
}
