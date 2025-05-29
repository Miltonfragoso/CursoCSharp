/*
 * Exceções: 
 * Uma exceção é qualquer condição de erro ou comportamento inesperado encontrado por um programa em execução
 * No .NET, uma exceção é um objeto herdado da classe System.Exception
 * Quando lançada, uma exceção é propagada na pilha de chamadas de métodos em execução, até que seja capturada (tratada) ou o programa seja encerrado
 * 
 * 
 * A classe exception é subdividida em duas, que são a SystemException e a ApplicationException a existência dessas duas classes é uma forma de 
 * permitir diferenciar exceções de sistema e exceções da sua aplicação onde SystemException são as exceções do sistema já definidas e 
 * ApplicationException são as exceções que serão criadas por você mesmo do seu sitema.
 * 
 * 
 * Exception 
 * 
 * 1- SystemException 
 *           ||
 * IndexOutOfRangeException, NullReferenceException, InvalidCastException, OutOfMemoryException, (ArgumentException =>ArgumentNullException ArgumentOutOfRangeException)
   (ExternalException => ComException SEHException), (ArithmeticException => DivideByZeroException OverflowException),FormatException

 *2-  ApplicationException === (Recomendado para criar as proprias exceções)
 *
 *
 *Estrutura try-catch
 * • Bloco try Contém o código que representa a execução normal do trecho de código que pode acarretar em uma exceção
 * • Bloco catch Contém o código a ser executado caso uma exceção ocorra Deve ser especificado o tipo da exceção a ser tratada (upcasting é permitido)
 *
 */

using System;

namespace Excecoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int Divisao = n1 / n2;

                Console.WriteLine(Divisao);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Não é permitido divisão por zero");
            }
            catch (FormatException)
            {
                Console.WriteLine("Não é permitido letras, apenas números");
            }

        }
    }
}
