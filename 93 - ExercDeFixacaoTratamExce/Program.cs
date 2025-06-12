/*
 * Fazer um programa para ler os dados de uma conta bancária e depois realizar um
 * saque nesta conta bancária, mostrando o novo saldo. Um saque não pode ocorrer
 * ou se não houver saldo na conta, ou se o valor do saque for superior ao limite de
 * saque da conta. Implemente a conta bancária conforme projeto abaixo:
 * 
 *                               ----------------------------------------                 
 *                               -                 Conta                -
 *                               ----------------------------------------      
 *                               -         - numero: int                -
 *                               -         - titular: String            -
 *                               -         - saldo: Double      
 *                               -    - limiteDeSaque: Double           -
 *                               ----------------------------------------
 *                               -  + deposito(quantia: Double) : void  -
 *                               -  + saque(quantia: Double) : void     -
 *                               ----------------------------------------
 *                               
 */
using ExercDeFixacaoTratamExce.Entities;
using ExercDeFixacaoTratamExce.Entities.Exceptions;
using System;
using System.Globalization;

namespace ExercDeFixacaoTratamExce
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Entre com os dados da conta");

            Console.Write("Número: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Titular: ");
            string titular = Console.ReadLine();

            Console.Write("Saldo ínicial: ");
            double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Limite de saque: ");
            double limiteDeSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Conta conta = new Conta(numero, titular, saldo, limiteDeSaque);

            Console.WriteLine();
            Console.Write("Entre com o valor a para saque: ");
            double saqueDeSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            try
            {
                conta.Saque(saqueDeSaque);

                Console.Write("Saldo atualizado: " + conta.Saldo.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch (DomainExceptions e)
            {
                Console.WriteLine("Erro no saque: " + e.Message);
            }
        }
    }
}
