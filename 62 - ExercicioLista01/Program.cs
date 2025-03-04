/*Fazer um programa para ler um número inteiro N e depois os dados (id, nome e salario) de
    N funcionários. Não deve haver repetição de id.
    Em seguida, efetuar o aumento de X por cento no salário de um determinado funcionário.
    Para isso, o programa deve ler um id e o valor X. Se o id informado não existir, mostrar uma
    mensagem e abortar a operação. Ao final, mostrar a listagem atualizada dos funcionários,
    conforme exemplos.
    Lembre-se de aplicar a técnica de encapsulamento para não permitir que o salário possa
    ser mudado livremente. Um salário só pode ser aumentado com base em uma operação de
    aumento por porcentagem dada.
 * 
 */
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioLista01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("How many employees will be registered: ");
            int N = int.Parse(Console.ReadLine());

            List<Funcionario> list = new List<Funcionario>();

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine("Funcionário #" + i + ":");

                Console.Write("Id: ");
                int Id = int.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                string Nome = (Console.ReadLine());

                Console.Write("Salário: ");
                double Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                list.Add(new Funcionario(Id, Nome, Salario));
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("Enter the employee id that will have salary increase : ");
            int searchId = int.Parse(Console.ReadLine());

            Funcionario emp = list.Find(x => x.Id == searchId);

            if (emp != null) {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            foreach(Funcionario funcionario in list) { 
                Console.WriteLine(funcionario); 
            }

        }

    }
}

