using ExercComInterface.Entities;
using ExercComInterface.Services;
using System;
using System.Globalization;

namespace _101___ExercComInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do aluguel");

            Console.Write("Modelo do carro: ");
            string modelo = Console.ReadLine();

            Console.Write("Entrada (dd/MM/yyyy HH:mm): ");
            DateTime entrada = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Saída (dd/MM/yyyy HH:mm): ");
            DateTime saida = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Entre com o preço por hora: ");
            double precoPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Entre com o preço por dia: ");
            double precoPorDia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);



            AluguelDeCarro aluguelDeCarro = new AluguelDeCarro(entrada, saida, new Veiculo(modelo));

            AluguelService aluguelService = new AluguelService(precoPorHora, precoPorDia, new ImpostoNoBrasilService());

            aluguelService.ProcessarFatura(aluguelDeCarro);

            Console.WriteLine("FATURA: ");
            Console.WriteLine(aluguelDeCarro.Fatura);
        }
    }
}
