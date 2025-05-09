/*Uma empresa possui funcionários próprios e terceirizados. Para cada funcionário, deseja-se registrar nome, horas
 * trabalhadas e valor por hora. Funcionários terceirizados possuem ainda uma despesa adicional.
 * O pagamento dos funcionários corresponde ao valor da hora multiplicado pelas horas trabalhadas, sendo que os funcionários 
 * terceirizados ainda recebem um bônus correspondente a 110% de sua despesa adicional. Fazer um programa para ler os dados de N funcionários 
 * (N fornecido pelo usuário) e armazená-los em uma lista. Depois de ler todos os dados, mostrar nome e pagamento de cada funcionário na mesma ordem
 * em que foram digitados. Construa o programa conforme projeto ao lado. Veja exemplo na próxima página.
 */

//           Funcionario              FuncionarioTercerizado : Funcioario
//------------------------------    --------------------------------------
//      -nome: String                       - taxaAdicional: Double
//      -Horas: Integer
//      -ValorPorHora: Double
//------------------------------   ----------------------------------------
//     + pagamento(): Double       + pagamento(): Double

using Polimorfismo.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> list = new List<Funcionario>();

            Console.Write("Insira o número de funcionarios:" );
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i<= n; i++) 
            {
                Console.WriteLine($"Insira os dados do funcionario #{i}");
                Console.Write("É tercerizado (y/n)? :");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Nome:");
                string nome = Console.ReadLine();

                Console.Write("Quantidade de horas: ");
                int horas = int.Parse(Console.ReadLine());

                Console.Write("Valor por horas: ");
                double vphoras = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(ch == 'y')
                {
                    Console.Write("Despesa adicional: ");
                    double dispesaAdicional = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new FuncionarioTercerizado(nome, horas, vphoras, dispesaAdicional));

                }
                else
                {
                     list.Add(new Funcionario(nome, horas, vphoras));   
                }
            }
            Console.WriteLine();
            Console.WriteLine("pAGAMENTOS");
            foreach(Funcionario func in list)
            {
                Console.WriteLine(func.Nome + " - $ " + func.Pagamento().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
