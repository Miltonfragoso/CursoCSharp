/*
 * Fazer um programa para ler os dados de N contribuintes (N fornecido pelo usuário), os quais
    podem ser pessoa física ou pessoa jurídica, e depois mostrar o valor do imposto pago por cada um,
    bem como o total de imposto arrecadado.
    Os dados de pessoa física são: nome, renda anual e gastos com saúde. Os dados de pessoa jurídica
    são nome, renda anual e número de funcionários. As regras para cálculo de imposto são as
    seguintes:
    Pessoa física: pessoas cuja renda foi abaixo de 20000.00 pagam 15% de imposto. Pessoas com
    renda de 20000.00 em diante pagam 25% de imposto. Se a pessoa teve gastos com saúde, 50%
    destes gastos são abatidos no imposto.
    Exemplo: uma pessoa cuja renda foi 50000.00 e teve 2000.00 em gastos com saúde, o imposto
    fica: (50000 * 25%) - (2000 * 50%) = 11500.00
    Pessoa jurídica: pessoas jurídicas pagam 16% de imposto. Porém, se a empresa possuir mais de 10
    funcionários, ela paga 14% de imposto.
    Exemplo: uma empresa cuja renda foi 400000.00 e possui 25 funcionários, o imposto fica:
    400000 * 14% = 56000.00

        CONTRIBUINTE                   INDIVIDUAL : CONTRIBUINTE      EMPRESA : CONTRIBUINTE
--------------------------         ----------------------------   ------------------------------
     - nome: String                   -gastosComSaude: Double       - numeroDeFuncionarios: int
     - rendaAnual: Double
--------------------------         ----------------------------   -------------------------------
     + imposto()
--------------------------         -----------------------------   ------------------------------
 * 
 */

using ExercícioDeFixacaoMetodosabstratos.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.Serialization;
using System.Threading.Channels;

namespace ExercícioDeFixacaoMetodosabstratos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Contribuinte> list = new List<Contribuinte>();

            //bool gastosComsaude = false;

            Console.Write("Insira o número de Contribuintes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Insira os dados do Contribuinte #{i}");

                Console.Write("Individual ou empresa (i/e)? ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Renda anual: ");
                double rendaAnual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'e')
                {
                    Console.Write("Número funcionarios: ");
                    int numero = int.Parse(Console.ReadLine());

                    list.Add(new Empresa(nome, rendaAnual, numero));
                }
                else
                {
                    Console.Write("Teve gastos com saúde(s/n)? ");
                    char sd = char.Parse(Console.ReadLine());

                    if (sd == 's')
                    {
                        bool gastosComSaude = true;

                        Console.Write("Qual o valor dos gastos com a saúde: ");
                        double saude = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        list.Add(new Individual(nome, rendaAnual, saude, gastosComSaude));
                    }
                    else
                    {
                        bool gastosComSaude = false;
                        list.Add(new Individual(nome, rendaAnual, gastosComSaude));
                    }
                }
            }

            double soma = 0.0;
            Console.WriteLine();
            Console.WriteLine("IMPOSTO PAGO: ");
            foreach(Contribuinte contribuinte in list)
            {
                double taxa = contribuinte.Imposto();
                Console.WriteLine(contribuinte.Nome + ": $ " + contribuinte.Imposto().ToString("F2", CultureInfo.InvariantCulture));
                soma += taxa;
               
            }
            Console.WriteLine();
            Console.Write("TOTAL DE IMPOSTOS ARRECADADOS: $ " + soma.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();
        }
    }
}
