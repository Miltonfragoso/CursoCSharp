/*
Uma locadora brasileira de carros cobra um valor por hora para locações de até
12 horas. Porém, se a duração da locação ultrapassar 12 horas, a locação será
cobrada com base em um valor diário. Além do valor da locação, é acrescido no
preço o valor do imposto conforme regras do país que, no caso do Brasil, é 20%
para valores até 100.00, ou 15% para valores acima de 100.00. Fazer um
programa que lê os dados da locação (modelo do carro, instante inicial e final da
locação), bem como o valor por hora e o valor diário de locação. O programa
deve então gerar a nota de pagamento (contendo valor da locação, valor do
imposto e valor total do pagamento) e informar os dados na tela */


using ExercSemInterface.Entities;
using System;
using System.Globalization;
using ExercSemInterface.Services;

namespace ExercSemInterface
{
    public  class Program
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

            AluguelService aluguelService = new AluguelService(precoPorHora, precoPorDia);

            aluguelService.ProcessarFatura(aluguelDeCarro);

            Console.WriteLine("FATURA: ");
            Console.WriteLine(aluguelDeCarro.Fatura);

        }
    }
}
