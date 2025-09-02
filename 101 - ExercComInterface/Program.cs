/*
 * ✅ Para que serve uma interface no C#?

Definir um contrato comum

Várias classes diferentes podem seguir o mesmo “contrato”.

Ex.: qualquer classe que implemente IAnimal deve ter o método Falar().

Polimorfismo

Permite tratar objetos diferentes de forma igual se eles implementam a mesma interface.

Ex.: você pode ter uma lista de IAnimal contendo Cachorro, Gato, Pato etc.

Separação de responsabilidades

Ajuda a organizar o código e aplicar princípios de design como SOLID (especialmente o I: Interface Segregation Principle).

Facilitar testes

Usando interfaces, você pode simular dependências (com mocks) em testes unitários.

Flexibilidade em arquiteturas

Permite trocar implementações sem quebrar o código.

Ex.: ILogger pode ter várias implementações (ConsoleLogger, FileLogger, DatabaseLogger).
 */



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

            AluguelService aluguelService = new AluguelService(precoPorHora, precoPorDia, new Imposto());

            aluguelService.ProcessarFatura(aluguelDeCarro);

            Console.WriteLine("FATURA: ");
            Console.WriteLine(aluguelDeCarro.Fatura);
        }
    }
}
