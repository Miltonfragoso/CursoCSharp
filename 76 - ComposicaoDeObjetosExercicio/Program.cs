/*Fazer um programa para ler os dados de um trabalhador com N contratos (O número de contratos sera fornecido pelo usuário)
 *Depois, solicitar do usuário um mês e mostrar qual foi o salário do funcionário nesse mês.
 *O programa vai ter 3 classe: Trabalhador=nome,nível(enum), Salario base, addcontrato, removercontrato, RendaMensal
 *ContratoPorHora=Data, valor por hora, horas total do contrato  e valor total; Departamento=nome.
 */
using System;
using System.Globalization;
using ComposicaoDeObjetosExercicio.Entities;
using ComposicaoDeObjetosExercicio.Entities.Enums;

namespace ComposicaoDeObjetosExercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dados do objeto departamento 
            Console.Write("Entre com o nome do departamento: ");
            string nomeDepartamento = Console.ReadLine();


            //Dados do objeto trabalhador
            Console.WriteLine("Entre com os dados do trabalhador");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("qual o nível? (Junior/Pleno/Senior): ");
            //Conversão de string(nível) que o usuário digitar para tipo enum
            NivelDoTrabalhador nivel = Enum.Parse<NivelDoTrabalhador>(Console.ReadLine());

            Console.Write("qual é o salário base?: ");
            double salarioBase = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Instanciando os obejtos passando os dados vindo da tela
            Departamento dept = new Departamento(nomeDepartamento);
            //Ao instanciarmos um objeto podemos passar como parametro a instancia de outro objeto ex: dept
            Trabalhador trabalhador = new Trabalhador(nome, nivel, salarioBase, dept);



            //Dados do objeto contrato
            Console.Write("Quantos contratos serão cadastrado para esse trabalhador?: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Entre com os dados do contrato número #{i}");//interpolação
                Console.Write("Data (DD/MM/YY): ");
                DateTime data = DateTime.Parse(Console.ReadLine());
                Console.Write("Valor por hora: ");
                double valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duração por hora: ");
                int horas = int.Parse(Console.ReadLine());

                //instanciando o objeto contrato e passando no construtor os dados da tela 
                ContratoPorHora contrato = new ContratoPorHora(data, valorPorHora, horas);

                //adicionamos esse contrato na lista de contratos do trabalhador utilizando o método AddContratos
                trabalhador.AddContratos(contrato);

            }
            Console.WriteLine();
            Console.Write("Entre com o mês e o ano para calcular a renda mensal somando todos contratos (MM/YYY): ");

            string meseano = Console.ReadLine();
            int mes = int.Parse(meseano.Substring(0, 2));
            int ano = int.Parse(meseano.Substring(3));

            Console.WriteLine("Nome: " + trabalhador.Nome);
            Console.WriteLine("Departamento: " + trabalhador.Departamento.Nome);
            Console.WriteLine("Renda mensal: " + meseano + " : " + trabalhador.RendaMensal(ano, mes).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
