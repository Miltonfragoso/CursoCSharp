using System;
using System.Globalization;

/* Fazer um programa para ler nome e salário de dois funcionários. Depois, mostrar o salário
   médio dos funcionários.
*/

namespace Exerc_Class_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Funcionario A = new Funcionario();
            Funcionario B = new Funcionario();

            Console.WriteLine("Digite os dados do funcionario A: ");
            A.Nome = Console.ReadLine();
            A.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite os dados do funcionario B: ");
            B.Nome = Console.ReadLine();
            B.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double Salariomedio = (A.Salario + B.Salario) / 2.0;
            Console.WriteLine("Salario Médio = " + Salariomedio.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
